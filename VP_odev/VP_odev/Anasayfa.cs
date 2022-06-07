using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_odev
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        

        
        private void label1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris giris = (Giris)this.Owner;
            giris.kontrol = 1;
            this.Close();
        }

        public void Anasayfa_Load(object sender, EventArgs e)
        {
            Giris giris = (Giris)this.Owner;


        }
    }
}
