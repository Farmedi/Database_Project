using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;


namespace VeritabanıProjesi
{
    public partial class ders_secimi : Form
    {
        public ders_secimi()
        {
            InitializeComponent();
        }

        private void ders_secimi_Load(object sender, EventArgs e)
        {
            clm_add_class.Visible = false;
            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            string query = "Select fakulte from tbl_dersler";
            List<string> fakulte_adlari = new List<string>();
            List<string> bolum_adlari = new List<string>();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fakulte_adlari.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();

            fakulte_adlari = fakulte_adlari.Distinct().ToList();

            for (int index = 0; index < fakulte_adlari.Count(); index++)
            {
                cmb_faculty.Items.Add(fakulte_adlari.ElementAt(index));
            }





        }

        private void go_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ders_secim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {

            clm_add_class.Visible = false;

        }
        List<string> bolum_adlari = new List<string>();
        private void faculty_confirm_Click(object sender, EventArgs e)
        {
            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);

            string query = "select bolum from tbl_dersler where fakulte='" + cmb_faculty.SelectedItem.ToString() + "'";

            con.Open();
            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            cmb_department.Items.Clear();
            bolum_adlari.Clear();


            while (dr1.Read())
            {
                bolum_adlari.Add(dr1[0].ToString());
            }
            dr1.Close();
            con.Close();


            bolum_adlari = bolum_adlari.Distinct().ToList();

            for (int i = 0; i < bolum_adlari.Count(); i++)
            {
                cmb_department.Items.Add(bolum_adlari.ElementAt(i));

            }




        }

        private void confirm_department_Click(object sender, EventArgs e)
        {
            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            string ders_getir = "select ders_adi as Class, ogretmen_adi as Lecturer, ders_tarihi as Day,id as ID from tbl_dersler" +
                " where fakulte='" + cmb_faculty.SelectedItem.ToString() + "' and bolum='" + cmb_department.SelectedItem.ToString() + "'  ";
            SqlCommand cmd = new SqlCommand(ders_getir, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();

            ders_secim.DataSource = dt;
            clm_add_class.Visible = true;
            clm_add_class.DisplayIndex = 4;
            clm_add_class.Text = "Join!";

        }

        private void ders_secim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int ders_id =Convert.ToInt32( ders_secim.Rows[e.RowIndex].Cells[4].Value);

            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);

            SqlConnection conv = new SqlConnection(str);
            
            SqlCommand cmdv = new SqlCommand("select dbo.check_if_assigned('"+Global.ID+"','"+ders_id+"')  ", conv);
            
                conv.Open();
                var validation = cmdv.ExecuteScalar();
                conv.Close();
            

            
            if (Convert.ToInt32(validation) == 1)
            {
                MessageBox.Show("You are already assigned to this class!");

            }
            else if (Convert.ToInt32(validation) == 0)
            {
                SqlCommand cmd = new SqlCommand("ders_programina_ekle", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ogrenci_idd", SqlDbType.Int).Value = Global.ID;
                cmd.Parameters.Add("@ders_idd", SqlDbType.Int).Value = ders_id;


                con.Open();
                cmd.ExecuteNonQuery();

            }
            

            

            

        }

    }
}
