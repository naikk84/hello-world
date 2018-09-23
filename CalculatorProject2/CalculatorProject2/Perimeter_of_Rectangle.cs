using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject2
{
    public partial class Perimeter_of_Rectangle : Form
    {
        public Perimeter_of_Rectangle()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            decimal Side1 = Convert.ToDecimal(txtsidea.Text);
            decimal Side2 = Convert.ToDecimal(txtsideb.Text);

            decimal perimeter;
            perimeter = Side1 + Side1 + Side2 + Side2;
            perimeter = Math.Round(perimeter, 2);
            txtPerimeter.Text = perimeter.ToString();
            string history = "Side1:- " + txtsidea.Text + " " + "Side2:- " + txtsideb.Text + " " + "Perimeter:- " + txtPerimeter.Text + "\n";
            label6.Text = label6.Text + history;

            label6.ForeColor = Color.White;
            label6.BackColor = Color.Transparent;
            txtsidea.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            GeometricCalculator f1 = new GeometricCalculator();
            f1.Show();
            this.Close();
        }
    }
    }

