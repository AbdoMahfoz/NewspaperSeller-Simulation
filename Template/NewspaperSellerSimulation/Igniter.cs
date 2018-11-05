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
        /// The task queue that worker threads get their work from
        /// </summary>
        private Queue<SimulationCase> TaskQueue;
        /// <summary>
        /// The simulation system currently in use
        /// </summary>
        private SimulationSystem CurrentSystem;
        /// <summary>
        /// Synchronizes TaskQueue access
        /// </summary>
        private Mutex m;
        /// <summary>
        /// Worker thread function
        /// </summary>
        private void ParallelRunHelper()
        {
            int n = 0;
            while (true)
            {
                SimulationCase c;
                m.WaitOne();
                if (TaskQueue.Count == 0)
                {
                    m.ReleaseMutex();
                    break;
                }
                else
                {
                    c = TaskQueue.Dequeue();
                }
                m.ReleaseMutex();
                n++;
                Simulator.SimulationMain(c, CurrentSystem);
            }
            Console.WriteLine("Thread \"" + Thread.CurrentThread.Name + "\" simulated " + n + " cases");
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public Igniter()
        {
            m = new Mutex();
            TaskQueue = new Queue<SimulationCase>();
            CurrentSystem = null;
        }
        /// <summary>
        /// Runs the simulation through multiple threads
        /// </summary>
        /// <param name="system">The system to be simulated</param>
        public void ParallelRun(SimulationSystem system)
        {
            CurrentSystem = system;
            m.WaitOne();
            Thread[] threads = new Thread[Environment.ProcessorCount];
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                threads[i] = new Thread(new ThreadStart(ParallelRunHelper))
                {
                    Name = "Parallel Run #" + i.ToString()
                };
                threads[i].Start();
            }
            for (int i = 0; i < system.NumOfRecords; i++)
            {
                SimulationCase c = new SimulationCase
                {
                    DayNo = i + 1
                };
                TaskQueue.Enqueue(c);
                system.SimulationTable.Add(c);
            }
            m.ReleaseMutex();
            foreach (Thread t in threads)
            {
                t.Join();
            }
        }
        /// <summary>
        /// Runs the simulation sequentially
        /// </summary>
        /// <param name="system">The system to be simulated</param>
        public void SequntialRun(SimulationSystem system)
        {
            for (int i = 0; i < system.NumOfRecords; i++)
            {
                SimulationCase c = new SimulationCase()
                {
                    DayNo = i + 1
                };
                Simulator.SimulationMain(c, system);
                system.SimulationTable.Add(c);
            }
        }
    }
}
