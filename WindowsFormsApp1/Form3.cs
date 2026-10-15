using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private bool ReqemleriYoxla(out int a, out int b)
        {
            bool aUygun = int.TryParse(txtA.Text, out a);
            bool bUygun = int.TryParse(txtB.Text, out b);
            if (!aUygun || !bUygun)
            {
                lblnetice.Text = "Xəta: Zəhmət olmasa düzgün ədədlər daxil edin.";
            }

            return aUygun && bUygun;
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            if (ReqemleriYoxla(out int a, out int b))
            {
                int netice = a + b;
                lblnetice.Text = $"Nəticə: {netice}";
            }
        }

        private void btncix_Click(object sender, EventArgs e)
        {
            if (ReqemleriYoxla(out int a, out int b))
            {
                int netice = a - b;
                lblnetice.Text = $"Nəticə: {netice}";
            }
        }

        private void btnvur_Click(object sender, EventArgs e)
        {
            if (ReqemleriYoxla(out int a, out int b))
            {
                int netice = a * b;
                lblnetice.Text = $"Nəticə: {netice}";
            }
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            if (ReqemleriYoxla(out int a, out int b))
            {
                if (b == 0)
                {
                    lblnetice.Text = "Xəta: Sıfıra bölmə mümkün deyil.";
                }
                else
                {
                    double netice = (double)a / b;
                    lblnetice.Text = $"Nəticə: {netice}";
                }
            }
        }
    }
}
