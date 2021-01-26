using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void BtnSom_Click(object sender, EventArgs e)
        {
            int v1, v2, re;
            v1 = Convert.ToInt32(txtV1.Text);
            v2 = Convert.ToInt32(txtV2.Text);
            re = v1 + v2;
            txtRe.Text = re.ToString();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            int v1, v2, re;
            v1 = Convert.ToInt32(txtV1.Text);
            v2 = Convert.ToInt32(txtV2.Text);
            re = v1 - v2;
            txtRe.Text = re.ToString();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            int v1, v2, re;
            v1 = Convert.ToInt32(txtV1.Text);
            v2 = Convert.ToInt32(txtV2.Text);
            re = v1 * v2;
            txtRe.Text = re.ToString();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            int v1, v2, re;
            v1 = Convert.ToInt32(txtV1.Text);
            v2 = Convert.ToInt32(txtV2.Text);
            re = v1 / v2;
            txtRe.Text = re.ToString();
        }
    }
}
