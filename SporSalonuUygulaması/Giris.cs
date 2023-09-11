using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUygulaması
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        DBSporSalonuEntities db = new DBSporSalonuEntities();

        private void txt_KulAdi_TextChanged(object sender, EventArgs e)
        {

        }

        void temizle()
        {
            txt_KulAdi.Text = "";
            txt_Sifre.Text = "";
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            //AnaForm anaForm = new AnaForm();
            //anaForm.ShowDialog();
            //try
            //{
            //    var Giris = db.tbl_PersonelBilgileri.Where(x => x.Giris_Karti == 1 && x.Kul_adi == txt_KulAdi.Text && x.Sifre == txt_Sifre.Text).FirstOrDefault();
            //    if (Giris == null)
            //    {
            //        MessageBox.Show("Giriş yapmak İçin Yetkiniz Yok");
            //    }

            //    else if (Giris.Kul_adi == txt_KulAdi.Text && Giris.Sifre == txt_Sifre.Text && Giris.Giris_Karti == 1)
            //    {
            //        AnaForm giris = new AnaForm();
            //        giris.PersonelID = Giris.Personel_Id;
            //        giris.ShowDialog();

            //    }

            //           ŞİFRESİZ GİRİŞ           //
            AnaForm giris = new AnaForm();
            giris.Show();
            temizle();

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Bir Hata ile Karşılaşıldı.");
            //}
        }

        private void btn_PerEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var Giris = db.tbl_PersonelBilgileri.Where(x => x.Giris_Karti == 1 && x.Kul_adi == txt_KulAdi.Text && x.Sifre == txt_Sifre.Text).FirstOrDefault();
                if (Giris == null)
                {
                    MessageBox.Show("Kayıt Etmek İçin Yetkiniz Yok");
                }

                else if (Giris.Kul_adi == txt_KulAdi.Text && Giris.Sifre == txt_Sifre.Text && Giris.Giris_Karti == 1)
                {
                    PersonelEkle kayit = new PersonelEkle();
                    kayit.ShowDialog();
                }

                temizle();

            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata ile Karşılaşıldı.");

            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
