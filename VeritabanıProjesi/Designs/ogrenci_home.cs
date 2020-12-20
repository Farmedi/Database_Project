using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            label1.Text = "Name: "+Global.name + " " + Global.surname + "\n ID: " + Global.ID;
            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            string query = "select * from tbl_duyurular where duyuru_id=2 order by tarih asc";
            SqlCommand cmd = new SqlCommand(query, con);

            var announcements = new List<duyurular>();
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    announcements.Add(new duyurular(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                    
                }
            }
            reader.Close();
            con.Close();
            foreach (duyurular dyr in announcements)
            {
                duyurular.Text += "Date: " + dyr.tarih + "\n";
                duyurular.Text += "From: " + dyr.yapan + "\n";
                duyurular.Text += "" + dyr.duyuru + "\n";
                duyurular.Text += "-----------------------------------------------------------------------------\n";
            }
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
