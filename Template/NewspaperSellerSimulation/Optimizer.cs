using System.Threading.Tasks;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    /// <summary>
    /// Attempts to find the best possible daily newspaper count for the given system
    /// </summary>
    static class Optimizer
    {
        private static int minRange = 10;
        /// <summary>
        /// Smallest possible newspaper count to be bought
        /// </summary>
        public static int MinRange
        {
            get
            {
                return minRange;
            }
            set
            {
                if(value % 10 != 0)
                {
                    throw new System.Exception("Minimum and Maximum ranges must be divisble by 10");
                }
                minRange = value;
            }
        }
        private static int maxRange = 10000;
        /// <summary>
        /// Maximum possible newspaper count to be bought
        /// </summary>
        public static int MaxRange
        {
            get
            {
                return maxRange;
            }
            set
            {
                if (value % 10 != 0)
                {
                    throw new System.Exception("Minimum and Maximum ranges must be divisble by 10");
                }
                maxRange = value;
            }
        }
        /// <summary>
        /// Logirthmically searches for the best possible newspaper count
        /// </summary>
        /// <param name="system">The system to find the best newspaper count for</param>
        /// <returns>The best possible newspaper count</returns>
        static public int TernarySearch(SimulationSystem system)
        {
            Igniter.ParallelRun(system);
            SimulationSystem LeftSystem = system.Clone() as SimulationSystem;
            SimulationSystem RightSystem = system.Clone() as SimulationSystem;
            int Start = MinRange / 10, End = MaxRange / 10, Left, Right;
            while(Start <= End)
            {
                Left = Start + (End - Start)/ 3;
                Right = End - (End - Start)/ 3;
                if(Left == Start && Right == End)
                {
                    return ((Left + Right) * 10) / 2;
                }
                LeftSystem.NumOfNewspapers = Left * 10;
                RightSystem.NumOfNewspapers = Right * 10;
                Task[] tasks = new Task[]
                {
                    Task.Run(()=>
                    {
                        Igniter.ParallelReEvaluationRun(LeftSystem);
                    }),
                    Task.Run(()=>
                    {
                        Igniter.ParallelReEvaluationRun(RightSystem);
                    })
                };
                Task.WaitAll(tasks);
                if (LeftSystem.PerformanceMeasures.TotalNetProfit < RightSystem.PerformanceMeasures.TotalNetProfit)
                {
                    Start = Left;
                }
                else
                {
                    End = Right;
                }
            }
            throw new System.Exception("???");
        }
        /// <summary>
        /// Searches linearly for the best newspaper count through the entire range
        /// </summary>
        /// <param name="system">The system to find the best newspaper count for</param>
        /// <returns>The best possible newspaper count in the range</returns>
        static public int LinearSearch(SimulationSystem system)
        {
            Igniter.SequntialRun(system);
            int Ans = 0;
            decimal MaxAns = 0;
            for(int i = MinRange / 10; i <= MaxRange / 10; i++)
            {
                system.NumOfNewspapers = i * 10;
                Igniter.SequntialReEvaluationRun(system);
                if(system.PerformanceMeasures.TotalNetProfit > MaxAns)
                {
                    Ans = i * 10;
                    MaxAns = system.PerformanceMeasures.TotalNetProfit;
                }
            }
            return Ans;
        }
    }
}
