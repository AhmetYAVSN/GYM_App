using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUygulaması
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        DBSporSalonuEntities db = new DBSporSalonuEntities();

        void Temizle()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                if (this.Controls[i] is ComboBox) this.Controls[i].Text = "";
            }
        }

        void Listele()
        {
            //Combobax içerisine veri dolduruyoruz
            cmbox_GrisKarti.DataSource = db.tbl_GirisKarti.ToList();
            cmbox_GrisKarti.DisplayMember = "Durumu";
            cmbox_GrisKarti.ValueMember = "Grs_Id";

            var sorgu = from personel in db.tbl_PersonelBilgileri
                        join yetki in db.tbl_GirisKarti on personel.Giris_Karti equals yetki.Grs_Id
                        select new
                        {
                            personel.Personel_Id,
                            personel.TC_No,
                            personel.Ad_Soyad,
                            personel.Kul_adi,
                            personel.Sifre,
                            personel.Telefon,
                            personel.Adres,
                            personel.Kayit_Tarihi,
                            yetki.Durumu
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
        private void btn_KayitEt_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_PersonelBilgileri personel = new tbl_PersonelBilgileri();
                personel.Kul_adi = txt_Kulad.Text;
                personel.Sifre = txt_Sifre.Text;
                personel.TC_No = txt_TC.Text;
                personel.Adres = txt_Adres.Text;
                personel.Kayit_Tarihi = dt_KayitTarihi.Value;
                personel.Giris_Karti = Convert.ToInt32(cmbox_GrisKarti.SelectedValue);
                personel.Ad_Soyad = txt_PersonelAd.Text;
                personel.Telefon = Convert.ToInt32(txt_Telefon.Text);
                db.tbl_PersonelBilgileri.Add(personel);
                db.SaveChanges();
                Listele();
                Temizle();
                MessageBox.Show("Kayıt başarılı.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt başarısız.");
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {

            try
            {
                int personel_ID = Convert.ToInt32(txt_Id.Text);
                var personel = db.tbl_PersonelBilgileri.Where(x => x.Personel_Id == personel_ID).FirstOrDefault();
                personel.Kul_adi = txt_Kulad.Text;
                personel.Ad_Soyad = txt_PersonelAd.Text;
                personel.Sifre = txt_Sifre.Text;
                personel.Telefon = Convert.ToInt32(txt_Telefon.Text);
                personel.TC_No = txt_TC.Text;
                personel.Adres = txt_Adres.Text;
                personel.Giris_Karti = Convert.ToInt32(cmbox_GrisKarti.SelectedValue);
                //personel.Kayıt_Tarihi = dt_KayitTarihi.Value;
                db.SaveChanges();
                Listele();
                Temizle();
                MessageBox.Show("Başarılı bir şekilde güncellenmiştir.");
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme yapılamadı.");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                int personel_ID = Convert.ToInt32(txt_Id.Text);
                var silinecekPersonel = db.tbl_PersonelBilgileri.Where(x => x.Personel_Id == personel_ID).FirstOrDefault();
                db.tbl_PersonelBilgileri.Remove(silinecekPersonel);
                db.SaveChanges();
                Listele();
                Temizle();
                MessageBox.Show("başarılı bir şekilde silinmiştir.");
            }
            catch (Exception)
            {
                MessageBox.Show("silme işlemi yapılamadı.");
            }
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Çift tıklanınca textbox ı veri tabanındaki verilerle dolduruyor
            txt_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_PersonelAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Kulad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Sifre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_Telefon.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_Adres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cmbox_GrisKarti.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
