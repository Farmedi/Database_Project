using System;
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
            lbl_login_error.Text = "";
            string email = tb_email.Text.Trim();
            string password = tb_pw.Text.Trim();

            SqlDataReader dr;
            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            string query = "select * from tbl_ogrenci where email='"+email+"' AND pw='"+password+"'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
           
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                lbl_login_error.Text = "Please check your credentials.";
                con.Close();
            }
            else
            {
                con.Close();
                ogrenci_home ogrenci = new ogrenci_home();
                ogrenci.Show();
                this.Hide();

            }
            
           








           
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register_form reg = new Register_form();
            reg.ShowDialog();
            
            
        }
    }
}
