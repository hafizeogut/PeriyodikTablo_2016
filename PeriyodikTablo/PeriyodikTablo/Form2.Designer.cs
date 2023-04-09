namespace PeriyodikTablo
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvGoster = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.tmrKayanYazi = new System.Windows.Forms.Timer(this.components);
            this.gboxElement = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxGrub = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHepsiniGoster = new System.Windows.Forms.Button();
            this.pElement = new System.Windows.Forms.Panel();
            this.btnPanelCikis = new System.Windows.Forms.Button();
            this.btnKapatt = new System.Windows.Forms.Button();
            this.lblGorunus = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblKatman = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblElementAdi = new System.Windows.Forms.Label();
            this.lblMaddeninHali = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblElektron = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNotron = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProton = new System.Windows.Forms.Label();
            this.lblEvrendekiYeri = new System.Windows.Forms.Label();
            this.lblAtomSembolu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIzotop = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAtomNumarasi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPeriyot = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblElementSerisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnForm1eGec = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoster)).BeginInit();
            this.gboxElement.SuspendLayout();
            this.pElement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(875, 3);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(244, 16);
            this.lbl1.TabIndex = 341;
            this.lbl1.Text = "Dilerseniz PeriyodikTabloya Geçebilirsiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 339;
            this.label3.Text = "PERİYODİK VERİ İŞLEMLERİ";
            // 
            // dgvGoster
            // 
            this.dgvGoster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoster.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoster.Location = new System.Drawing.Point(6, 136);
            this.dgvGoster.Name = "dgvGoster";
            this.dgvGoster.Size = new System.Drawing.Size(1174, 436);
            this.dgvGoster.TabIndex = 338;
            this.dgvGoster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoster_CellContentClick);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(9, 37);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(108, 22);
            this.txtAra.TabIndex = 335;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // tmrKayanYazi
            // 
            this.tmrKayanYazi.Enabled = true;
            this.tmrKayanYazi.Interval = 1000;
            // 
            // gboxElement
            // 
            this.gboxElement.Controls.Add(this.label16);
            this.gboxElement.Controls.Add(this.label1);
            this.gboxElement.Controls.Add(this.cboxGrub);
            this.gboxElement.Controls.Add(this.txtAra);
            this.gboxElement.Controls.Add(this.btnAra);
            this.gboxElement.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxElement.Location = new System.Drawing.Point(0, 3);
            this.gboxElement.Name = "gboxElement";
            this.gboxElement.Size = new System.Drawing.Size(868, 111);
            this.gboxElement.TabIndex = 343;
            this.gboxElement.TabStop = false;
            this.gboxElement.Text = "ELEMENT ARAMA ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 15);
            this.label16.TabIndex = 350;
            this.label16.Text = "Element Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 349;
            this.label1.Text = "Grubuna Göre Arama";
            // 
            // cboxGrub
            // 
            this.cboxGrub.FormattingEnabled = true;
            this.cboxGrub.Items.AddRange(new object[] {
            "Grubuna Göre Arama",
            "DİĞER METAL",
            "HOLOJENLER",
            "SOYGAZLAR",
            "YARI METAL",
            "GEÇİŞ METALLERİ",
            "ALKALİ METALLER",
            "ALKALİ TOPRAK METALLERİ",
            "ARA GEÇİŞ METALLERİ ",
            "KATI ",
            "SIVI",
            "GAZ",
            "YAPAY"});
            this.cboxGrub.Location = new System.Drawing.Point(9, 80);
            this.cboxGrub.Name = "cboxGrub";
            this.cboxGrub.Size = new System.Drawing.Size(143, 23);
            this.cboxGrub.TabIndex = 348;
            this.cboxGrub.SelectedIndexChanged += new System.EventHandler(this.cboxGrub_SelectedIndexChanged);
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = global::PeriyodikTablo.Properties.Resources.Arama;
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Location = new System.Drawing.Point(123, 29);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(29, 30);
            this.btnAra.TabIndex = 336;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::PeriyodikTablo.Properties.Resources.TEMIZLEYEBILIRSIN;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Location = new System.Drawing.Point(878, 72);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(35, 33);
            this.btnTemizle.TabIndex = 345;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHepsiniGoster
            // 
            this.btnHepsiniGoster.BackgroundImage = global::PeriyodikTablo.Properties.Resources.cetttt;
            this.btnHepsiniGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHepsiniGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHepsiniGoster.Location = new System.Drawing.Point(878, 24);
            this.btnHepsiniGoster.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnHepsiniGoster.Name = "btnHepsiniGoster";
            this.btnHepsiniGoster.Size = new System.Drawing.Size(35, 35);
            this.btnHepsiniGoster.TabIndex = 344;
            this.btnHepsiniGoster.UseVisualStyleBackColor = true;
            this.btnHepsiniGoster.Click += new System.EventHandler(this.btnHepsiniGoster_Click);
            // 
            // pElement
            // 
            this.pElement.BackgroundImage = global::PeriyodikTablo.Properties.Resources.ArkaRenk;
            this.pElement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pElement.Controls.Add(this.btnPanelCikis);
            this.pElement.Controls.Add(this.btnKapatt);
            this.pElement.Controls.Add(this.lblGorunus);
            this.pElement.Controls.Add(this.label13);
            this.pElement.Controls.Add(this.lblKatman);
            this.pElement.Controls.Add(this.label9);
            this.pElement.Controls.Add(this.lblElementAdi);
            this.pElement.Controls.Add(this.lblMaddeninHali);
            this.pElement.Controls.Add(this.label15);
            this.pElement.Controls.Add(this.lblElektron);
            this.pElement.Controls.Add(this.label12);
            this.pElement.Controls.Add(this.lblNotron);
            this.pElement.Controls.Add(this.label7);
            this.pElement.Controls.Add(this.label5);
            this.pElement.Controls.Add(this.lblProton);
            this.pElement.Controls.Add(this.lblEvrendekiYeri);
            this.pElement.Controls.Add(this.lblAtomSembolu);
            this.pElement.Controls.Add(this.label11);
            this.pElement.Controls.Add(this.label10);
            this.pElement.Controls.Add(this.lblIzotop);
            this.pElement.Controls.Add(this.label8);
            this.pElement.Controls.Add(this.lblAtomNumarasi);
            this.pElement.Controls.Add(this.label6);
            this.pElement.Controls.Add(this.lblPeriyot);
            this.pElement.Controls.Add(this.label4);
            this.pElement.Controls.Add(this.lblElementSerisi);
            this.pElement.Controls.Add(this.label2);
            this.pElement.Controls.Add(this.label14);
            this.pElement.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pElement.Location = new System.Drawing.Point(1125, 47);
            this.pElement.Name = "pElement";
            this.pElement.Size = new System.Drawing.Size(10, 10);
            this.pElement.TabIndex = 342;
            this.pElement.Visible = false;
            // 
            // btnPanelCikis
            // 
            this.btnPanelCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnPanelCikis.BackgroundImage = global::PeriyodikTablo.Properties.Resources.Cikis;
            this.btnPanelCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPanelCikis.FlatAppearance.BorderSize = 0;
            this.btnPanelCikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPanelCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPanelCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelCikis.Location = new System.Drawing.Point(480, 3);
            this.btnPanelCikis.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPanelCikis.Name = "btnPanelCikis";
            this.btnPanelCikis.Size = new System.Drawing.Size(38, 29);
            this.btnPanelCikis.TabIndex = 32;
            this.btnPanelCikis.UseVisualStyleBackColor = false;
            this.btnPanelCikis.Click += new System.EventHandler(this.btnPanelCikis_Click);
            // 
            // btnKapatt
            // 
            this.btnKapatt.BackColor = System.Drawing.Color.Transparent;
            this.btnKapatt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapatt.FlatAppearance.BorderSize = 0;
            this.btnKapatt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKapatt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKapatt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapatt.Location = new System.Drawing.Point(824, 2);
            this.btnKapatt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKapatt.Name = "btnKapatt";
            this.btnKapatt.Size = new System.Drawing.Size(33, 36);
            this.btnKapatt.TabIndex = 30;
            this.btnKapatt.UseVisualStyleBackColor = false;
            // 
            // lblGorunus
            // 
            this.lblGorunus.AutoSize = true;
            this.lblGorunus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorunus.Location = new System.Drawing.Point(174, 175);
            this.lblGorunus.Name = "lblGorunus";
            this.lblGorunus.Size = new System.Drawing.Size(17, 19);
            this.lblGorunus.TabIndex = 28;
            this.lblGorunus.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(7, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "GÖRÜNÜŞÜ:";
            // 
            // lblKatman
            // 
            this.lblKatman.AutoSize = true;
            this.lblKatman.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKatman.Location = new System.Drawing.Point(175, 404);
            this.lblKatman.Name = "lblKatman";
            this.lblKatman.Size = new System.Drawing.Size(17, 19);
            this.lblKatman.TabIndex = 26;
            this.lblKatman.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(7, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "KATMAN SAYISI:";
            // 
            // lblElementAdi
            // 
            this.lblElementAdi.AutoSize = true;
            this.lblElementAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblElementAdi.Location = new System.Drawing.Point(180, 9);
            this.lblElementAdi.Name = "lblElementAdi";
            this.lblElementAdi.Size = new System.Drawing.Size(17, 19);
            this.lblElementAdi.TabIndex = 24;
            this.lblElementAdi.Text = "0";
            // 
            // lblMaddeninHali
            // 
            this.lblMaddeninHali.AutoSize = true;
            this.lblMaddeninHali.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaddeninHali.Location = new System.Drawing.Point(173, 373);
            this.lblMaddeninHali.Name = "lblMaddeninHali";
            this.lblMaddeninHali.Size = new System.Drawing.Size(17, 19);
            this.lblMaddeninHali.TabIndex = 23;
            this.lblMaddeninHali.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(7, 373);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 19);
            this.label15.TabIndex = 22;
            this.label15.Text = "MADDENİN HALİ:";
            // 
            // lblElektron
            // 
            this.lblElektron.AutoSize = true;
            this.lblElektron.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblElektron.Location = new System.Drawing.Point(175, 343);
            this.lblElektron.Name = "lblElektron";
            this.lblElektron.Size = new System.Drawing.Size(17, 19);
            this.lblElektron.TabIndex = 21;
            this.lblElektron.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(4, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "ELEKTRON SAYISI:";
            // 
            // lblNotron
            // 
            this.lblNotron.AutoSize = true;
            this.lblNotron.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNotron.Location = new System.Drawing.Point(174, 302);
            this.lblNotron.Name = "lblNotron";
            this.lblNotron.Size = new System.Drawing.Size(17, 19);
            this.lblNotron.TabIndex = 19;
            this.lblNotron.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(4, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "NÖTRON SAYISI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "PROTON SAYISI:";
            // 
            // lblProton
            // 
            this.lblProton.AutoSize = true;
            this.lblProton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProton.Location = new System.Drawing.Point(175, 244);
            this.lblProton.Name = "lblProton";
            this.lblProton.Size = new System.Drawing.Size(17, 19);
            this.lblProton.TabIndex = 16;
            this.lblProton.Text = "0";
            // 
            // lblEvrendekiYeri
            // 
            this.lblEvrendekiYeri.AutoSize = true;
            this.lblEvrendekiYeri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvrendekiYeri.Location = new System.Drawing.Point(173, 208);
            this.lblEvrendekiYeri.Name = "lblEvrendekiYeri";
            this.lblEvrendekiYeri.Size = new System.Drawing.Size(17, 19);
            this.lblEvrendekiYeri.TabIndex = 15;
            this.lblEvrendekiYeri.Text = "0";
            // 
            // lblAtomSembolu
            // 
            this.lblAtomSembolu.AutoSize = true;
            this.lblAtomSembolu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAtomSembolu.Location = new System.Drawing.Point(176, 139);
            this.lblAtomSembolu.Name = "lblAtomSembolu";
            this.lblAtomSembolu.Size = new System.Drawing.Size(17, 19);
            this.lblAtomSembolu.TabIndex = 12;
            this.lblAtomSembolu.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(4, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "EVRENDEKİ YERİ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(7, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "İZOTOP:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIzotop
            // 
            this.lblIzotop.AutoSize = true;
            this.lblIzotop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIzotop.Location = new System.Drawing.Point(174, 273);
            this.lblIzotop.Name = "lblIzotop";
            this.lblIzotop.Size = new System.Drawing.Size(13, 19);
            this.lblIzotop.TabIndex = 9;
            this.lblIzotop.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(7, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "SEMBOLÜ:";
            // 
            // lblAtomNumarasi
            // 
            this.lblAtomNumarasi.AutoSize = true;
            this.lblAtomNumarasi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAtomNumarasi.Location = new System.Drawing.Point(177, 107);
            this.lblAtomNumarasi.Name = "lblAtomNumarasi";
            this.lblAtomNumarasi.Size = new System.Drawing.Size(17, 19);
            this.lblAtomNumarasi.TabIndex = 7;
            this.lblAtomNumarasi.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "ATOM NUMARASI:";
            // 
            // lblPeriyot
            // 
            this.lblPeriyot.AutoSize = true;
            this.lblPeriyot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPeriyot.Location = new System.Drawing.Point(180, 76);
            this.lblPeriyot.Name = "lblPeriyot";
            this.lblPeriyot.Size = new System.Drawing.Size(17, 19);
            this.lblPeriyot.TabIndex = 5;
            this.lblPeriyot.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "GRUP ,BLOK,PERİYOT:";
            // 
            // lblElementSerisi
            // 
            this.lblElementSerisi.AutoSize = true;
            this.lblElementSerisi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblElementSerisi.Location = new System.Drawing.Point(177, 44);
            this.lblElementSerisi.Name = "lblElementSerisi";
            this.lblElementSerisi.Size = new System.Drawing.Size(17, 19);
            this.lblElementSerisi.TabIndex = 2;
            this.lblElementSerisi.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ELEMENTİN SERİSİ:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(3, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "ELEMENTİN ADI:";
            // 
            // btnForm1eGec
            // 
            this.btnForm1eGec.BackgroundImage = global::PeriyodikTablo.Properties.Resources.cetvel;
            this.btnForm1eGec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnForm1eGec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm1eGec.Location = new System.Drawing.Point(922, 24);
            this.btnForm1eGec.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnForm1eGec.Name = "btnForm1eGec";
            this.btnForm1eGec.Size = new System.Drawing.Size(197, 83);
            this.btnForm1eGec.TabIndex = 340;
            this.btnForm1eGec.UseVisualStyleBackColor = true;
            this.btnForm1eGec.Click += new System.EventHandler(this.btnForm1eGec_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::PeriyodikTablo.Properties.Resources.Cikis;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(1142, 2);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(38, 29);
            this.btnCikis.TabIndex = 337;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1183, 591);
            this.ControlBox = false;
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHepsiniGoster);
            this.Controls.Add(this.gboxElement);
            this.Controls.Add(this.pElement);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnForm1eGec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvGoster);
            this.Controls.Add(this.btnCikis);
            this.Name = "Form2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoster)).EndInit();
            this.gboxElement.ResumeLayout(false);
            this.gboxElement.PerformLayout();
            this.pElement.ResumeLayout(false);
            this.pElement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pElement;
        private System.Windows.Forms.Button btnPanelCikis;
        private System.Windows.Forms.Button btnKapatt;
        private System.Windows.Forms.Label lblGorunus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblKatman;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblElementAdi;
        private System.Windows.Forms.Label lblMaddeninHali;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblElektron;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNotron;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProton;
        private System.Windows.Forms.Label lblEvrendekiYeri;
        private System.Windows.Forms.Label lblAtomSembolu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblIzotop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAtomNumarasi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPeriyot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblElementSerisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnForm1eGec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvGoster;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Timer tmrKayanYazi;
        private System.Windows.Forms.GroupBox gboxElement;
        private System.Windows.Forms.Button btnHepsiniGoster;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxGrub;
    }
}