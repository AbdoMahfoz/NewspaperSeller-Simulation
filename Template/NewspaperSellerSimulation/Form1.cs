using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerTesting;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        SimulationSystem system = new SimulationSystem();
        List<DayTypeDistribution> dt = new List<DayTypeDistribution>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PoorProbabilty_ValueChanged(object sender, EventArgs e)
        {
            DayTypeDistribution dayType = new DayTypeDistribution
            {
                Probability = decimal.Parse(PoorProbabilty.Value.ToString()),
                DayType = Enums.DayType.Poor 
            };

        }

        private void FairProbability_ValueChanged(object sender, EventArgs e)
        {
            DayTypeDistribution dayType = new DayTypeDistribution();

        }

        private void GoodProbability_ValueChanged(object sender, EventArgs e)
        {
            DayTypeDistribution dayType = new DayTypeDistribution();
        }

        private void NumOfNewsPapers_ValueChanged(object sender, EventArgs e)
        {
            system.NumOfNewspapers =int.Parse(NumOfNewsPapers.Value.ToString());
        }

        private void NumofRecords_ValueChanged(object sender, EventArgs e)
        {
            system.NumOfRecords = int.Parse(NumofRecords.Value.ToString());
        }

        private void PurchasePrice_ValueChanged(object sender, EventArgs e)
        {
            system.PurchasePrice = decimal.Parse(PurchasePrice.Value.ToString());
        }

        private void ScrapPrice_ValueChanged(object sender, EventArgs e)
        {
            system.ScrapPrice = decimal.Parse(ScrapPrice.Value.ToString());
        }

        private void SellingPrice_ValueChanged(object sender, EventArgs e)
        {
            system.SellingPrice = decimal.Parse(SellingPrice.Value.ToString());
        }
    }
}
