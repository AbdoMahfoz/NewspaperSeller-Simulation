using System;
using System.Collections.Generic;
using System.Threading;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    /// <summary>
    /// Ignites the simulation engine sequentially or in parallel
    /// </summary>
    class Igniter
    {
        /// <summary>
        /// the random number generator
        /// </summary>
        private Random rnd;
        /// <summary>
        /// The simulation system currently in use
        /// </summary>
        private SimulationSystem CurrentSystem;
        /// <summary>
        /// Descripes wether this parallel run is a full run or re-evaluation run
        /// </summary>
        private Enums.RunningMode RunningMode;
        /// <summary>
        /// Work list in which all threads write their work
        /// </summary>
        private SimulationCase[] WorkList;
        /// <summary>
        /// Default constructor
        /// </summary>
        private Igniter()
        {
            WorkList = null;
            CurrentSystem = null;
        }
        /// <summary>
        /// Worker thread function
        /// </summary>
        private void ParallelRunHelper(object num)
        {
            int i = (int)num;
            while (i < CurrentSystem.NumOfRecords)
            {
                if(RunningMode == Enums.RunningMode.FullRun)
                {
                    SimulationCase c = new SimulationCase()
                    {
                        DayNo = i + 1
                    };
                    Simulator.SimulationMain(c, CurrentSystem, rnd);
                    WorkList[i] = c;
                }
                else
                {
                    Simulator.ReEvaluateProfit(CurrentSystem.SimulationTable[i], CurrentSystem);
                }
                i += Environment.ProcessorCount;
            }
        }
        /// <summary>
        /// Runs the simulation concurrently for this instance of Igniter class
        /// </summary>
        /// <param name="system">System to be simulated</param>
        /// <param name="rnd">Random number generator instance</param>
        private void ParallelRunStarter(SimulationSystem system, Random rnd = null)
        {
            this.rnd = rnd;
            CurrentSystem = system;
            if(RunningMode == Enums.RunningMode.FullRun)
            {
                WorkList = new SimulationCase[CurrentSystem.NumOfRecords];
            }
            Thread[] threads = new Thread[Environment.ProcessorCount];
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(ParallelRunHelper))
                {
                    Name = "Parallel Run #" + i.ToString() + " - " + GetHashCode().ToString()
                };
                threads[i].Start(i);
            }
            foreach (Thread t in threads)
            {
                t.Join();
            }
            if(RunningMode == Enums.RunningMode.FullRun)
            {
                CurrentSystem.SimulationTable = new List<SimulationCase>(WorkList);
            }
        }
        /// <summary>
        /// Runs the simulation through multiple threads
        /// </summary>
        /// <param name="system">The system to be simulated</param>
        /// <param name="rnd">Random number generator instance</param>
        static public void ParallelRun(SimulationSystem system, Random rnd = null)
        {
            new Igniter() { RunningMode = Enums.RunningMode.FullRun }.ParallelRunStarter(system, rnd);
        }
        /// <summary>
        /// Re-evaluates concurrently the system profit based on the pre-determined demand values
        /// </summary>
        /// <param name="system">The system to be re-evaluated</param>
        static public void ParallelReEvaluationRun(SimulationSystem system)
        {
            system.PerformanceMeasures = new PerformanceMeasures();
            new Igniter() { RunningMode = Enums.RunningMode.ReEvaluationRun }.ParallelRunStarter(system);
        }
        /// <summary>
        /// Runs the simulation sequentially
        /// </summary>
        /// <param name="system">The system to be simulated</param>
        static public void SequntialRun(SimulationSystem system, Random rnd = null)
        {
            for (int i = 0; i < system.NumOfRecords; i++)
            {
                SimulationCase c = new SimulationCase()
                {
                    DayNo = i + 1
                };
                Simulator.SimulationMain(c, system, rnd);
                system.SimulationTable.Add(c);
            }
        }
        /// <summary>
        /// Re-evalutes sequntially the system's profit based on predetermined demand values
        /// </summary>
        /// <param name="system">The system to be re-evaluated</param>
        static public void SequntialReEvaluationRun(SimulationSystem system)
        {
            system.PerformanceMeasures = new PerformanceMeasures();
            foreach(SimulationCase c in system.SimulationTable)
            {
                Simulator.ReEvaluateProfit(c, system);
            }
        }
    }
}
