using System;
using System.Collections.Generic;
using System.Text;

namespace VeritabanıProjesi
{
    class duyurular
    {   
        public string yapan = "";
        public string duyuru = "";
        public string tarih = "";
        public  duyurular( string tarih,string yapan, string duyuru) { 
            this.yapan = yapan;
            this.duyuru = duyuru;
            this.tarih = tarih; }
        
    }
}
