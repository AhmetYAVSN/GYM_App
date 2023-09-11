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
    public partial class PersonelListesi : Form
    {
        public PersonelListesi()
        {
            InitializeComponent();
        }

        DBSporSalonuEntities db = new DBSporSalonuEntities();
        private void PersonelListesi_Load(object sender, EventArgs e)
        {
            var sorgu = from personel in db.tbl_PersonelBilgileri
                        select new
                        {
                            personel.TC_No,
                            personel.Ad_Soyad,
                            personel.Kul_adi,
                            personel.Sifre,
                            personel.Telefon,
                            personel.Adres,
                            personel.Giris_Karti,
                            personel.Kayit_Tarihi
                        };

            dataGridView1.DataSource = sorgu.ToList();
        }

        private void txt_Ara_TextChanged(object sender, EventArgs e)
        {
            string anahtarKelime = txt_Ara.Text;
            var sorgu = from personel in db.tbl_PersonelBilgileri
                        where personel.Kul_adi.Contains(anahtarKelime) | personel.Ad_Soyad.Contains(anahtarKelime) | personel.TC_No.Contains(anahtarKelime)
                        select new
                        {
                            personel.TC_No,
                            personel.Ad_Soyad,
                            personel.Kul_adi,
                            personel.Sifre,
                            personel.Telefon,
                            personel.Adres,
                            personel.Giris_Karti,
                            personel.Kayit_Tarihi
                        };

            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
