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
    public partial class UyeListesi : Form
    {
        public UyeListesi()
        {
            InitializeComponent();
        }
        DBSporSalonuEntities db = new DBSporSalonuEntities();
        private void txt_Ara_TextChanged(object sender, EventArgs e)
        {
            string anahtarKelime = txt_Ara.Text;
            var sorgu = from uye in db.tbl_UyeBilgileri
                        where uye.Ad_Soyad.Contains(anahtarKelime) | uye.Cinsiyet.Contains(anahtarKelime) | uye.TC_No.Contains(anahtarKelime)
                        select new
                        {
                            uye.TC_No,
                            uye.Ad_Soyad,
                            uye.Cinsiyet,
                            uye.Telefon,
                            uye.Boy,
                            uye.Kilo,
                            uye.Yas,
                            uye.Gun,
                            uye.Giris_Karti,
                            uye.Program_Sec,
                            uye.Kayit_Suresi
                        };

            dataGridView1.DataSource = sorgu.ToList();
        }

        private void UyeListesi_Load(object sender, EventArgs e)
        {
            var sorgu = from uye in db.tbl_UyeBilgileri
                        select new
                        {
                            uye.TC_No,
                            uye.Ad_Soyad,
                            uye.Cinsiyet,
                            uye.Telefon,
                            uye.Boy,
                            uye.Kilo,
                            uye.Yas,
                            uye.Gun,
                            uye.Giris_Karti,
                            uye.Program_Sec,
                            uye.Kayit_Suresi
                        };

            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
