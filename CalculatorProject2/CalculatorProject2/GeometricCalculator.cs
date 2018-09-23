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
    public partial class GeometricCalculator : Form
    {
        public GeometricCalculator()
        {
            InitializeComponent();
        }

        private void GeometricCalculator_Load(object sender, EventArgs e)
        {

        }

        private void txtAreaTrapezoid_Click(object sender, EventArgs e)
        {

        }

        private void txtPerimeterRectangle_Click(object sender, EventArgs e)
        {
            Perimeter_of_Rectangle f1 = new Perimeter_of_Rectangle();
            f1.Show();
            Visible = false;
        }

        private void txtPerimeterTriangle_Click(object sender, EventArgs e)
        {
            Perimeter_of_triangle f2 = new Perimeter_of_triangle();
            f2.Show();
            Visible = false;
        }
    }
}
