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
        /// Calculates a single row in the distribution table
        /// </summary>
        /// <param name="Current">The current row</param>
        /// <param name="Previous">The previous row</param>
        /// <param name="RandomNumber">The random number that selects a row in the distribution</param>
        /// <returns>True if random number falls in range of Current row, false otherwise</returns>
        static private bool CalculateSingleRowDistribution(DayTypeDistribution Current, DayTypeDistribution Previous, int RandomNumber)
        {
            if (!Current.IsCalculated)
            {
                if (Previous == null)
                {
                    Current.CummProbability = Current.Probability;
                    Current.MinRange = 1;
                }
                else
                {
                    Current.CummProbability = Current.Probability + Previous.CummProbability;
                    Current.MinRange = Previous.MaxRange + 1;
                }
                Current.MaxRange = (int)Current.CummProbability * 100;
                Current.IsCalculated = true;
            }
            if(RandomNumber <= Current.MaxRange && RandomNumber >= Current.MinRange)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Calculates the distribution for a given day type distribution
        /// </summary>
        /// <param name="Distribution">Day type distribution</param>
        /// <param name="RandomNumber">A random number between 0 and 99</param>
        /// <returns>The desired value that corrisponds to the given random number</returns>
        static private Enums.DayType CalculateDistribution(List<DayTypeDistribution> Distribution, int RandomNumber)
        {
            for (int i = 0; i < Distribution.Count; i++)
            {
                if(CalculateSingleRowDistribution(Distribution[i], (i == 0) ? null : Distribution[i - 1], RandomNumber))
                {
                    return Distribution[i].DayType;
                }
            }
            throw new Exception("Couldn't determine day type value");
        }
        /// <summary>
        /// Calculates the distribution for a given demand distribution
        /// </summary>
        /// <param name="Distribution">Demand distribution</param>
        /// <param name="RandomNumber">A random number between 0 and 99</param>
        /// <returns>The desired value that corrisponds to the given random number</returns>
        static private int CalculateDistribution(List<DemandDistribution> Distribution, Enums.DayType dayType, int RandomNumber)
        {
            int j = 0;
            while (j < Distribution[0].DayTypeDistributions.Count)
            {
                if (Distribution[0].DayTypeDistributions[j].DayType == dayType)
                {
                    break;
                }
                j++;
            }
            if (j == Distribution[0].DayTypeDistributions.Count)
            {
                throw new ArgumentException("The given day type doesn't exist");
            }
            for (int i = 0; i < Distribution.Count; i++)
            {
                if (CalculateSingleRowDistribution(Distribution[i].DayTypeDistributions[j],
                                                   (i == 0) ? null : Distribution[i - 1].DayTypeDistributions[j],
                                                   RandomNumber))
                {
                    return Distribution[i].Demand;
                }
            }
            throw new Exception("Couldn't determine demand value");
        }
        /// <summary>
        /// Calculates the values of a single simulation case
        /// </summary>
        /// <param name="Case">The case that needs to be filled</param>
        /// <param name="system">The entire simulation system</param>
        static public void SimulationMain(SimulationCase Case, SimulationSystem system)
        {
            throw new NotImplementedException();
        }
    }
}
