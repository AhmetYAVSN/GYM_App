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
    public partial class AntrenorListesi : Form
    {
        public AntrenorListesi()
        {
            InitializeComponent();
        }
        DBSporSalonuEntities db = new DBSporSalonuEntities();
        private void txt_Ara_TextChanged(object sender, EventArgs e)
        {
            string anahtarKelime = txt_Ara.Text;
            var sorgu = from antrenor in db.tbl_antrenor
                        where antrenor.Adi.Contains(anahtarKelime) | antrenor.Soyadi.Contains(anahtarKelime) | antrenor.Cinsiyet.Contains(anahtarKelime)
                        select new
                        {
                            antrenor.Adi,
                            antrenor.Soyadi,
                            antrenor.Cinsiyet,
                            antrenor.Telefon,
                            antrenor.E_Posta,
                            antrenor.Dogum_Tarihi
                        };

            dataGridView1.DataSource = sorgu.ToList();
        }

        private void AntrenorListesi_Load(object sender, EventArgs e)
        {
            var sorgu = from antrenor in db.tbl_antrenor
                        select new
                        {
                            antrenor.Adi,
                            antrenor.Soyadi,
                            antrenor.Cinsiyet,
                            antrenor.Telefon,
                            antrenor.E_Posta,
                            antrenor.Dogum_Tarihi
                        };

            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
