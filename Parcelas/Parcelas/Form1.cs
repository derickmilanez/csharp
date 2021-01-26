using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcelas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParcelar_Click(object sender, EventArgs e)
        {
            decimal valor, valorp;
            valor = Convert.ToDecimal(txtValor.Text);
            valorp = Convert.ToDecimal(txtValor.Text);
            if (valor <= 100)
            {
                lstParcela.Items.Add("1x de " + valorp);
            }
            else if (valor <= 200)
            {
                valorp = valor / 2;
                lstParcela.Items.Add("2x de " + valorp);
            }
            else if (valor <= 300)
            {
                valorp = valor / 3;
                lstParcela.Items.Add("3x de " + valorp);
            }
            else if (valor <= 400)
            {
                valorp = valor / 4;
                lstParcela.Items.Add("4x de " + valorp);
            }
            else if (valor <= 500)
            {
                valorp = valor / 5;
                lstParcela.Items.Add("5x de " + valorp);
            }
            else
            {
                valorp = valor / 6;
                lstParcela.Items.Add("6x de " + valorp);
            }
        }
    }
}
