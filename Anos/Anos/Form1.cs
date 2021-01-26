using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lstBis.Items.Clear();
            int ano, cont;
            ano = Convert.ToInt32(txtAno.Text);
            cont = 0;
            while(cont<4)
            {
                if(ano%4==0)
                {
                    lstBis.Items.Add(ano);
                    ano++;
                    cont++;
                }
                else
                {
                    ano++;
                }
            }
        }
    }
}
