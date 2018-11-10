using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using System.IO;

namespace NewspaperSellerSimulation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private SimulationSystem LoadSystemFromUI()
        {
            List<DemandDistribution> demandDistributions = new List<DemandDistribution>();
            for (int i = 0; i < DemandDistributionGrid.Rows.Count - 1; i++)
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
            return new SimulationSystem()
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
        }
        private void ClearUI()
        {
            foreach (Control c in Controls)
            {
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
        private void DisableAllControls()
        {
            foreach (Control c in Controls)
            {
                c.Enabled = false;
            }
        }
        private void EnableAllControls()
        {
            foreach (Control c in Controls)
            {
                c.Enabled = true;
            }
        }
        private async void StartSimulationButton_Click(object sender, EventArgs e)
        {
            DisableAllControls();
            SimulationSystem system = LoadSystemFromUI();
            DialogResult result;
            do
            {
                await Task.Run(() => Igniter.ParallelRun(system));
                SimulationTable TableViewer = new SimulationTable(system);
                TableViewer.ShowDialog();
                result = MessageBox.Show("Run Again?", "Results", MessageBoxButtons.YesNoCancel);
            }
            while (result == DialogResult.Yes);
            EnableAllControls();
            if (result == DialogResult.No)
            {
                ClearUI();
            }
        }
        private void LoadFromFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = false,
                InitialDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\TestCases\\",
                Filter = "Text File|*.txt"
            };
            dialog.ShowDialog();
            SimulationSystem system;
            try
            {
                system = TestCaseManager.FromFile(dialog.FileName);
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid File");
                return;
            }
            ClearUI();
            NumOfNewsPapers.Value = system.NumOfNewspapers;
            NumofRecords.Value = system.NumOfRecords;
            PurchasePrice.Value = system.PurchasePrice;
            ScrapPrice.Value = system.ScrapPrice;
            SellingPrice.Value = system.SellingPrice;
            GoodProbability.Value = system.DayTypeDistributions[0].Probability;
            FairProbability.Value = system.DayTypeDistributions[1].Probability;
            PoorProbabilty.Value = system.DayTypeDistributions[2].Probability;
            foreach(DemandDistribution d in system.DemandDistributions)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = d.Demand.ToString()
                });
                foreach(DayTypeDistribution dd in d.DayTypeDistributions)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = dd.Probability.ToString()
                    });
                }
                DemandDistributionGrid.Rows.Add(row);
            }
        }
        private void ExportToFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to write this to a file?\n" + TestCaseManager.ToString(LoadSystemFromUI()), "Export confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.No)
            {
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog
            {
                InitialDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\TestCases\\",
                Filter = "Text File|*.txt"
            };
            dialog.ShowDialog();
            try
            {
                TestCaseManager.ToFile(LoadSystemFromUI(), dialog.FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error exporting to file\nReason: " + ex.Message);
                return;
            }
            MessageBox.Show("Successfully exported to file");
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearUI();
        }
        private async void AutomaticTestingButton_Click(object sender, EventArgs e)
        {
            DisableAllControls();
            string res = "";
            await Task.Run(() => res = TestCaseManager.RunAllTestCases());
            MessageBox.Show(res);
            EnableAllControls();
        }
    }
}
