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
    
    public partial class Giris : Form
    {

        

        public Giris()
        {
            InitializeComponent();
        }

        public string ad;
        public string soyad;
        public string eposta;
        public string sifre;
        public string sifreTekrar;
        public string kullaniciAdi;
        public string cinsiyet;
        public string sehir;
        public string telNo;
        public string dogumTarihi;
        public int kontrol;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit kayit = new Kayit();
            this.Hide();
            kayit.ShowDialog(this);        
            this.Visible = true;  
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxKullaniciAdi.Text == "" && textBoxSifre.Text == "")
            {
                MessageBox.Show("Kullanı Adı veya Şifre Boş Bıraklamaz");
            }
            else if (textBoxKullaniciAdi.Text == this.kullaniciAdi && textBoxSifre.Text == this.sifre)
            {
                Ekran ekran = new Ekran();
                Profil profil = new Profil();
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.labelKullanıci.Text = this.kullaniciAdi;
                this.Hide();
                anasayfa.ShowDialog(this);
                if (kontrol == 1)
                {
                    this.Visible = true;
                    kontrol = 0;
                }
                
                else
                {
                    profil.ShowDialog(this);
                    if (kontrol == 2)
                    {
                        ekran.ShowDialog(this);
                        if (kontrol == 3)
                        {
                            profil.ShowDialog(this);
                            kontrol = 0;
                        }
                        kontrol = 0;
                    }
                    
                }
               
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
           
        }


        

    }
}
