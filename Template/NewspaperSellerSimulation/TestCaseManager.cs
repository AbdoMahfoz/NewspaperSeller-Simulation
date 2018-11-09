using System;
using System.IO;
using System.Text;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    /// <summary>
    /// Handles reading and writing from test case files
    /// </summary>
    static class TestCaseManager
    {
        /// <summary>
        /// Extracts simulation system out of a file
        /// </summary>
        /// <param name="path">path to simulation system file</param>
        static public SimulationSystem FromFile(string path)
        {   
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            SimulationSystem system = new SimulationSystem();
            while(reader.Peek() != -1)
            {
                string header = reader.ReadLine().Trim();
                switch(header)
                {
                    case "NumOfNewspapers":
                        system.NumOfNewspapers = int.Parse(reader.ReadLine());
                        break;
                    case "NumOfRecords":
                        system.NumOfRecords = int.Parse(reader.ReadLine());
                        break;
                    case "PurchasePrice":
                        system.PurchasePrice = decimal.Parse(reader.ReadLine());
                        break;
                    case "ScrapPrice":
                        system.ScrapPrice = decimal.Parse(reader.ReadLine());
                        break;
                    case "SellingPrice":
                        system.SellingPrice = decimal.Parse(reader.ReadLine());
                        break;
                    case "DayTypeDistributions":
                        {
                            string line = reader.ReadLine().Trim();
                            decimal[] arr = Array.ConvertAll(line.Split(','), decimal.Parse);
                            int i = 0;
                            foreach (decimal d in arr)
                            {
                                system.DayTypeDistributions.Add(new DayTypeDistribution()
                                {
                                    Probability = d,
                                    DayType = (Enums.DayType)i++
                                });
                            }
                        }
                        break;
                    case "DemandDistributions":
                        {
                            string line;
                            while (!string.IsNullOrWhiteSpace(line = reader.ReadLine()))
                            {
                                decimal[] arr = Array.ConvertAll(line.Split(','), decimal.Parse);
                                DemandDistribution demand = new DemandDistribution()
                                {
                                    Demand = decimal.ToInt32(arr[0])
                                };
                                int i = 0;
                                for (int j = 1; j < arr.Length; j++)
                                {
                                    demand.DayTypeDistributions.Add(new DayTypeDistribution()
                                    {
                                        Probability = arr[j],
                                        DayType = (Enums.DayType)i++
                                    });
                                }
                                system.DemandDistributions.Add(demand);
                            }
                        }
                        break;
                    default:
                        if(!string.IsNullOrWhiteSpace(header))
                        {
                            throw new FormatException("Test case file contains an unknown header: " + header);
                        }
                        break;
                }
            }
            reader.Close();
            return system;
        }
        /// <summary>
        /// Writes the simulation system to a string
        /// </summary>
        /// <param name="system">The simulation system to be written</param>
        static public string ToString(SimulationSystem system)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("NumOfNewspapers\n" + system.NumOfNewspapers.ToString()
                             + "\n\nNumOfRecords\n" + system.NumOfRecords.ToString()
                             + "\n\nPurchasePrice\n" + system.PurchasePrice.ToString()
                             + "\n\nScrapPrice\n" + system.ScrapPrice.ToString()
                             + "\n\nSellingPrice\n" + system.SellingPrice.ToString()
                             + "\n\nDayTypeDistributions");
            for(int i = 0; i < system.DayTypeDistributions.Count; i++)
            {
                builder.Append(system.DayTypeDistributions[i].Probability.ToString());
                if(i != system.DayTypeDistributions.Count - 1)
                {
                    builder.Append(", ");
                }
            }
            builder.AppendLine("\n\nDemandDistributions");
            for(int i = 0; i < system.DemandDistributions.Count; i++)
            {
                builder.Append(system.DemandDistributions[i].Demand.ToString() + ", ");
                for(int j = 0; j < system.DemandDistributions[i].DayTypeDistributions.Count; j++)
                {
                    builder.Append(system.DemandDistributions[i].DayTypeDistributions[j].Probability.ToString());
                    if(j != system.DemandDistributions[i].DayTypeDistributions.Count - 1)
                    {
                        builder.Append(", ");
                    }
                }
                builder.AppendLine();
            }
            return builder.ToString().Trim();
        }
        /// <summary>
        /// Writes a simulation system to a file. if the file exists it will be overwritten, otherwise it will be created
        /// </summary>
        /// <param name="system">The simulation system to be written</param>
        /// <param name="path">path to file</param>
        static public void ToFile(SimulationSystem system, string path)
        {
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.Write(ToString(system));
            writer.Close();
        }
    }
}