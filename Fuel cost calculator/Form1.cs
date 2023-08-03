using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_cost_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtkilometer.Text);
            int b = int.Parse(txtliter.Text);
            int sumall = a / b;
            txtresult.Text = sumall.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.txtkilometer.Text = "";
            this.txtliter.Text = "";
            this.txtresult.Text = "";
        }
    }
}
