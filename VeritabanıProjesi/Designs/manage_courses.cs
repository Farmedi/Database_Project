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
    public partial class manage_courses : Form
    {
        public manage_courses()
        {
            InitializeComponent();
        }

        private void manage_courses_Load(object sender, EventArgs e)
        {
            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select fakulte,bolum,ders_adi,ders_tarihi from tbl_dersler where ogretmen_adi='"+Global.name+" "+Global.surname+"'", con);
            

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            my_courses.DataSource = dt;
            

        }

        private void back_to_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
