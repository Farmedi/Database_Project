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
            SqlCommand cmd = new SqlCommand("list_courses_given", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

        }

        private void back_to_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
