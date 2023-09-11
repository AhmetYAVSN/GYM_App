namespace SporSalonuUygulaması
{
    partial class Giris
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
            this.lbl_KulAdi = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_KulAdi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.btn_PerEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_KulAdi
            // 
            this.lbl_KulAdi.AutoSize = true;
            this.lbl_KulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KulAdi.Location = new System.Drawing.Point(42, 70);
            this.lbl_KulAdi.Name = "lbl_KulAdi";
            this.lbl_KulAdi.Size = new System.Drawing.Size(120, 20);
            this.lbl_KulAdi.TabIndex = 0;
            this.lbl_KulAdi.Text = "Kullanıcı Adı:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.Location = new System.Drawing.Point(107, 116);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(55, 20);
            this.lbl_Sifre.TabIndex = 1;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // txt_KulAdi
            // 
            this.txt_KulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KulAdi.Location = new System.Drawing.Point(191, 64);
            this.txt_KulAdi.Name = "txt_KulAdi";
            this.txt_KulAdi.Size = new System.Drawing.Size(143, 26);
            this.txt_KulAdi.TabIndex = 1;
            this.txt_KulAdi.TextChanged += new System.EventHandler(this.txt_KulAdi_TextChanged);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sifre.Location = new System.Drawing.Point(191, 110);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(143, 26);
            this.txt_Sifre.TabIndex = 2;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.Location = new System.Drawing.Point(191, 156);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(140, 40);
            this.btn_Giris.TabIndex = 3;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // btn_PerEkle
            // 
            this.btn_PerEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_PerEkle.Location = new System.Drawing.Point(191, 205);
            this.btn_PerEkle.Name = "btn_PerEkle";
            this.btn_PerEkle.Size = new System.Drawing.Size(140, 40);
            this.btn_PerEkle.TabIndex = 4;
            this.btn_PerEkle.Text = "Personel Ekle";
            this.btn_PerEkle.UseVisualStyleBackColor = true;
            this.btn_PerEkle.Click += new System.EventHandler(this.btn_PerEkle_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 300);
            this.Controls.Add(this.btn_PerEkle);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KulAdi);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KulAdi);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KulAdi;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox txt_KulAdi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Button btn_PerEkle;
    }
}