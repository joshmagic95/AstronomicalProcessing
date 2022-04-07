using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomicalProcessing
{
    public partial class frmAstronomicalProcessing : Form
    {
        static int arrayLength = 24;
        int[] neutrinoData = new int[arrayLength];
        public frmAstronomicalProcessing() {
            InitializeComponent();
            FillArray();
            RefreshArray();
        }
        
        // Fill the array with random values, to simulate the data
        public void FillArray() {
            Random rand = new Random();
            for (int i = 0; i < arrayLength; i++) {
                neutrinoData[i] = rand.Next(10, 99);
            }
        }

        // Clear the list box and reprint the array
        public void RefreshArray() {
            lstArray.Items.Clear();
            for (int i = 0; i < arrayLength; i++) {
                lstArray.Items.Add(neutrinoData[i]);
            }
        }
    }
}