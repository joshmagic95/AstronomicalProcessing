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

        // Search the sorted array
        public void SearchArray() {
        // Declare minimum and maximum array values
            int min = 0;
            int max = arrayLength - 1;
            // Try to parse integer input from txtSearch and output to integer target
            if (!(Int32.TryParse(txtSearch.Text, out int target)))
            {
                // If the integer test fails, display a message box
                MessageBox.Show("You must enter an integer");
                return;
            }
            // While the min is less than or equal to max, enter the while loop
            while (min <= max)
            {
                // Write the mean of min and max to mid
                int mid = (min + max) / 2;

                if (target == neutrinoData[mid])
                {
                    MessageBox.Show(target + " Found at index " + mid);
                    return;
                }
                else if (neutrinoData[mid] >= target)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
        }
    }
}