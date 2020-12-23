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
    public partial class not_verme_formu : Form
    {
        public not_verme_formu()
        {
            InitializeComponent();
        }
        private void fill_dgw()
        {

            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select fakulte,bolum,ders_adi as Class_Name,ders_tarihi as date, id as ID from tbl_dersler where ogretmen_adi='" + Global.name + " " + Global.surname + "'", con);


            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            dgw_dersler.DataSource = dt;



        }
        private void not_verme_formu_Load(object sender, EventArgs e)
        {
            fill_dgw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dgw_dersler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
