using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace VeritabanıProjesi
{
    class DataAccess
    {
        String str = "server = LAPTOP-1P0U4F0G; database=veritabanı_projesi;User Id=ftft;password=Hhft.1811asd159159159";

        public DataTable Basic_no_parameter(string query) {

            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter asd = new SqlDataAdapter(query,con);
            asd.Fill(dt);
            con.Close();
            return dt;

        }
        

    }
}
