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
    public partial class Ekran : Form
    {
        List<string> liste;
        public Ekran()
        {
            InitializeComponent();
        }

        private void Ekran_Load(object sender, EventArgs e)
        {
            liste = comboBoxSehir.Items.Cast<string>().ToList();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris giris = (Giris)this.Owner;
            if (radioButton1.Checked)
            {
                giris.cinsiyet = "erkek";
            }
            else
            {
                giris.cinsiyet = "kadın";
            }
            giris.sehir = comboBoxSehir.SelectedItem.ToString();
            giris.telNo = textBox1.Text;
            giris.dogumTarihi = textBox2.Text;
            giris.kontrol = 3;
            this.Close();
        }
    }
}
