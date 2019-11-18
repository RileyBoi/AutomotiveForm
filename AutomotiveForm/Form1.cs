using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotiveForm
{
    public partial class Form1 : Form
    {
        // Declare constant variables that do not change
        const decimal OIL_CHANGE = 26.00m;
        const decimal LUBE_JOB = 18.00m;
        const decimal RADIATOR_FLUSH = 30.00m;
        const decimal TRANSMISSION_FLUSH = 80.00m;
        const decimal INSPECTION = 15.00m;
        const decimal REPLACE_MUFFLER = 100.00m;
        const decimal TIRE_ROTATION = 20.00m;
        const decimal TAX = 0.08m;
        private decimal total = 0m;
        decimal serviceslabor;
        decimal parts;
        decimal finaltax;
        decimal fees;
        int laborCheck;
        int partsCheck;

        public Form1()
        {
            InitializeComponent();
        }

        private void oilchangeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            total += OIL_CHANGE;
        }

        private void lubejobCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            total += LUBE_JOB;
        }

        private void radiatorflushCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            total += RADIATOR_FLUSH;
        }

        private void transmissionflushCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            total += TRANSMISSION_FLUSH;
        }

        private void inspectionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            total += INSPECTION;
        }

        private void replacemufferCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            total += REPLACE_MUFFLER;
        }

        private void tirerotationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            total += TIRE_ROTATION;
        }

        private void totalButton_Click(object sender, EventArgs e)
        //Use if statement to prevent unhandled exception if textboxes are improperly filled
        {
            if (!int.TryParse(partsTextbox.Text, out partsCheck))
            {
                MessageBox.Show("Please enter a number for parts cost.");
                return;
            }
            else if (!int.TryParse(laborTextbox.Text, out laborCheck))
            {
                MessageBox.Show("Please enter a number for labor cost.");
                return;
            }
            else
            {
                serviceslabor = decimal.Parse(partsTextbox.Text) + total;
                parts = decimal.Parse(laborTextbox.Text);
                finaltax = TAX * parts;
                fees = total + parts + finaltax + serviceslabor;
                serviceslaborOutputlabel.Text = serviceslabor.ToString("n2");
                partsoutputLabel.Text = parts.ToString("n2");
                taxOutputlabel.Text = finaltax.ToString("n2");
                totalfeesoutputLabel.Text = fees.ToString("n2");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            total = 0m;
            serviceslaborOutputlabel.Text = String.Empty;
            partsoutputLabel.Text = String.Empty;
            taxOutputlabel.Text = String.Empty;
            totalfeesoutputLabel.Text = String.Empty;
            oilchangeCheckbox.Checked = false;
            lubejobCheckbox.Checked = false;
            radiatorflushCheckbox.Checked = false;
            transmissionflushCheckbox.Checked = false;
            inspectionCheckbox.Checked = false;
            replacemufferCheckbox.Checked = false;
            tirerotationCheckbox.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
