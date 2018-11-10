using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerTesting;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private async void StartSimulationButton_Click(object sender, EventArgs e)
        {
            List<DemandDistribution> demandDistributions = new List<DemandDistribution>();
            for(int i = 0; i < DemandDistributionGrid.Rows.Count - 1; i++)
            {
                DataGridViewRow row = DemandDistributionGrid.Rows[i];
                DemandDistribution demandDistribution = new DemandDistribution()
                {
                    Demand = int.Parse((string)row.Cells[0].Value)
                };
                for (int j = 1; j < 4; j++)
                {
                    demandDistribution.DayTypeDistributions.Add(new DayTypeDistribution()
                    {
                        Probability = decimal.Parse((string)row.Cells[j].Value),
                        DayType = (Enums.DayType)(j - 1)
                    });
                }
                demandDistributions.Add(demandDistribution);
            }
            SimulationSystem system = new SimulationSystem()
            {
                NumOfNewspapers = (int)NumOfNewsPapers.Value,
                NumOfRecords = (int)NumofRecords.Value,
                PurchasePrice = PurchasePrice.Value,
                ScrapPrice = ScrapPrice.Value,
                SellingPrice = SellingPrice.Value,
                DemandDistributions = demandDistributions,
                DayTypeDistributions = new List<DayTypeDistribution>()
                {
                    new DayTypeDistribution()
                    {
                        Probability = GoodProbability.Value,
                        DayType = Enums.DayType.Good
                    },
                    new DayTypeDistribution()
                    {
                        Probability = FairProbability.Value,
                        DayType = Enums.DayType.Fair
                    },
                    new DayTypeDistribution()
                    {
                        Probability = PoorProbabilty.Value,
                        DayType = Enums.DayType.Poor
                    }
                }
            };
            foreach(Control c in Controls)
            {
                c.Enabled = false;
            }
            DialogResult result;
            do
            {
                await Task.Run(() => Igniter.ParallelRun(system));
                result = MessageBox.Show("Succesfully ran the following system:\n" + TestCaseManager.ToString(system) + "\nRun Again?", "Results", MessageBoxButtons.YesNoCancel);
            } while (result == DialogResult.Yes);
            if (result == DialogResult.No)
            {
                foreach (Control c in Controls)
                {
                    c.Enabled = true;
                    if (typeof(NumericUpDown) == c.GetType())
                    {
                        ((NumericUpDown)c).Value = 0;
                    }
                    if (typeof(DataGridView) == c.GetType())
                    {
                        ((DataGridView)c).Rows.Clear();
                    }
                }
            }
        }
    }
}
