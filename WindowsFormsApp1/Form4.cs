using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        class Sual
        {
            public string SualMetni { get; set; }
            public List<string> Cavablar { get; set; }
            public int DogruCavabIndexi { get; set; }

            public Sual(string sualMetni, List<string> cavablar, int dogruCavabIndexi)
            {
                SualMetni = sualMetni;
                Cavablar = cavablar;
                DogruCavabIndexi = dogruCavabIndexi;
            }
        }
        List<Sual> suallar = new List<Sual>
        {
            new Sual("1. Azərbaycanın paytaxtı haradır?", new List<string> { "Bakı", "Gəncə", "Sumqayıt", "Şəki" }, 0),
            new Sual("2. Azərbaycanın rəsmi dili hansıdır?", new List<string> { "Rus", "İngilis", "Azərbaycan", "Fransız" }, 2),
            new Sual("3. Azərbaycanın milli valyutası hansıdır?", new List<string> { "Dollar", "Manat", "Euro", "Rubl" }, 1),
            new Sual("4. C# dilində tam ədəd tipi hansıdır?", new List<string> { "string", "double", "int", "bool" }, 2),
            new Sual("5. Dünyanın ən böyük okeanı hansıdır?", new List<string> { "Sakit okean", "Atlantik okean", "Hind okeanı", "Şimal Buzlu okean" }, 0)
        };

        int cariSualIndex = 0;
        int bal = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TestiBaslat();
        }
        private void TestiBaslat()
        {
            cariSualIndex = 0;
            bal = 0;
            prgbar.Minimum = 0;
            prgbar.Maximum = suallar.Count;
            prgbar.Value = 0;

            SualGoster();
        }
        private void SualGoster()
        {
            lblsual.Text = suallar[cariSualIndex].SualMetni;

            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;

            prgbar.Value = cariSualIndex;

            var cavablar = suallar[cariSualIndex].Cavablar;
            rdbA.Text = "A) " + cavablar[0];
            rdbB.Text = "B) " + cavablar[1];
            rdbC.Text = "C) " + cavablar[2];
            rdbD.Text = "D) " + cavablar[3];
        }

        private void btnkec_Click(object sender, EventArgs e)
        {
            int secilenCavabIndex = -1;
            if (rdbA.Checked) secilenCavabIndex = 0;
            else if (rdbB.Checked) secilenCavabIndex = 1;
            else if (rdbC.Checked) secilenCavabIndex = 2;
            else if (rdbD.Checked) secilenCavabIndex = 3;
            if (secilenCavabIndex == -1)
            {
                MessageBox.Show("Zəhmət olmasa bir cavab seçin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (secilenCavabIndex == suallar[cariSualIndex].DogruCavabIndexi)
            {
                bal+=20;
            }
            cariSualIndex++;
            if (cariSualIndex < suallar.Count)
            {
                SualGoster();
            }
            else
            {
                prgbar.Value = suallar.Count;
                DialogResult cavab = MessageBox.Show(
                    $"Test bitdi!\nTopladığınız bal: {bal} / 100\n\nYenidən başlamaq istəyirsiniz?",
                    "Nəticə",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (cavab == DialogResult.Yes)
                {
                    TestiBaslat();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}