namespace Staff_Management_System
{
    partial class frmMain
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstbPersonelGoster = new System.Windows.Forms.ListBox();
            this.txtbId = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbSurname = new System.Windows.Forms.TextBox();
            this.txtbAddres = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.cmbDeneyim = new System.Windows.Forms.ComboBox();
            this.lblDeneyim = new System.Windows.Forms.Label();
            this.lblYönetici = new System.Windows.Forms.Label();
            this.lblAkademik = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.cmbAkademik = new System.Windows.Forms.ComboBox();
            this.cmbYönetici = new System.Windows.Forms.ComboBox();
            this.chkbDil1 = new System.Windows.Forms.CheckBox();
            this.chkbDil2 = new System.Windows.Forms.CheckBox();
            this.chkbDil3 = new System.Windows.Forms.CheckBox();
            this.lblDil = new System.Windows.Forms.Label();
            this.cmbDil = new System.Windows.Forms.ComboBox();
            this.grpbDil = new System.Windows.Forms.GroupBox();
            this.lblDilSayisi = new System.Windows.Forms.Label();
            this.txtbDilSayisi = new System.Windows.Forms.TextBox();
            this.lblAile = new System.Windows.Forms.Label();
            this.cmbAile = new System.Windows.Forms.ComboBox();
            this.grpbCocukSayisi = new System.Windows.Forms.GroupBox();
            this.chkbCocukYok = new System.Windows.Forms.CheckBox();
            this.chkb2veFazla = new System.Windows.Forms.CheckBox();
            this.chkb1cocuk = new System.Windows.Forms.CheckBox();
            this.lblcocuk = new System.Windows.Forms.Label();
            this.grpbYasAraligi = new System.Windows.Forms.GroupBox();
            this.txtb18CocukSayisi = new System.Windows.Forms.TextBox();
            this.txtb718CocukSayisi = new System.Windows.Forms.TextBox();
            this.txtb06CocukSayisi = new System.Windows.Forms.TextBox();
            this.lbl18CocukSayisi = new System.Windows.Forms.Label();
            this.lbl718CocukSayisi = new System.Windows.Forms.Label();
            this.lbl06CocukSayisi = new System.Windows.Forms.Label();
            this.chkb18 = new System.Windows.Forms.CheckBox();
            this.chkb718 = new System.Windows.Forms.CheckBox();
            this.chkb06 = new System.Windows.Forms.CheckBox();
            this.chkbEvli = new System.Windows.Forms.CheckBox();
            this.lblYasAraligi = new System.Windows.Forms.Label();
            this.grpbDil.SuspendLayout();
            this.grpbCocukSayisi.SuspendLayout();
            this.grpbYasAraligi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(871, 38);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 35);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(871, 120);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 35);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(871, 79);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 35);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstbPersonelGoster
            // 
            this.lstbPersonelGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbPersonelGoster.FormattingEnabled = true;
            this.lstbPersonelGoster.ItemHeight = 25;
            this.lstbPersonelGoster.Location = new System.Drawing.Point(12, 44);
            this.lstbPersonelGoster.Name = "lstbPersonelGoster";
            this.lstbPersonelGoster.Size = new System.Drawing.Size(468, 429);
            this.lstbPersonelGoster.TabIndex = 9;
            // 
            // txtbId
            // 
            this.txtbId.Location = new System.Drawing.Point(673, 44);
            this.txtbId.Name = "txtbId";
            this.txtbId.Size = new System.Drawing.Size(149, 22);
            this.txtbId.TabIndex = 10;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(673, 87);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(149, 22);
            this.txtbName.TabIndex = 12;
            // 
            // txtbSurname
            // 
            this.txtbSurname.Location = new System.Drawing.Point(673, 130);
            this.txtbSurname.Name = "txtbSurname";
            this.txtbSurname.Size = new System.Drawing.Size(149, 22);
            this.txtbSurname.TabIndex = 13;
            // 
            // txtbAddres
            // 
            this.txtbAddres.Location = new System.Drawing.Point(673, 172);
            this.txtbAddres.Name = "txtbAddres";
            this.txtbAddres.Size = new System.Drawing.Size(149, 22);
            this.txtbAddres.TabIndex = 14;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(584, 47);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 17);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "İD";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(580, 90);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 17);
            this.lblAd.TabIndex = 16;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(557, 133);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(48, 17);
            this.lblSoyad.TabIndex = 17;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(560, 175);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(45, 17);
            this.lblAdres.TabIndex = 18;
            this.lblAdres.Text = "Adres";
            // 
            // cmbDeneyim
            // 
            this.cmbDeneyim.FormattingEnabled = true;
            this.cmbDeneyim.Items.AddRange(new object[] {
            "0-2",
            "2-4",
            "5-9",
            "10-14",
            "15-20",
            "20 yıl üstü"});
            this.cmbDeneyim.Location = new System.Drawing.Point(673, 214);
            this.cmbDeneyim.Name = "cmbDeneyim";
            this.cmbDeneyim.Size = new System.Drawing.Size(149, 24);
            this.cmbDeneyim.TabIndex = 20;
            // 
            // lblDeneyim
            // 
            this.lblDeneyim.AutoSize = true;
            this.lblDeneyim.Location = new System.Drawing.Point(498, 217);
            this.lblDeneyim.Name = "lblDeneyim";
            this.lblDeneyim.Size = new System.Drawing.Size(107, 17);
            this.lblDeneyim.TabIndex = 21;
            this.lblDeneyim.Text = "Deneyim Süresi";
            // 
            // lblYönetici
            // 
            this.lblYönetici.AutoSize = true;
            this.lblYönetici.Location = new System.Drawing.Point(489, 337);
            this.lblYönetici.Name = "lblYönetici";
            this.lblYönetici.Size = new System.Drawing.Size(117, 17);
            this.lblYönetici.TabIndex = 23;
            this.lblYönetici.Text = "Yöneticilik Görevi";
            // 
            // lblAkademik
            // 
            this.lblAkademik.AutoSize = true;
            this.lblAkademik.Location = new System.Drawing.Point(486, 301);
            this.lblAkademik.Name = "lblAkademik";
            this.lblAkademik.Size = new System.Drawing.Size(119, 17);
            this.lblAkademik.TabIndex = 25;
            this.lblAkademik.Text = "Akademik Derece";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(526, 258);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(80, 17);
            this.lblSehir.TabIndex = 26;
            this.lblSehir.Text = "Yaşanılan İl";
            // 
            // cmbSehir
            // 
            this.cmbSehir.DropDownWidth = 250;
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Kocaeli, Sakarya, Düzce, Bolu, Yalova",
            "Edirne, Kırklareli, Tekirdağ",
            "Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane",
            "Bursa, Eskişehir, Bilecik",
            "Aydın, Denizli, Muğla",
            "Adana, Mersin",
            "Balıkesir, Çanakkale",
            "Antalya, Isparta, Burdur",
            "Diğer İller"});
            this.cmbSehir.Location = new System.Drawing.Point(673, 255);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(149, 24);
            this.cmbSehir.TabIndex = 27;
            // 
            // cmbAkademik
            // 
            this.cmbAkademik.DropDownWidth = 250;
            this.cmbAkademik.FormattingEnabled = true;
            this.cmbAkademik.Items.AddRange(new object[] {
            "Meslek alanı ile ilgili yüksek lisans",
            "Meslek alanı ile ilgili doktora",
            "Meslek alanı ile ilgili doçentlik",
            "Meslek alanı ile ilgili olmayan yüksek lisans",
            "Meslek alanı ile ilgili olmayan doktora/doçentlik"});
            this.cmbAkademik.Location = new System.Drawing.Point(673, 294);
            this.cmbAkademik.Name = "cmbAkademik";
            this.cmbAkademik.Size = new System.Drawing.Size(149, 24);
            this.cmbAkademik.TabIndex = 28;
            // 
            // cmbYönetici
            // 
            this.cmbYönetici.DropDownWidth = 400;
            this.cmbYönetici.FormattingEnabled = true;
            this.cmbYönetici.Items.AddRange(new object[] {
            "Takım Lideri/Grup Yöneticisi/Teknik Yönetici/Yazılım Mimarı",
            "Proje Yöneticisi",
            "Direktör/Projeler Yöneticisi",
            "CTO/Genel Müdür",
            "Bilgi İşlem Sorumlusu/Müdürü (Bilgi İşlem biriminde en çok 5 bilişim personeli va" +
                "rsa)",
            "Bilgi İşlem Sorumlusu/Müdürü (Bilgi İşlem biriminde 5\'ten çok bilişim personeli v" +
                "arsa)"});
            this.cmbYönetici.Location = new System.Drawing.Point(673, 334);
            this.cmbYönetici.Name = "cmbYönetici";
            this.cmbYönetici.Size = new System.Drawing.Size(149, 24);
            this.cmbYönetici.TabIndex = 30;
            // 
            // chkbDil1
            // 
            this.chkbDil1.AutoSize = true;
            this.chkbDil1.Location = new System.Drawing.Point(6, 21);
            this.chkbDil1.Name = "chkbDil1";
            this.chkbDil1.Size = new System.Drawing.Size(225, 21);
            this.chkbDil1.TabIndex = 31;
            this.chkbDil1.Text = "Belgelendirilmiş İngilizce bilgisi ";
            this.chkbDil1.UseVisualStyleBackColor = true;
            // 
            // chkbDil2
            // 
            this.chkbDil2.AutoSize = true;
            this.chkbDil2.Location = new System.Drawing.Point(6, 51);
            this.chkbDil2.Name = "chkbDil2";
            this.chkbDil2.Size = new System.Drawing.Size(262, 21);
            this.chkbDil2.TabIndex = 32;
            this.chkbDil2.Text = "İngilizce eğitim veren okul mezuniyeti";
            this.chkbDil2.UseVisualStyleBackColor = true;
            // 
            // chkbDil3
            // 
            this.chkbDil3.AutoSize = true;
            this.chkbDil3.Location = new System.Drawing.Point(6, 78);
            this.chkbDil3.Name = "chkbDil3";
            this.chkbDil3.Size = new System.Drawing.Size(274, 21);
            this.chkbDil3.TabIndex = 33;
            this.chkbDil3.Text = "Belgelendirilmiş diğer yabancı dil bilgisi";
            this.chkbDil3.UseVisualStyleBackColor = true;
            // 
            // lblDil
            // 
            this.lblDil.AutoSize = true;
            this.lblDil.Location = new System.Drawing.Point(526, 375);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(79, 17);
            this.lblDil.TabIndex = 35;
            this.lblDil.Text = "Yabanci Dil";
            // 
            // cmbDil
            // 
            this.cmbDil.FormattingEnabled = true;
            this.cmbDil.Items.AddRange(new object[] {
            "Var",
            "Yok"});
            this.cmbDil.Location = new System.Drawing.Point(673, 372);
            this.cmbDil.Name = "cmbDil";
            this.cmbDil.Size = new System.Drawing.Size(149, 24);
            this.cmbDil.TabIndex = 36;
            this.cmbDil.SelectedIndexChanged += new System.EventHandler(this.cmbDil_SelectedIndexChanged);
            // 
            // grpbDil
            // 
            this.grpbDil.Controls.Add(this.lblDilSayisi);
            this.grpbDil.Controls.Add(this.txtbDilSayisi);
            this.grpbDil.Controls.Add(this.chkbDil1);
            this.grpbDil.Controls.Add(this.chkbDil2);
            this.grpbDil.Controls.Add(this.chkbDil3);
            this.grpbDil.Location = new System.Drawing.Point(828, 255);
            this.grpbDil.Name = "grpbDil";
            this.grpbDil.Size = new System.Drawing.Size(330, 146);
            this.grpbDil.TabIndex = 37;
            this.grpbDil.TabStop = false;
            this.grpbDil.Visible = false;
            // 
            // lblDilSayisi
            // 
            this.lblDilSayisi.AutoSize = true;
            this.lblDilSayisi.Location = new System.Drawing.Point(6, 118);
            this.lblDilSayisi.Name = "lblDilSayisi";
            this.lblDilSayisi.Size = new System.Drawing.Size(224, 17);
            this.lblDilSayisi.TabIndex = 35;
            this.lblDilSayisi.Text = "Belgelendirilmiş  yabancı dil sayisi:";
            // 
            // txtbDilSayisi
            // 
            this.txtbDilSayisi.Location = new System.Drawing.Point(236, 118);
            this.txtbDilSayisi.Name = "txtbDilSayisi";
            this.txtbDilSayisi.Size = new System.Drawing.Size(50, 22);
            this.txtbDilSayisi.TabIndex = 34;
            // 
            // lblAile
            // 
            this.lblAile.AutoSize = true;
            this.lblAile.Location = new System.Drawing.Point(521, 414);
            this.lblAile.Name = "lblAile";
            this.lblAile.Size = new System.Drawing.Size(85, 17);
            this.lblAile.TabIndex = 38;
            this.lblAile.Text = "Aile Durumu";
            // 
            // cmbAile
            // 
            this.cmbAile.FormattingEnabled = true;
            this.cmbAile.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.cmbAile.Location = new System.Drawing.Point(673, 411);
            this.cmbAile.Name = "cmbAile";
            this.cmbAile.Size = new System.Drawing.Size(149, 24);
            this.cmbAile.TabIndex = 39;
            this.cmbAile.SelectedIndexChanged += new System.EventHandler(this.cmbAile_SelectedIndexChanged);
            // 
            // grpbCocukSayisi
            // 
            this.grpbCocukSayisi.Controls.Add(this.chkbCocukYok);
            this.grpbCocukSayisi.Controls.Add(this.chkb2veFazla);
            this.grpbCocukSayisi.Controls.Add(this.chkb1cocuk);
            this.grpbCocukSayisi.Controls.Add(this.lblcocuk);
            this.grpbCocukSayisi.Location = new System.Drawing.Point(634, 451);
            this.grpbCocukSayisi.Name = "grpbCocukSayisi";
            this.grpbCocukSayisi.Size = new System.Drawing.Size(188, 118);
            this.grpbCocukSayisi.TabIndex = 40;
            this.grpbCocukSayisi.TabStop = false;
            this.grpbCocukSayisi.Visible = false;
            // 
            // chkbCocukYok
            // 
            this.chkbCocukYok.AutoSize = true;
            this.chkbCocukYok.Location = new System.Drawing.Point(10, 46);
            this.chkbCocukYok.Name = "chkbCocukYok";
            this.chkbCocukYok.Size = new System.Drawing.Size(97, 21);
            this.chkbCocukYok.TabIndex = 3;
            this.chkbCocukYok.Text = "Cocuk Yok";
            this.chkbCocukYok.UseVisualStyleBackColor = true;
            // 
            // chkb2veFazla
            // 
            this.chkb2veFazla.AutoSize = true;
            this.chkb2veFazla.Location = new System.Drawing.Point(10, 100);
            this.chkb2veFazla.Name = "chkb2veFazla";
            this.chkb2veFazla.Size = new System.Drawing.Size(172, 21);
            this.chkb2veFazla.TabIndex = 2;
            this.chkb2veFazla.Text = "2 Cocuk ve Daha fazla";
            this.chkb2veFazla.UseVisualStyleBackColor = true;
            // 
            // chkb1cocuk
            // 
            this.chkb1cocuk.AutoSize = true;
            this.chkb1cocuk.Location = new System.Drawing.Point(10, 73);
            this.chkb1cocuk.Name = "chkb1cocuk";
            this.chkb1cocuk.Size = new System.Drawing.Size(81, 21);
            this.chkb1cocuk.TabIndex = 1;
            this.chkb1cocuk.Text = "1 Cocuk";
            this.chkb1cocuk.UseVisualStyleBackColor = true;
            // 
            // lblcocuk
            // 
            this.lblcocuk.AutoSize = true;
            this.lblcocuk.Location = new System.Drawing.Point(7, 22);
            this.lblcocuk.Name = "lblcocuk";
            this.lblcocuk.Size = new System.Drawing.Size(90, 17);
            this.lblcocuk.TabIndex = 0;
            this.lblcocuk.Text = "Cocuk sayisi:";
            // 
            // grpbYasAraligi
            // 
            this.grpbYasAraligi.Controls.Add(this.txtb18CocukSayisi);
            this.grpbYasAraligi.Controls.Add(this.txtb718CocukSayisi);
            this.grpbYasAraligi.Controls.Add(this.txtb06CocukSayisi);
            this.grpbYasAraligi.Controls.Add(this.lbl18CocukSayisi);
            this.grpbYasAraligi.Controls.Add(this.lbl718CocukSayisi);
            this.grpbYasAraligi.Controls.Add(this.lbl06CocukSayisi);
            this.grpbYasAraligi.Controls.Add(this.chkb18);
            this.grpbYasAraligi.Controls.Add(this.chkb718);
            this.grpbYasAraligi.Controls.Add(this.chkb06);
            this.grpbYasAraligi.Controls.Add(this.chkbEvli);
            this.grpbYasAraligi.Controls.Add(this.lblYasAraligi);
            this.grpbYasAraligi.Location = new System.Drawing.Point(828, 438);
            this.grpbYasAraligi.Name = "grpbYasAraligi";
            this.grpbYasAraligi.Size = new System.Drawing.Size(389, 171);
            this.grpbYasAraligi.TabIndex = 41;
            this.grpbYasAraligi.TabStop = false;
            this.grpbYasAraligi.Visible = false;
            // 
            // txtb18CocukSayisi
            // 
            this.txtb18CocukSayisi.Location = new System.Drawing.Point(303, 127);
            this.txtb18CocukSayisi.Name = "txtb18CocukSayisi";
            this.txtb18CocukSayisi.Size = new System.Drawing.Size(62, 22);
            this.txtb18CocukSayisi.TabIndex = 10;
            // 
            // txtb718CocukSayisi
            // 
            this.txtb718CocukSayisi.Location = new System.Drawing.Point(283, 82);
            this.txtb718CocukSayisi.Name = "txtb718CocukSayisi";
            this.txtb718CocukSayisi.Size = new System.Drawing.Size(62, 22);
            this.txtb718CocukSayisi.TabIndex = 9;
            // 
            // txtb06CocukSayisi
            // 
            this.txtb06CocukSayisi.Location = new System.Drawing.Point(283, 55);
            this.txtb06CocukSayisi.Name = "txtb06CocukSayisi";
            this.txtb06CocukSayisi.Size = new System.Drawing.Size(62, 22);
            this.txtb06CocukSayisi.TabIndex = 8;
            // 
            // lbl18CocukSayisi
            // 
            this.lbl18CocukSayisi.AutoSize = true;
            this.lbl18CocukSayisi.Location = new System.Drawing.Point(205, 127);
            this.lbl18CocukSayisi.Name = "lbl18CocukSayisi";
            this.lbl18CocukSayisi.Size = new System.Drawing.Size(92, 17);
            this.lbl18CocukSayisi.TabIndex = 7;
            this.lbl18CocukSayisi.Text = "Cocuk Sayisi:";
            // 
            // lbl718CocukSayisi
            // 
            this.lbl718CocukSayisi.AutoSize = true;
            this.lbl718CocukSayisi.Location = new System.Drawing.Point(177, 82);
            this.lbl718CocukSayisi.Name = "lbl718CocukSayisi";
            this.lbl718CocukSayisi.Size = new System.Drawing.Size(92, 17);
            this.lbl718CocukSayisi.TabIndex = 6;
            this.lbl718CocukSayisi.Text = "Cocuk Sayisi:";
            // 
            // lbl06CocukSayisi
            // 
            this.lbl06CocukSayisi.AutoSize = true;
            this.lbl06CocukSayisi.Location = new System.Drawing.Point(177, 57);
            this.lbl06CocukSayisi.Name = "lbl06CocukSayisi";
            this.lbl06CocukSayisi.Size = new System.Drawing.Size(92, 17);
            this.lbl06CocukSayisi.TabIndex = 5;
            this.lbl06CocukSayisi.Text = "Cocuk Sayisi:";
            // 
            // chkb18
            // 
            this.chkb18.AutoSize = true;
            this.chkb18.Location = new System.Drawing.Point(6, 109);
            this.chkb18.Name = "chkb18";
            this.chkb18.Size = new System.Drawing.Size(200, 55);
            this.chkb18.TabIndex = 4;
            this.chkb18.Text = "18 yaş üstü çocuk\r\n(Üniversite lisans/ön lisans\r\n öğrencisi olmak koşuluyla)";
            this.chkb18.UseVisualStyleBackColor = true;
            // 
            // chkb718
            // 
            this.chkb718.AutoSize = true;
            this.chkb718.Location = new System.Drawing.Point(10, 82);
            this.chkb718.Name = "chkb718";
            this.chkb718.Size = new System.Drawing.Size(165, 21);
            this.chkb718.TabIndex = 3;
            this.chkb718.Text = "7-18 yaş arası çocuk ";
            this.chkb718.UseVisualStyleBackColor = true;
            // 
            // chkb06
            // 
            this.chkb06.AutoSize = true;
            this.chkb06.Location = new System.Drawing.Point(10, 57);
            this.chkb06.Name = "chkb06";
            this.chkb06.Size = new System.Drawing.Size(157, 21);
            this.chkb06.TabIndex = 2;
            this.chkb06.Text = "0-6 yaş arası çocuk ";
            this.chkb06.UseVisualStyleBackColor = true;
            // 
            // chkbEvli
            // 
            this.chkbEvli.AutoSize = true;
            this.chkbEvli.Location = new System.Drawing.Point(10, 34);
            this.chkbEvli.Name = "chkbEvli";
            this.chkbEvli.Size = new System.Drawing.Size(159, 21);
            this.chkbEvli.TabIndex = 1;
            this.chkbEvli.Text = "Evli ve eşi çalışmıyor";
            this.chkbEvli.UseVisualStyleBackColor = true;
            // 
            // lblYasAraligi
            // 
            this.lblYasAraligi.AutoSize = true;
            this.lblYasAraligi.Location = new System.Drawing.Point(7, 13);
            this.lblYasAraligi.Name = "lblYasAraligi";
            this.lblYasAraligi.Size = new System.Drawing.Size(79, 17);
            this.lblYasAraligi.TabIndex = 0;
            this.lblYasAraligi.Text = "Yas Araligi:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 638);
            this.Controls.Add(this.grpbYasAraligi);
            this.Controls.Add(this.grpbCocukSayisi);
            this.Controls.Add(this.cmbAile);
            this.Controls.Add(this.lblAile);
            this.Controls.Add(this.grpbDil);
            this.Controls.Add(this.cmbDil);
            this.Controls.Add(this.lblDil);
            this.Controls.Add(this.cmbYönetici);
            this.Controls.Add(this.cmbAkademik);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.lblAkademik);
            this.Controls.Add(this.lblYönetici);
            this.Controls.Add(this.lblDeneyim);
            this.Controls.Add(this.cmbDeneyim);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtbAddres);
            this.Controls.Add(this.txtbSurname);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.txtbId);
            this.Controls.Add(this.lstbPersonelGoster);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmMain";
            this.Text = "Personel Yönetim Sistemi";
            this.grpbDil.ResumeLayout(false);
            this.grpbDil.PerformLayout();
            this.grpbCocukSayisi.ResumeLayout(false);
            this.grpbCocukSayisi.PerformLayout();
            this.grpbYasAraligi.ResumeLayout(false);
            this.grpbYasAraligi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lstbPersonelGoster;
        private System.Windows.Forms.TextBox txtbId;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbSurname;
        private System.Windows.Forms.TextBox txtbAddres;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.ComboBox cmbDeneyim;
        private System.Windows.Forms.Label lblDeneyim;
        private System.Windows.Forms.Label lblYönetici;
        private System.Windows.Forms.Label lblAkademik;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.ComboBox cmbAkademik;
        private System.Windows.Forms.ComboBox cmbYönetici;
        private System.Windows.Forms.CheckBox chkbDil1;
        private System.Windows.Forms.CheckBox chkbDil2;
        private System.Windows.Forms.CheckBox chkbDil3;
        private System.Windows.Forms.Label lblDil;
        private System.Windows.Forms.ComboBox cmbDil;
        private System.Windows.Forms.GroupBox grpbDil;
        private System.Windows.Forms.Label lblDilSayisi;
        private System.Windows.Forms.TextBox txtbDilSayisi;
        private System.Windows.Forms.Label lblAile;
        private System.Windows.Forms.ComboBox cmbAile;
        private System.Windows.Forms.GroupBox grpbCocukSayisi;
        private System.Windows.Forms.CheckBox chkb2veFazla;
        private System.Windows.Forms.CheckBox chkb1cocuk;
        private System.Windows.Forms.Label lblcocuk;
        private System.Windows.Forms.GroupBox grpbYasAraligi;
        private System.Windows.Forms.CheckBox chkb18;
        private System.Windows.Forms.CheckBox chkb718;
        private System.Windows.Forms.CheckBox chkb06;
        private System.Windows.Forms.CheckBox chkbEvli;
        private System.Windows.Forms.Label lblYasAraligi;
        private System.Windows.Forms.CheckBox chkbCocukYok;
        private System.Windows.Forms.TextBox txtb18CocukSayisi;
        private System.Windows.Forms.TextBox txtb718CocukSayisi;
        private System.Windows.Forms.TextBox txtb06CocukSayisi;
        private System.Windows.Forms.Label lbl18CocukSayisi;
        private System.Windows.Forms.Label lbl718CocukSayisi;
        private System.Windows.Forms.Label lbl06CocukSayisi;
    }
}

