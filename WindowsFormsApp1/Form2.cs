using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private bool ismodified = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void rtbkod_TextChanged(object sender, EventArgs e)
        {
            ismodified = true;
            lblcount.Text = "Simvol sayı: " + rtbkod.Text.Length;
        }

        private bool SaveChanges()
        {
            if (ismodified)
            {
                DialogResult result = MessageBox.Show("Dəyişiklikləri saxlamaq istəyirsiniz?",
                    "Təsdiqləmə", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ismodified = false;
                    return true;
                }
                else if (result == DialogResult.No)
                {
                    ismodified = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveChanges())
            {
                rtbkod.Clear();
                ismodified = false;
            }
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveChanges())
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rtbkod.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
                    ismodified = false;
                }
            }
        }

        private void saxlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, rtbkod.Text);
                ismodified = false;
            }
        }

        private void cixisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveChanges())
            {
                Application.Exit();
            }
        }

        private void sriftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = rtbkod.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rtbkod.Font = fontDialog.Font;
            }
        }

        private void rengToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = rtbkod.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtbkod.ForeColor = colorDialog.Color;
            }
        }
    }
}

