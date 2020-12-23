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
            fill_dgw();
        }

        private void back_to_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void my_courses_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fill_dgw() {

            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select fakulte,bolum,ders_adi as Class_Name,ders_tarihi as date, id as ID from tbl_dersler where ogretmen_adi='" + Global.name + " " + Global.surname + "'", con);


            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            my_courses.DataSource = dt;



        }

        private void my_courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete_course", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value =Convert.ToInt32( my_courses.Rows[e.RowIndex].Cells[5].Value);

            

            
            cmd.ExecuteNonQuery();
            con.Close();
            fill_dgw();
        }
    }
}
