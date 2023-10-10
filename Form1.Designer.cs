namespace PaintApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cizimpaneli = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.altigen_panel = new System.Windows.Forms.Panel();
            this.ucgen_panel = new System.Windows.Forms.Panel();
            this.daire_panel = new System.Windows.Forms.Panel();
            this.kare_panel = new System.Windows.Forms.Panel();
            this.renkpaneli = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_beyaz = new System.Windows.Forms.Panel();
            this.btn_beyaz = new System.Windows.Forms.Button();
            this.panel_kahve = new System.Windows.Forms.Panel();
            this.btn_kahve = new System.Windows.Forms.Button();
            this.panel_mor = new System.Windows.Forms.Panel();
            this.btn_mor = new System.Windows.Forms.Button();
            this.panel_sari = new System.Windows.Forms.Panel();
            this.btn_sari = new System.Windows.Forms.Button();
            this.panel_siyah = new System.Windows.Forms.Panel();
            this.btn_siyah = new System.Windows.Forms.Button();
            this.panel_turuncu = new System.Windows.Forms.Panel();
            this.btn_turuncu = new System.Windows.Forms.Button();
            this.panel_yesil = new System.Windows.Forms.Panel();
            this.btn_yesil = new System.Windows.Forms.Button();
            this.panel_mavi = new System.Windows.Forms.Panel();
            this.btn_mavi = new System.Windows.Forms.Button();
            this.panel_kirmizi = new System.Windows.Forms.Panel();
            this.btn_kirmizi = new System.Windows.Forms.Button();
            this.dosyaislemleripaneli = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.kaydet_panel = new System.Windows.Forms.Panel();
            this.ac_panel = new System.Windows.Forms.Panel();
            this.islempaneli = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.sil_panel = new System.Windows.Forms.Panel();
            this.sec_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.cizimpaneli.SuspendLayout();
            this.renkpaneli.SuspendLayout();
            this.panel_beyaz.SuspendLayout();
            this.panel_kahve.SuspendLayout();
            this.panel_mor.SuspendLayout();
            this.panel_sari.SuspendLayout();
            this.panel_siyah.SuspendLayout();
            this.panel_turuncu.SuspendLayout();
            this.panel_yesil.SuspendLayout();
            this.panel_mavi.SuspendLayout();
            this.panel_kirmizi.SuspendLayout();
            this.dosyaislemleripaneli.SuspendLayout();
            this.islempaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.cizimpaneli);
            this.panel1.Controls.Add(this.renkpaneli);
            this.panel1.Controls.Add(this.dosyaislemleripaneli);
            this.panel1.Controls.Add(this.islempaneli);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(763, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 584);
            this.panel1.TabIndex = 0;
            // 
            // cizimpaneli
            // 
            this.cizimpaneli.BackColor = System.Drawing.Color.PeachPuff;
            this.cizimpaneli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cizimpaneli.Controls.Add(this.label1);
            this.cizimpaneli.Controls.Add(this.altigen_panel);
            this.cizimpaneli.Controls.Add(this.ucgen_panel);
            this.cizimpaneli.Controls.Add(this.daire_panel);
            this.cizimpaneli.Controls.Add(this.kare_panel);
            this.cizimpaneli.Location = new System.Drawing.Point(0, 3);
            this.cizimpaneli.Name = "cizimpaneli";
            this.cizimpaneli.Size = new System.Drawing.Size(155, 160);
            this.cizimpaneli.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Çizim Şekili";
            // 
            // altigen_panel
            // 
            this.altigen_panel.BackgroundImage = global::PaintApp.Properties.Resources.hexagon1;
            this.altigen_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.altigen_panel.Location = new System.Drawing.Point(79, 93);
            this.altigen_panel.Name = "altigen_panel";
            this.altigen_panel.Size = new System.Drawing.Size(60, 60);
            this.altigen_panel.TabIndex = 3;
            this.altigen_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.altigen_panel_Paint);
            this.altigen_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.altigen_panel_MouseClick);
            // 
            // ucgen_panel
            // 
            this.ucgen_panel.BackgroundImage = global::PaintApp.Properties.Resources.triangle1;
            this.ucgen_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ucgen_panel.Location = new System.Drawing.Point(15, 93);
            this.ucgen_panel.Name = "ucgen_panel";
            this.ucgen_panel.Size = new System.Drawing.Size(60, 60);
            this.ucgen_panel.TabIndex = 2;
            this.ucgen_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.ucgen_panel_Paint);
            this.ucgen_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucgen_panel_MouseClick);
            // 
            // daire_panel
            // 
            this.daire_panel.BackgroundImage = global::PaintApp.Properties.Resources.circle1;
            this.daire_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.daire_panel.Location = new System.Drawing.Point(79, 24);
            this.daire_panel.Name = "daire_panel";
            this.daire_panel.Size = new System.Drawing.Size(60, 60);
            this.daire_panel.TabIndex = 1;
            this.daire_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.daire_panel_Paint);
            this.daire_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.daire_panel_MouseClick);
            // 
            // kare_panel
            // 
            this.kare_panel.BackgroundImage = global::PaintApp.Properties.Resources.square1;
            this.kare_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kare_panel.Location = new System.Drawing.Point(15, 24);
            this.kare_panel.Name = "kare_panel";
            this.kare_panel.Size = new System.Drawing.Size(60, 60);
            this.kare_panel.TabIndex = 0;
            this.kare_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kare_panel_Paint);
            this.kare_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kare_panel_MouseClick);
            // 
            // renkpaneli
            // 
            this.renkpaneli.BackColor = System.Drawing.Color.SkyBlue;
            this.renkpaneli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renkpaneli.Controls.Add(this.label2);
            this.renkpaneli.Controls.Add(this.panel_beyaz);
            this.renkpaneli.Controls.Add(this.panel_kahve);
            this.renkpaneli.Controls.Add(this.panel_mor);
            this.renkpaneli.Controls.Add(this.panel_sari);
            this.renkpaneli.Controls.Add(this.panel_siyah);
            this.renkpaneli.Controls.Add(this.panel_turuncu);
            this.renkpaneli.Controls.Add(this.panel_yesil);
            this.renkpaneli.Controls.Add(this.panel_mavi);
            this.renkpaneli.Controls.Add(this.panel_kirmizi);
            this.renkpaneli.Location = new System.Drawing.Point(0, 166);
            this.renkpaneli.Name = "renkpaneli";
            this.renkpaneli.Size = new System.Drawing.Size(155, 165);
            this.renkpaneli.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Çizim Rengi";
            // 
            // panel_beyaz
            // 
            this.panel_beyaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_beyaz.Controls.Add(this.btn_beyaz);
            this.panel_beyaz.Location = new System.Drawing.Point(100, 119);
            this.panel_beyaz.Name = "panel_beyaz";
            this.panel_beyaz.Size = new System.Drawing.Size(38, 38);
            this.panel_beyaz.TabIndex = 8;
            // 
            // btn_beyaz
            // 
            this.btn_beyaz.BackColor = System.Drawing.Color.White;
            this.btn_beyaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_beyaz.Location = new System.Drawing.Point(4, 4);
            this.btn_beyaz.Name = "btn_beyaz";
            this.btn_beyaz.Size = new System.Drawing.Size(30, 30);
            this.btn_beyaz.TabIndex = 0;
            this.btn_beyaz.UseVisualStyleBackColor = false;
            this.btn_beyaz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_beyaz_MouseClick);
            // 
            // panel_kahve
            // 
            this.panel_kahve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_kahve.Controls.Add(this.btn_kahve);
            this.panel_kahve.Location = new System.Drawing.Point(56, 119);
            this.panel_kahve.Name = "panel_kahve";
            this.panel_kahve.Size = new System.Drawing.Size(38, 38);
            this.panel_kahve.TabIndex = 7;
            // 
            // btn_kahve
            // 
            this.btn_kahve.BackColor = System.Drawing.Color.Brown;
            this.btn_kahve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kahve.Location = new System.Drawing.Point(4, 4);
            this.btn_kahve.Name = "btn_kahve";
            this.btn_kahve.Size = new System.Drawing.Size(30, 30);
            this.btn_kahve.TabIndex = 0;
            this.btn_kahve.UseVisualStyleBackColor = false;
            this.btn_kahve.Click += new System.EventHandler(this.btn_kahve_Click);
            // 
            // panel_mor
            // 
            this.panel_mor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_mor.Controls.Add(this.btn_mor);
            this.panel_mor.Location = new System.Drawing.Point(12, 119);
            this.panel_mor.Name = "panel_mor";
            this.panel_mor.Size = new System.Drawing.Size(38, 38);
            this.panel_mor.TabIndex = 6;
            // 
            // btn_mor
            // 
            this.btn_mor.BackColor = System.Drawing.Color.Purple;
            this.btn_mor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mor.Location = new System.Drawing.Point(4, 4);
            this.btn_mor.Name = "btn_mor";
            this.btn_mor.Size = new System.Drawing.Size(30, 30);
            this.btn_mor.TabIndex = 0;
            this.btn_mor.UseVisualStyleBackColor = false;
            this.btn_mor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_mor_MouseClick);
            // 
            // panel_sari
            // 
            this.panel_sari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_sari.Controls.Add(this.btn_sari);
            this.panel_sari.Location = new System.Drawing.Point(100, 75);
            this.panel_sari.Name = "panel_sari";
            this.panel_sari.Size = new System.Drawing.Size(38, 38);
            this.panel_sari.TabIndex = 5;
            // 
            // btn_sari
            // 
            this.btn_sari.BackColor = System.Drawing.Color.Yellow;
            this.btn_sari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sari.Location = new System.Drawing.Point(4, 4);
            this.btn_sari.Name = "btn_sari";
            this.btn_sari.Size = new System.Drawing.Size(30, 30);
            this.btn_sari.TabIndex = 0;
            this.btn_sari.UseVisualStyleBackColor = false;
            this.btn_sari.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_sari_MouseClick);
            // 
            // panel_siyah
            // 
            this.panel_siyah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_siyah.Controls.Add(this.btn_siyah);
            this.panel_siyah.Location = new System.Drawing.Point(56, 75);
            this.panel_siyah.Name = "panel_siyah";
            this.panel_siyah.Size = new System.Drawing.Size(38, 38);
            this.panel_siyah.TabIndex = 4;
            // 
            // btn_siyah
            // 
            this.btn_siyah.BackColor = System.Drawing.Color.Black;
            this.btn_siyah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siyah.Location = new System.Drawing.Point(4, 4);
            this.btn_siyah.Name = "btn_siyah";
            this.btn_siyah.Size = new System.Drawing.Size(30, 30);
            this.btn_siyah.TabIndex = 0;
            this.btn_siyah.UseVisualStyleBackColor = false;
            this.btn_siyah.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_siyah_MouseClick);
            // 
            // panel_turuncu
            // 
            this.panel_turuncu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_turuncu.Controls.Add(this.btn_turuncu);
            this.panel_turuncu.Location = new System.Drawing.Point(12, 75);
            this.panel_turuncu.Name = "panel_turuncu";
            this.panel_turuncu.Size = new System.Drawing.Size(38, 38);
            this.panel_turuncu.TabIndex = 3;
            // 
            // btn_turuncu
            // 
            this.btn_turuncu.BackColor = System.Drawing.Color.Orange;
            this.btn_turuncu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_turuncu.Location = new System.Drawing.Point(4, 4);
            this.btn_turuncu.Name = "btn_turuncu";
            this.btn_turuncu.Size = new System.Drawing.Size(30, 30);
            this.btn_turuncu.TabIndex = 0;
            this.btn_turuncu.UseVisualStyleBackColor = false;
            this.btn_turuncu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_turuncu_MouseClick);
            // 
            // panel_yesil
            // 
            this.panel_yesil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_yesil.Controls.Add(this.btn_yesil);
            this.panel_yesil.Location = new System.Drawing.Point(100, 32);
            this.panel_yesil.Name = "panel_yesil";
            this.panel_yesil.Size = new System.Drawing.Size(38, 38);
            this.panel_yesil.TabIndex = 2;
            // 
            // btn_yesil
            // 
            this.btn_yesil.BackColor = System.Drawing.Color.Green;
            this.btn_yesil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yesil.Location = new System.Drawing.Point(4, 4);
            this.btn_yesil.Name = "btn_yesil";
            this.btn_yesil.Size = new System.Drawing.Size(30, 30);
            this.btn_yesil.TabIndex = 0;
            this.btn_yesil.UseVisualStyleBackColor = false;
            this.btn_yesil.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_yesil_MouseClick);
            // 
            // panel_mavi
            // 
            this.panel_mavi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_mavi.Controls.Add(this.btn_mavi);
            this.panel_mavi.Location = new System.Drawing.Point(56, 32);
            this.panel_mavi.Name = "panel_mavi";
            this.panel_mavi.Size = new System.Drawing.Size(38, 38);
            this.panel_mavi.TabIndex = 1;
            // 
            // btn_mavi
            // 
            this.btn_mavi.BackColor = System.Drawing.Color.Blue;
            this.btn_mavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mavi.Location = new System.Drawing.Point(4, 4);
            this.btn_mavi.Name = "btn_mavi";
            this.btn_mavi.Size = new System.Drawing.Size(30, 30);
            this.btn_mavi.TabIndex = 0;
            this.btn_mavi.UseVisualStyleBackColor = false;
            this.btn_mavi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_mavi_MouseClick);
            // 
            // panel_kirmizi
            // 
            this.panel_kirmizi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_kirmizi.Controls.Add(this.btn_kirmizi);
            this.panel_kirmizi.Location = new System.Drawing.Point(12, 32);
            this.panel_kirmizi.Name = "panel_kirmizi";
            this.panel_kirmizi.Size = new System.Drawing.Size(38, 38);
            this.panel_kirmizi.TabIndex = 0;
            // 
            // btn_kirmizi
            // 
            this.btn_kirmizi.BackColor = System.Drawing.Color.Red;
            this.btn_kirmizi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kirmizi.Location = new System.Drawing.Point(4, 4);
            this.btn_kirmizi.Name = "btn_kirmizi";
            this.btn_kirmizi.Size = new System.Drawing.Size(30, 30);
            this.btn_kirmizi.TabIndex = 0;
            this.btn_kirmizi.UseVisualStyleBackColor = false;
            this.btn_kirmizi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_kirmizi_MouseClick);
            // 
            // dosyaislemleripaneli
            // 
            this.dosyaislemleripaneli.BackColor = System.Drawing.Color.LightGreen;
            this.dosyaislemleripaneli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dosyaislemleripaneli.Controls.Add(this.label4);
            this.dosyaislemleripaneli.Controls.Add(this.kaydet_panel);
            this.dosyaislemleripaneli.Controls.Add(this.ac_panel);
            this.dosyaislemleripaneli.Location = new System.Drawing.Point(0, 449);
            this.dosyaislemleripaneli.Name = "dosyaislemleripaneli";
            this.dosyaislemleripaneli.Size = new System.Drawing.Size(155, 132);
            this.dosyaislemleripaneli.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dosya İşlemleri";
            // 
            // kaydet_panel
            // 
            this.kaydet_panel.BackgroundImage = global::PaintApp.Properties.Resources.save2;
            this.kaydet_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kaydet_panel.Location = new System.Drawing.Point(89, 43);
            this.kaydet_panel.Name = "kaydet_panel";
            this.kaydet_panel.Size = new System.Drawing.Size(50, 50);
            this.kaydet_panel.TabIndex = 1;
            this.kaydet_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kaydet_panel_MouseClick);
            // 
            // ac_panel
            // 
            this.ac_panel.BackgroundImage = global::PaintApp.Properties.Resources.folder2;
            this.ac_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ac_panel.Location = new System.Drawing.Point(14, 44);
            this.ac_panel.Name = "ac_panel";
            this.ac_panel.Size = new System.Drawing.Size(50, 50);
            this.ac_panel.TabIndex = 0;
            this.ac_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ac_panel_MouseClick);
            // 
            // islempaneli
            // 
            this.islempaneli.BackColor = System.Drawing.Color.White;
            this.islempaneli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.islempaneli.Controls.Add(this.label3);
            this.islempaneli.Controls.Add(this.sil_panel);
            this.islempaneli.Controls.Add(this.sec_panel);
            this.islempaneli.Location = new System.Drawing.Point(0, 335);
            this.islempaneli.Name = "islempaneli";
            this.islempaneli.Size = new System.Drawing.Size(155, 108);
            this.islempaneli.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şekil İşlemleri";
            // 
            // sil_panel
            // 
            this.sil_panel.BackgroundImage = global::PaintApp.Properties.Resources.icons8_trash_48;
            this.sil_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sil_panel.Location = new System.Drawing.Point(90, 34);
            this.sil_panel.Name = "sil_panel";
            this.sil_panel.Size = new System.Drawing.Size(50, 50);
            this.sil_panel.TabIndex = 1;
            this.sil_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sil_panel_MouseClick);
            // 
            // sec_panel
            // 
            this.sec_panel.BackgroundImage = global::PaintApp.Properties.Resources.icons8_natural_user_interface_2_40;
            this.sec_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sec_panel.Location = new System.Drawing.Point(16, 34);
            this.sec_panel.Name = "sec_panel";
            this.sec_panel.Size = new System.Drawing.Size(50, 50);
            this.sec_panel.TabIndex = 0;
            this.sec_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sec_panel_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 560);
            this.panel2.TabIndex = 1;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown_1);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "PaintApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.cizimpaneli.ResumeLayout(false);
            this.cizimpaneli.PerformLayout();
            this.renkpaneli.ResumeLayout(false);
            this.renkpaneli.PerformLayout();
            this.panel_beyaz.ResumeLayout(false);
            this.panel_kahve.ResumeLayout(false);
            this.panel_mor.ResumeLayout(false);
            this.panel_sari.ResumeLayout(false);
            this.panel_siyah.ResumeLayout(false);
            this.panel_turuncu.ResumeLayout(false);
            this.panel_yesil.ResumeLayout(false);
            this.panel_mavi.ResumeLayout(false);
            this.panel_kirmizi.ResumeLayout(false);
            this.dosyaislemleripaneli.ResumeLayout(false);
            this.dosyaislemleripaneli.PerformLayout();
            this.islempaneli.ResumeLayout(false);
            this.islempaneli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel dosyaislemleripaneli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel kaydet_panel;
        private System.Windows.Forms.Panel ac_panel;
        private System.Windows.Forms.Panel islempaneli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel sil_panel;
        private System.Windows.Forms.Panel sec_panel;
        private System.Windows.Forms.Panel cizimpaneli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel altigen_panel;
        private System.Windows.Forms.Panel ucgen_panel;
        private System.Windows.Forms.Panel daire_panel;
        private System.Windows.Forms.Panel kare_panel;
        private System.Windows.Forms.Panel renkpaneli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_beyaz;
        private System.Windows.Forms.Button btn_beyaz;
        private System.Windows.Forms.Panel panel_kahve;
        private System.Windows.Forms.Button btn_kahve;
        private System.Windows.Forms.Panel panel_mor;
        private System.Windows.Forms.Button btn_mor;
        private System.Windows.Forms.Panel panel_sari;
        private System.Windows.Forms.Button btn_sari;
        private System.Windows.Forms.Panel panel_siyah;
        private System.Windows.Forms.Button btn_siyah;
        private System.Windows.Forms.Panel panel_turuncu;
        private System.Windows.Forms.Button btn_turuncu;
        private System.Windows.Forms.Panel panel_yesil;
        private System.Windows.Forms.Button btn_yesil;
        private System.Windows.Forms.Panel panel_mavi;
        private System.Windows.Forms.Button btn_mavi;
        private System.Windows.Forms.Panel panel_kirmizi;
        private System.Windows.Forms.Button btn_kirmizi;
        private System.Windows.Forms.Panel panel2;
    }
}

