using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VeritabanıProjesi
{
    public partial class ogrenci_home : Form
    {
        public ogrenci_home()
        {
            InitializeComponent();
        }

        private void ogrenci_home_Load(object sender, EventArgs e)
        {
            
        }

        private void ders_programi_Click(object sender, EventArgs e)
        {
            ders_programi dprogram = new ders_programi();
            dprogram.ShowDialog();
        }

        private void ders_secimi_Click(object sender, EventArgs e)
        {
            ders_secimi dsecimi = new ders_secimi();
            dsecimi.ShowDialog();
        }

        private void ogrenci_bilgileri_Click(object sender, EventArgs e)
        {
            ogrenci_bilgileri obilgi = new ogrenci_bilgileri();
            obilgi.ShowDialog();
        }
    }
}
