using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace VeritabanıProjesi
{
    public partial class ders_programi : Form
    {
        public ders_programi()
        {
            InitializeComponent();
        }

        private void back_to_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ders_programi_Load(object sender, EventArgs e)
        {
            List<int> dersidleri = new List<int>();
            rtb_dersler.Text = "";
            

            String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from secili_dersler(@ogrenci_id)", con);
            cmd.Parameters.AddWithValue("@ogrenci_id", Global.ID);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();

            List<Classlar> my_classes = new List<Classlar>();

            foreach (DataRow row in dt.Rows)
            {
                dersidleri.Add(Convert.ToInt32(row[0]));                    //ders id lerini listeme altım
            }
            dersidleri = dersidleri.Distinct().ToList();



            foreach (int id in dersidleri)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("ders_programi_goster", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("@ders_idd", SqlDbType.Int).Value = id;

                SqlDataReader dr = cmd1.ExecuteReader();

                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        my_classes.Add(new Classlar(dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString()));
                       
                    }
                
                }

                con.Close();

            }
            foreach (Classlar cls in my_classes)
            {
                rtb_dersler.Text += "\nClass Name: " +cls.ders_adi + "\n";
                rtb_dersler.Text += "Lecturer: " + cls.lecturer + "\n";
                rtb_dersler.Text += "Day of the class: " + cls.ders_gunu + "\n";
                rtb_dersler.Text += "*****************************************";

                
            }



            

        }
    }
}
