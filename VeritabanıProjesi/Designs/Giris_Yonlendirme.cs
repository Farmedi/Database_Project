﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeritabanıProjesi
{
    public partial class Giris_Yonlendirme : Form
    {
        
        
        public Giris_Yonlendirme()
        {
            InitializeComponent();
        }

       

       

        private void ogretmen_login_Click(object sender, EventArgs e)
        {
            ogretmen_home og = new ogretmen_home();
            og.Show();
            this.Hide();
        }

        private void Ogrenci_login_Click(object sender, EventArgs e)
        {
            ogrenci_home ogrenci = new ogrenci_home();
            ogrenci.Show();
            this.Hide();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register_form reg = new Register_form();
            reg.ShowDialog();
            
            
        }
    }
}
