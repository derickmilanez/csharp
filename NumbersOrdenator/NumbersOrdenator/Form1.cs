using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersOrdenator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            n1 = Convert.ToInt32(txtNum1.Text);
            n2 = Convert.ToInt32(txtNum2.Text);
            n3 = Convert.ToInt32(txtNum3.Text);
            if (n1 <= n2 && n1 <= n3 && n2 <= n3)
            {
                lstNums.Items.Add(n1);
                lstNums.Items.Add(n2);
                lstNums.Items.Add(n3);
            }
            if (n1 <= n2 && n1 <= n3 && n3 <= 2)
            {
                lstNums.Items.Add(n1);
                lstNums.Items.Add(n3);
                lstNums.Items.Add(n2);
            }
            if (n2 <= n1 && n2 <= n3 && n3 <= n1)
            {
                lstNums.Items.Add(n2);
                lstNums.Items.Add(n1);
                lstNums.Items.Add(n3);
            }
            if (n2 <= n1 && n2 <= n3 && n3 <= n1)
            {
                lstNums.Items.Add(n2);
                lstNums.Items.Add(n3);
                lstNums.Items.Add(n1);
            }
            if (n3 <= n1 && n3 <= n2 && n1 <= n2)
            {
                lstNums.Items.Add(n3);
                lstNums.Items.Add(n1);
                lstNums.Items.Add(n2);
            }
            if (n3 <= n1 && n3 <= n2 && n2 <= n1)
            {
                lstNums.Items.Add(n3);
                lstNums.Items.Add(n2);
                lstNums.Items.Add(n1);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            lstNums.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstNums.Items.RemoveAt(lstNums.SelectedIndex);
        }
    }
}
