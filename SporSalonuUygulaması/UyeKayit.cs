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
    public partial class UyeKayit : Form
    {
        public UyeKayit()
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
            cmbox_GirisKarti.DataSource = db.tbl_GirisKarti.ToList();
            cmbox_GirisKarti.DisplayMember = "Durumu";
            cmbox_GirisKarti.ValueMember = "Grs_Id";
            
            cmbox_ProgramSec.DataSource = db.tbl_Program.ToList();
            cmbox_ProgramSec.DisplayMember = "Program_Adi";
            cmbox_ProgramSec.ValueMember = "Id";
            
            cmbox_Gunler.DataSource = db.tbl_Gunler.ToList();
            cmbox_Gunler.DisplayMember = "Gunler";
            cmbox_Gunler.ValueMember = "Id";

            var sorgu = from uye in db.tbl_UyeBilgileri
                        join yetki in db.tbl_GirisKarti on uye.Giris_Karti equals yetki.Grs_Id
                        join program in db.tbl_Program on uye.Program_Sec equals program.Id
                        join gun in db.tbl_Gunler on uye.Gun equals gun.Id
                        select new
                        {
                            uye.Uye_Id,
                            uye.TC_No,
                            uye.Ad_Soyad,
                            uye.Cinsiyet,
                            uye.Telefon,
                            gun.Gunler,
                            uye.Boy,
                            uye.Kilo,
                            uye.Yas,
                            program.Program_Adi,
                            uye.Kayit_Suresi,
                            yetki.Durumu
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void btn_KayitEt_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_UyeBilgileri uye = new tbl_UyeBilgileri();
                uye.Ad_Soyad = txt_AdSoyad.Text;
                uye.Telefon = Convert.ToInt32(txt_Telefon.Text);
                uye.TC_No = txt_TC.Text;
                uye.Cinsiyet = txt_Cinsiyet.Text;
                uye.Boy = Convert.ToInt32(txt_Boy.Text);
                uye.Kilo = Convert.ToInt32(txt_Kilo.Text);
                uye.Yas = Convert.ToInt32(txt_Yas.Text);
                uye.Giris_Karti = Convert.ToInt32(cmbox_GirisKarti.SelectedValue);
                uye.Gun = Convert.ToInt32(cmbox_Gunler.SelectedValue);
                uye.Program_Sec = Convert.ToInt32(cmbox_ProgramSec.SelectedValue);
                db.tbl_UyeBilgileri.Add(uye);
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

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int uye_ID = Convert.ToInt32(txt_Id.Text);
                var uye = db.tbl_UyeBilgileri.Where(x => x.Uye_Id == uye_ID).FirstOrDefault();
                uye.Ad_Soyad = txt_AdSoyad.Text;
                uye.Telefon = Convert.ToInt32(txt_Telefon.Text);
                uye.TC_No = txt_TC.Text;
                uye.Cinsiyet = txt_Cinsiyet.Text;
                uye.Boy = Convert.ToInt32(txt_Boy.Text);
                uye.Kilo = Convert.ToInt32(txt_Kilo.Text);
                uye.Yas = Convert.ToInt32(txt_Yas.Text);
                uye.Giris_Karti = Convert.ToInt32(cmbox_GirisKarti.SelectedValue);
                uye.Gun = Convert.ToInt32(cmbox_Gunler.SelectedValue);
                uye.Program_Sec = Convert.ToInt32(cmbox_ProgramSec.SelectedValue);
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

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                int uye_ID = Convert.ToInt32(txt_Id.Text);
                var silinecekuye = db.tbl_UyeBilgileri.Where(x => x.Uye_Id == uye_ID).FirstOrDefault();
                db.tbl_UyeBilgileri.Remove(silinecekuye);
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

        private void UyeKayit_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Çift tıklanınca textbox ı veri tabanındaki verilerle dolduruyor
            txt_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_AdSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Cinsiyet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Telefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbox_Gunler.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_Boy.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_Kilo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_Yas.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cmbox_ProgramSec.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cmbox_GirisKarti.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }
    }
}
