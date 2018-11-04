using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    static class Igniter
    {
        static private Queue<SimulationCase> TaskQueue = new Queue<SimulationCase>();
        static private SimulationSystem CurrentSystem;
        static private Mutex m = new Mutex();
        static private void ParallelRunHelper()
        {
            int n = 0;
            while (true)
            {
                SimulationCase c;
                m.WaitOne();
                if (TaskQueue.Count == 0)
                {
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
        static public async Task ParallelRun(SimulationSystem system)
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
            await Task.Run(() =>
            {
                foreach (Thread t in threads)
                {
                    t.Join();
                }
            });
        }
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
