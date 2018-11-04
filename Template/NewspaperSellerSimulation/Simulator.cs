using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    /// <summary>
    /// The core of the project
    /// </summary>
    static class Simulator
    {
        /// <summary>
        /// Calculates the distribution for a given day type distribution
        /// </summary>
        /// <param name="Distribution">Day type distribution</param>
        /// <param name="RandomNumber">A random number between 0 and 99</param>
        /// <returns>The desired value that corrisponds to the given random number</returns>
        static private int CalculateDistribution(List<DayTypeDistribution> Distribution, int RandomNumber)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Calculates the distribution for a given demand distribution
        /// </summary>
        /// <param name="Distribution">Demand distribution</param>
        /// <param name="RandomNumber">A random number between 0 and 99</param>
        /// <returns>The desired value that corrisponds to the given random number</returns>
        static private int CalculateDistribution(List<DemandDistribution> Distribution, int RandomNumber)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Calculates the values of a single simulation case
        /// </summary>
        /// <param name="Case">The case that needs to be filled</param>
        /// <param name="system">The entire simulation system</param>
        static private void SimulationMain(SimulationCase Case, SimulationSystem system)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Runs all simulation cases asynchronously
        /// </summary>
        /// <param name="system">The entire simulation system to be simulated</param>
        /// <returns></returns>
        static public async Task StartSimulation(SimulationSystem system)
        {
            Task[] tasks = new Task[system.SimulationTable.Count];
            for(int i = 0; i < system.SimulationTable.Count; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    SimulationMain(system.SimulationTable[i], system);
                });
            }
            await Task.WhenAll(tasks);
        }
    }
}
