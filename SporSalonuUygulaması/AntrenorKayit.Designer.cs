namespace SporSalonuUygulaması
{
    partial class AntrenorKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_DogTarih = new System.Windows.Forms.Label();
            this.dt_DogTarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_KayitEt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Adi = new System.Windows.Forms.TextBox();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.cmbox_GrisKarti = new System.Windows.Forms.ComboBox();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.txt_Cinssiyet = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.lbl_GirisKarti = new System.Windows.Forms.Label();
            this.lbl_Adi = new System.Windows.Forms.Label();
            this.lbl_Eposta = new System.Windows.Forms.Label();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_Cinsiyet = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(12, 189);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(35, 20);
            this.txt_Id.TabIndex = 43;
            // 
            // lbl_DogTarih
            // 
            this.lbl_DogTarih.AutoSize = true;
            this.lbl_DogTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DogTarih.Location = new System.Drawing.Point(312, 287);
            this.lbl_DogTarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DogTarih.Name = "lbl_DogTarih";
            this.lbl_DogTarih.Size = new System.Drawing.Size(110, 17);
            this.lbl_DogTarih.TabIndex = 42;
            this.lbl_DogTarih.Text = "Doğum Tarihi:";
            // 
            // dt_DogTarihi
            // 
            this.dt_DogTarihi.Enabled = false;
            this.dt_DogTarihi.Location = new System.Drawing.Point(438, 284);
            this.dt_DogTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dt_DogTarihi.Name = "dt_DogTarihi";
            this.dt_DogTarihi.Size = new System.Drawing.Size(138, 20);
            this.dt_DogTarihi.TabIndex = 41;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Location = new System.Drawing.Point(12, 340);
            this.btn_Temizle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(87, 32);
            this.btn_Temizle.TabIndex = 40;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(456, 340);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(87, 32);
            this.btn_Sil.TabIndex = 39;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(329, 340);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(87, 32);
            this.btn_Guncelle.TabIndex = 38;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_KayitEt
            // 
            this.btn_KayitEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KayitEt.Location = new System.Drawing.Point(164, 340);
            this.btn_KayitEt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_KayitEt.Name = "btn_KayitEt";
            this.btn_KayitEt.Size = new System.Drawing.Size(87, 32);
            this.btn_KayitEt.TabIndex = 37;
            this.btn_KayitEt.Text = "Kayit Et";
            this.btn_KayitEt.UseVisualStyleBackColor = true;
            this.btn_KayitEt.Click += new System.EventHandler(this.btn_KayitEt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(565, 157);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txt_Adi
            // 
            this.txt_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Adi.Location = new System.Drawing.Point(150, 208);
            this.txt_Adi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Adi.Name = "txt_Adi";
            this.txt_Adi.Size = new System.Drawing.Size(111, 23);
            this.txt_Adi.TabIndex = 23;
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Eposta.Location = new System.Drawing.Point(438, 231);
            this.txt_Eposta.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(111, 23);
            this.txt_Eposta.TabIndex = 34;
            // 
            // cmbox_GrisKarti
            // 
            this.cmbox_GrisKarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_GrisKarti.FormattingEnabled = true;
            this.cmbox_GrisKarti.Location = new System.Drawing.Point(438, 257);
            this.cmbox_GrisKarti.Margin = new System.Windows.Forms.Padding(2);
            this.cmbox_GrisKarti.Name = "cmbox_GrisKarti";
            this.cmbox_GrisKarti.Size = new System.Drawing.Size(111, 24);
            this.cmbox_GrisKarti.TabIndex = 35;
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Telefon.Location = new System.Drawing.Point(438, 205);
            this.txt_Telefon.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(111, 23);
            this.txt_Telefon.TabIndex = 32;
            // 
            // txt_Cinssiyet
            // 
            this.txt_Cinssiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Cinssiyet.Location = new System.Drawing.Point(150, 260);
            this.txt_Cinssiyet.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cinssiyet.Name = "txt_Cinssiyet";
            this.txt_Cinssiyet.Size = new System.Drawing.Size(111, 23);
            this.txt_Cinssiyet.TabIndex = 28;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Soyad.Location = new System.Drawing.Point(150, 234);
            this.txt_Soyad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(111, 23);
            this.txt_Soyad.TabIndex = 26;
            // 
            // lbl_GirisKarti
            // 
            this.lbl_GirisKarti.AutoSize = true;
            this.lbl_GirisKarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_GirisKarti.Location = new System.Drawing.Point(336, 261);
            this.lbl_GirisKarti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GirisKarti.Name = "lbl_GirisKarti";
            this.lbl_GirisKarti.Size = new System.Drawing.Size(86, 17);
            this.lbl_GirisKarti.TabIndex = 33;
            this.lbl_GirisKarti.Text = "Giriş Kartı:";
            // 
            // lbl_Adi
            // 
            this.lbl_Adi.AutoSize = true;
            this.lbl_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Adi.Location = new System.Drawing.Point(98, 211);
            this.lbl_Adi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Adi.Name = "lbl_Adi";
            this.lbl_Adi.Size = new System.Drawing.Size(36, 17);
            this.lbl_Adi.TabIndex = 31;
            this.lbl_Adi.Text = "Adı:";
            // 
            // lbl_Eposta
            // 
            this.lbl_Eposta.AutoSize = true;
            this.lbl_Eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Eposta.Location = new System.Drawing.Point(352, 235);
            this.lbl_Eposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Eposta.Name = "lbl_Eposta";
            this.lbl_Eposta.Size = new System.Drawing.Size(70, 17);
            this.lbl_Eposta.TabIndex = 29;
            this.lbl_Eposta.Text = "E-Posta:";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Telefon.Location = new System.Drawing.Point(354, 209);
            this.lbl_Telefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(68, 17);
            this.lbl_Telefon.TabIndex = 27;
            this.lbl_Telefon.Text = "Telefon:";
            // 
            // lbl_Cinsiyet
            // 
            this.lbl_Cinsiyet.AutoSize = true;
            this.lbl_Cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Cinsiyet.Location = new System.Drawing.Point(64, 263);
            this.lbl_Cinsiyet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Cinsiyet.Name = "lbl_Cinsiyet";
            this.lbl_Cinsiyet.Size = new System.Drawing.Size(70, 17);
            this.lbl_Cinsiyet.TabIndex = 24;
            this.lbl_Cinsiyet.Text = "Cinsiyet:";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyad.Location = new System.Drawing.Point(72, 237);
            this.lbl_Soyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(62, 17);
            this.lbl_Soyad.TabIndex = 22;
            this.lbl_Soyad.Text = "Soyadı:";
            // 
            // AntrenorKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_DogTarih);
            this.Controls.Add(this.dt_DogTarihi);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_KayitEt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Adi);
            this.Controls.Add(this.txt_Eposta);
            this.Controls.Add(this.cmbox_GrisKarti);
            this.Controls.Add(this.txt_Telefon);
            this.Controls.Add(this.txt_Cinssiyet);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.lbl_GirisKarti);
            this.Controls.Add(this.lbl_Adi);
            this.Controls.Add(this.lbl_Eposta);
            this.Controls.Add(this.lbl_Telefon);
            this.Controls.Add(this.lbl_Cinsiyet);
            this.Controls.Add(this.lbl_Soyad);
            this.Name = "AntrenorKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AntrenorKayit";
            this.Load += new System.EventHandler(this.AntrenorKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_DogTarih;
        private System.Windows.Forms.DateTimePicker dt_DogTarihi;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_KayitEt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Adi;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.ComboBox cmbox_GrisKarti;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.TextBox txt_Cinssiyet;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label lbl_GirisKarti;
        private System.Windows.Forms.Label lbl_Adi;
        private System.Windows.Forms.Label lbl_Eposta;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_Cinsiyet;
        private System.Windows.Forms.Label lbl_Soyad;
    }
}