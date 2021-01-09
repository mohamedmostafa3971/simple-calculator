using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalcu
{
    public partial class simpcalc : Form
    {
        public simpcalc()
        {
            InitializeComponent();
        }

        private void btnmodules_Click(object sender, EventArgs e)
        {
            float x, y, z;
            x = float.Parse(txtX.Text);
            y = float.Parse(txtY.Text);
            z = x % y;
            lblresult.Text = z.ToString();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            float x, y, z;
            x = float.Parse(txtX.Text);
            y = float.Parse(txtY.Text);
            z = x + y;
            lblresult.Text = z.ToString();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            float x, y, z;
            x = float.Parse(txtX.Text);
            y = float.Parse(txtY.Text);
            z = x - y;
            lblresult.Text = z.ToString();
        }

        private void btntimes_Click(object sender, EventArgs e)
        {
            float x, y, z;
            x = float.Parse(txtX.Text);
            y = float.Parse(txtY.Text);
            z = x * y;
            lblresult.Text = z.ToString();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            float x, y, z;
            x = float.Parse(txtX.Text);
            y = float.Parse(txtY.Text);
            z = x / y;
            lblresult.Text = z.ToString();
        }
    }
}
