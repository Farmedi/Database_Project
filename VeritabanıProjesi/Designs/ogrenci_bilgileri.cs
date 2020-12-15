using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VeritabanıProjesi
{
    public partial class ogrenci_bilgileri : Form
    {
        public ogrenci_bilgileri()
        {
            InitializeComponent();
        }

        private void ogrenci_bilgileri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            change_password cpw = new change_password();
            cpw.ShowDialog();
        }
    }
}
