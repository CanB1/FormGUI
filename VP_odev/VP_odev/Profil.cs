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
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Profil_Load(object sender, EventArgs e)
        {
            Giris giris = (Giris)this.Owner;
            if (giris.kontrol != 3) {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[0].Cells[0].Value = "Kullanıcı Adı";
                dataGridView1.Rows[0].Cells[1].Value = giris.kullaniciAdi;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[1].Cells[0].Value = "Ad";
                dataGridView1.Rows[1].Cells[1].Value = giris.ad;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[2].Cells[0].Value = "Soyad";
                dataGridView1.Rows[2].Cells[1].Value = giris.soyad;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[3].Cells[0].Value = "E Posta";
                dataGridView1.Rows[3].Cells[1].Value = giris.eposta;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[4].Cells[0].Value = "Şehir";
                dataGridView1.Rows[4].Cells[1].Value = giris.sehir;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[5].Cells[0].Value = "Cinsiyet";
                dataGridView1.Rows[5].Cells[1].Value = giris.cinsiyet;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[6].Cells[0].Value = "Telefon No";
                dataGridView1.Rows[6].Cells[1].Value = giris.telNo;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[7].Cells[0].Value = "Doğum Tarihi";
                dataGridView1.Rows[7].Cells[1].Value = giris.dogumTarihi;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
            }
           

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Giris giris = (Giris)this.Owner;
            giris.kontrol = 2;
            this.Close();
        }
    }
}
