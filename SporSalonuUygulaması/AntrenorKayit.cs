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
    public partial class AntrenorKayit : Form
    {
        public AntrenorKayit()
        {
            InitializeComponent();
        }

        DBSporSalonuEntities db = new DBSporSalonuEntities();

        void Temizle()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
            }
        }

        void Listele()
        {
            var sorgu = from antrenor in db.tbl_antrenor
                        select new
                        {
                            antrenor.Antrenor_Id,
                            antrenor.Adi,
                            antrenor.Soyadi,
                            antrenor.Cinsiyet,
                            antrenor.Telefon,
                            antrenor.E_Posta,
                            antrenor.Dogum_Tarihi,
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
        private void btn_KayitEt_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_antrenor antrenor = new tbl_antrenor();
                antrenor.Adi = txt_Adi.Text;
                antrenor.Soyadi = txt_Soyad.Text;
                antrenor.Cinsiyet = txt_Cinssiyet.Text;
                antrenor.E_Posta = txt_Eposta.Text;
                antrenor.Dogum_Tarihi = dt_DogTarihi.Value;
                antrenor.Telefon = Convert.ToInt32(txt_Telefon.Text);
                db.tbl_antrenor.Add(antrenor);
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

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int antrenor_ID = Convert.ToInt32(txt_Id.Text);
                var antrenor = db.tbl_antrenor.Where(x => x.Antrenor_Id == antrenor_ID).FirstOrDefault();
                antrenor.Adi = txt_Adi.Text;
                antrenor.Soyadi = txt_Soyad.Text;
                antrenor.Cinsiyet = txt_Cinssiyet.Text;
                antrenor.E_Posta = txt_Eposta.Text;
                antrenor.Dogum_Tarihi = dt_DogTarihi.Value;
                antrenor.Telefon = Convert.ToInt32(txt_Telefon.Text);
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
                int antrenor_ID = Convert.ToInt32(txt_Id.Text);
                var silinecekAntrenor = db.tbl_antrenor.Where(x => x.Antrenor_Id == antrenor_ID).FirstOrDefault();
                db.tbl_antrenor.Remove(silinecekAntrenor);
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

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void AntrenorKayit_Load(object sender, EventArgs e)
        {
            Temizle(); Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Cinssiyet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Telefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_Eposta.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dt_DogTarihi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
