using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        }

        private void go_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
