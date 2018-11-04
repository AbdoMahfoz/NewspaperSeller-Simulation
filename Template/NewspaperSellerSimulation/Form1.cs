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

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();




            var system = TestingManager.GetReferenceSystem(Constants.FileNames.TestCase1);


            var result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(result);
        }
    }
}
