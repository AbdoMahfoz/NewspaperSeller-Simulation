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
        static Random rnd = new Random();
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
                if (!Distribution[i].IsCalculated)
                {
                    if (i == 0)
                    {
                        Distribution[i].CummProbability = Distribution[i].Probability;
                        Distribution[i].MinRange = 1;
                    }
                    else
                    {
                        Distribution[i].CummProbability = Distribution[i].Probability + Distribution[i - 1].CummProbability;
                        Distribution[i].MinRange = Distribution[i - 1].MaxRange + 1;
                    }
                    Distribution[i].MaxRange = (int)Distribution[i].CummProbability * 100;
                    Distribution[i].IsCalculated = true;
                }
                if (RandomNumber <= Distribution[i].MaxRange && RandomNumber >= Distribution[i].MinRange)
                {
                    return Distribution[i].DayType;
                }
            }
            if (RandomNumber < 1 || RandomNumber > 100)
                throw new ArgumentOutOfRangeException("RandomValue should be between 1 and 100");
            else
                throw new Exception("Debug meeeeeeeee");
        }
        /// <summary>
        /// Calculates the distribution for a given demand distribution
        /// </summary>
        /// <param name="Distribution">Demand distribution</param>
        /// <param name="RandomNumber">A random number between 0 and 99</param>
        /// <returns>The desired value that corrisponds to the given random number</returns>
        static private int CalculateDistribution(List<DemandDistribution> Distribution, Enums.DayType dayType, int RandomNumber)
        {
            for (int i = 0; i < Distribution.Count; i++)
            {
                for (int j = 0; j < Distribution[i].DayTypeDistributions.Count; j++)
                {
                    if (Distribution[i].DayTypeDistributions[j].DayType != dayType)
                    {
                        continue;
                    }
                    if (!Distribution[i].DayTypeDistributions[j].IsCalculated)
                    {
                        if (i == 0)
                        {
                            Distribution[i].DayTypeDistributions[j].CummProbability = Distribution[i].DayTypeDistributions[j].Probability;
                            Distribution[i].DayTypeDistributions[j].MinRange = 1;
                        }
                        else
                        {
                            Distribution[i].DayTypeDistributions[j].CummProbability =
                                Distribution[i].DayTypeDistributions[j].Probability +
                                Distribution[i - 1].DayTypeDistributions[j].CummProbability;
                            Distribution[i].DayTypeDistributions[j].MinRange = Distribution[i - 1].DayTypeDistributions[j].MaxRange + 1;
                        }
                        Distribution[i].DayTypeDistributions[j].MaxRange = (int)Distribution[i].DayTypeDistributions[j].CummProbability * 100;
                        Distribution[i].DayTypeDistributions[j].IsCalculated = true;
                    }
                    if (RandomNumber <= Distribution[i].DayTypeDistributions[j].MaxRange &&
                        RandomNumber >= Distribution[i].DayTypeDistributions[j].MinRange)
                    {
                        return Distribution[i].Demand;
                    }
                    break;
                }
            }
            if (RandomNumber < 1 || RandomNumber > 100)
                throw new ArgumentOutOfRangeException("RandomValue should be between 1 and 100");
            else
                throw new Exception("Debug meeeeeeeee");
        }
        /// <summary>
        /// Calculates the values of a single simulation case
        /// </summary>
        /// <param name="Case">The case that needs to be filled</param>
        /// <param name="system">The entire simulation system</param>
        static private void SimulationMain(SimulationCase Case, SimulationSystem system)
        {
            Case.RandomNewsDayType = rnd.Next(0, 99);
            Case.NewsDayType = CalculateDistribution(system.DayTypeDistributions, Case.RandomNewsDayType);
            Case.RandomDemand = rnd.Next(0, 99);
            Case.Demand = CalculateDistribution(system.DemandDistributions, Case.NewsDayType, Case.RandomDemand);
            Case.SalesProfit = Case.Demand * system.SellingPrice;
            Case.LostProfit = Math.Max(0, Case.Demand - system.NumOfNewspapers) * system.SellingPrice;
            Case.ScrapProfit = Math.Max(0, system.NumOfNewspapers - Case.Demand) * system.ScrapPrice;
            Case.DailyCost = system.NumOfNewspapers * system.PurchasePrice;
            Case.DailyNetProfit = Case.SalesProfit - Case.DailyCost - Case.LostProfit + Case.ScrapProfit;
            system.PerformanceMeasures.TotalSalesProfit += Case.SalesProfit;
            system.PerformanceMeasures.TotalLostProfit += Case.LostProfit;
            system.PerformanceMeasures.TotalScrapProfit += Case.ScrapProfit;
            system.PerformanceMeasures.TotalCost += Case.DailyCost;
            system.PerformanceMeasures.TotalNetProfit += Case.DailyNetProfit;
        }
        /// <summary>
        /// Runs all simulation cases asynchronously
        /// </summary>
        /// <param name="system">The entire simulation system to be simulated</param>
        /// <returns></returns>
        static public async Task StartSimulation(SimulationSystem system)
        {
            Task[] tasks = new Task[system.SimulationTable.Count];
            for (int i = 0; i < system.SimulationTable.Count; i++)
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
