using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalc_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            int numero, multi;
            numero = Convert.ToInt32(txtNum.Text);
            multi = 0;
            while (multi<=10)
            {
                int resultado;
                resultado = numero * multi;
                lstTabuada.Items.Add( numero + " X " + multi + " = " + resultado);
                multi++;
            }
            
        }
    }
}
