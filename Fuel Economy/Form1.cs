using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double milesNum;
            try{
                milesNum = double.Parse(miles.Text);
                if (!(milesNum >= 0))
                {
                    MessageBox.Show("Error, your miles is less than 0");
                }
                try
                {
                    double gallonsNum = double.Parse(gallons.Text);
                    if (!(gallonsNum >= 0))
                    {
                        MessageBox.Show("Error, your miles is less than or equal to 0");
                    }
                    try
                    {
                        double MPGNum = milesNum / gallonsNum;
                        MPGOutputLabel.Text = MPGNum.ToString();


                    }
                    catch
                    {
                        MessageBox.Show("Somethins is wrong");
                    }

                }
                catch
                {
                    MessageBox.Show("Your gallons is wrong");
                }

            }
            catch {
                MessageBox.Show("Your miles is wrong");
            }


            
            
            





        }
    }
}
