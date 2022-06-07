using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace VP_odev
{
    
    public partial class Kayit : Form
    {
        
        public Kayit()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Giris giris = (Giris)this.Owner;
            if (textBoxSifre.Text != textBoxSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }
            if (this.textBoxAd.Text != "" && textBoxAd.Text != "" && textBoxSoyad.Text != ""
                && textBoxKullaniciAdi.Text != "" && textBoxEposta.Text != "" && textBoxSifre.Text != "" 
                && textBoxSifreTekrar.Text != "" && checkBoxSozlesme.Checked)
            {
                giris.ad = this.textBoxAd.Text;
                giris.soyad = this.textBoxSoyad.Text;
                giris.kullaniciAdi = this.textBoxKullaniciAdi.Text;
                giris.eposta = this.textBoxEposta.Text;
                giris.sifre = this.textBoxSifre.Text;
                giris.sifreTekrar = this.textBoxSifreTekrar.Text;
                MessageBox.Show("Kayıt Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakıldı");
            }
            
            
            
        }
    }
}
