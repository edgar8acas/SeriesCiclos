using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesCiclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            txtRes.Text = Series.Seno(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtRep.Text)).ToString();
        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {
            txtRes.Text = Series.Coseno(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtRep.Text)).ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            txtRes.Text = Series.Ln(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtRep.Text)).ToString();
        }
    }
}
