using NewspaperSellerModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NewspaperSellerSimulation
{
    public partial class SimulationTable : Form
    {
        SimulationSystem system;
        public SimulationTable(SimulationSystem system)
        {
            this.system = system;
            InitializeComponent();
        }
        private void SimulationTable_Load(object sender, EventArgs e)
        {
            TotalDailyCost.Text = system.PerformanceMeasures.TotalCost.ToString();
            TotalLostProfit.Text = system.PerformanceMeasures.TotalLostProfit.ToString();
            TotalNetProfit.Text = system.PerformanceMeasures.TotalNetProfit.ToString();
            TotalSalesProfit.Text = system.PerformanceMeasures.TotalSalesProfit.ToString();
            TotalScrapProfit.Text = system.PerformanceMeasures.TotalScrapProfit.ToString();
            DaysWithMoreDemand.Text = system.PerformanceMeasures.DaysWithMoreDemand.ToString();
            DaysWithUnsoldPapers.Text = system.PerformanceMeasures.DaysWithUnsoldPapers.ToString();
            CurrentNewsPaper.Text = system.NumOfNewspapers.ToString();
            int offset = 0;
            foreach(SimulationCase c in system.SimulationTable)
            {
                ResultsPanel.Controls.Add(new Label()
                {
                    Location = new Point(733, offset),
                    Size = new Size(50, 30),
                    Text = c.DailyNetProfit.ToString()
                });
                ResultsPanel.Controls.Add(new Label()
                {
                    Location = new Point(655, offset),
                    Text = c.ScrapProfit.ToString()
                });
                ResultsPanel.Controls.Add(new Label()
                {
                    Location = new Point(582, offset),
                    Text = c.LostProfit.ToString()
                });
                ResultsPanel.Controls.Add(new Label()
                {
                    Location = new Point(506, offset),
                    Text = c.SalesProfit.ToString()
                });
                ResultsPanel.Controls.Add(new Label()
                {
                    Location = new Point(428, offset),
                    Text = c.DailyCost.ToString()
                });
                ResultsPanel.Controls.Add(new Label()
                {
                    Location = new Point(363, offset),
                    Text = c.Demand.ToString()
                });
                ResultsPanel.Controls.Add(new Label()
                {
                    Location = new Point(290, offset),
                    Text = c.RandomDemand.ToString()
                });
                ResultsPanel.Controls.Add(new Label()
                {
                    Location = new Point(192, offset),
                    Text = c.NewsDayType.ToString()
                });
                ResultsPanel.Controls.Add(new Label()
                {
                    Location = new Point(115, offset),
                    Text = c.RandomNewsDayType.ToString()
                });
                ResultsPanel.Controls.Add(new Label()
                {
                    Location = new Point(36, offset),
                    Text = c.DayNo.ToString()
                });
                offset += 30;
            }
            BestNewsPapers.Text = Optimizer.TernarySearch(system).ToString();
        }
    }
}
