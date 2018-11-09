using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerTesting;
using NewspaperSellerModels;
using System.IO;
using System.Diagnostics;

namespace NewspaperSellerSimulation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SimulationSystem system = TestCaseManager.FromFile(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()) + "\\TestCases\\TestCase3.txt");
            SimulationSystem system2 = (SimulationSystem)system.Clone();
            long ParallelTime, SequentialTime;
            Stopwatch watch = new Stopwatch();
            watch.Restart();
            Igniter.ParallelRun(system2);
            watch.Stop();
            ParallelTime = watch.ElapsedMilliseconds;
            watch.Restart();
            Igniter.SequntialRun(system);
            watch.Stop();
            SequentialTime = watch.ElapsedMilliseconds;
            MessageBox.Show(TestingManager.Test(system, "TestCase3.txt") + "\nParallel time = " + ParallelTime + ", Sequntial time = " + SequentialTime);
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */
        }
    }
}
