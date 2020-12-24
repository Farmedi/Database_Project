using System;
using System.Collections.Generic;
using System.Text;

namespace VeritabanıProjesi
{
    class Classlar
    {
       public string ders_adi = "";
        public  string ders_gunu = "";
        public  string lecturer = "";
        
        public Classlar(string da, string l, string dg) { this.ders_adi = da;this.ders_gunu = dg;this.lecturer = l; }
    }
}
