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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Ad daxil edin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = txtname.Text;
            string yas = nmryas.Value.ToString();
            string kurs = cmbkurs.Text;
            string cins = rq.Checked ? "Qadin" : "Kisi";
            lblist.Items.Add(name + " " + yas + " " + kurs + " " + cins);
        }
        private void btnsil_click(object sender, EventArgs e)
        {
            if (lblist.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Silmək istədiyinizə əminsiniz?"
                    , "Təsdiqləmə", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) 
                    lblist.Items.Remove(lblist.SelectedItem);
                else
                    MessageBox.Show("Silmək üçün bir element seçin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblist.SelectedItem != null)
            {
                lblelave.Text = "Seçilən tələbə: " + lblist.SelectedItem.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
