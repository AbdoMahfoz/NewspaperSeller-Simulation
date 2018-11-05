using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    /// <summary>
    /// Ignites the simulation engine sequentially or in parallel
    /// </summary>
    static class Igniter
    {
        /// <summary>
        /// The task queue that worker threads get their work from
        /// </summary>
        static private Queue<SimulationCase> TaskQueue = new Queue<SimulationCase>();
        /// <summary>
        /// The simulation system currently in use
        /// </summary>
        static private SimulationSystem CurrentSystem;
        /// <summary>
        /// Synchronizes TaskQueue access
        /// </summary>
        static private Mutex m = new Mutex();
        /// <summary>
        /// Worker thread function
        /// </summary>
        static private void ParallelRunHelper()
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
        /// Runs the simulation through multiple threads
        /// </summary>
        /// <param name="system">The system to be simulated</param>
        static public void ParallelRun(SimulationSystem system)
        {
            CurrentSystem = system;
            m.WaitOne();
            Thread[] threads = new Thread[Environment.ProcessorCount];
            for(int i = 0; i < Environment.ProcessorCount; i++)
            {
                threads[i] = new Thread(new ThreadStart(ParallelRunHelper))
                {
                    Name = "Parallel Run #" + i.ToString()
                };
                threads[i].Start();
            }
            for(int i = 0; i < system.NumOfRecords; i++)
            {
                SimulationCase c = new SimulationCase();
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
        static public void SequntialRun(SimulationSystem system)
        {
            for(int i = 0; i < system.NumOfRecords; i++)
            {
                SimulationCase c = new SimulationCase();
                Simulator.SimulationMain(c, system);
                system.SimulationTable.Add(c);
            }
        }
    }
}
