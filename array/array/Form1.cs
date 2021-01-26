using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int[] x = {5, 8, 9, 12, 200, 615, 78, 81};
            int vetor=0;
            while (vetor <= 7)
            {
                lstVetores.Items.Add("Posição " + (vetor+1) + " = " + x[vetor]);
                vetor++;
            }
        }
    }
}
