namespace Petrol_Otomasyon
{
    partial class dgvSubeler
    {
       
        private System.ComponentModel.IContainer components = null;

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

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSubeID = new System.Windows.Forms.Label();
            this.txtSubeID = new System.Windows.Forms.TextBox();
            this.lblSubeAdi = new System.Windows.Forms.Label();
            this.txtSubeAdi = new System.Windows.Forms.TextBox();
            this.lblSehir = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.lblFirmaID = new System.Windows.Forms.Label();
            this.txtFirmaID = new System.Windows.Forms.TextBox();
            this.lblSefID = new System.Windows.Forms.Label();
            this.txtSefID = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sefIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolOtomasyonDataSet = new Petrol_Otomasyon.petrolOtomasyonDataSet();
            this.subelerTableAdapter = new Petrol_Otomasyon.petrolOtomasyonDataSetTableAdapters.SubelerTableAdapter();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.btnpompa = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rezervIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anaRezervBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolOtomasyonDataSet3 = new Petrol_Otomasyon.petrolOtomasyonDataSet3();
            this.anaRezervTableAdapter = new Petrol_Otomasyon.petrolOtomasyonDataSet3TableAdapters.AnaRezervTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.depoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolOtomasyonDataSet4 = new Petrol_Otomasyon.petrolOtomasyonDataSet4();
            this.depoTableAdapter = new Petrol_Otomasyon.petrolOtomasyonDataSet4TableAdapters.DepoTableAdapter();
            this.petrolOtomasyonDataSet5 = new Petrol_Otomasyon.petrolOtomasyonDataSet5();
            this.rezervasyonlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervasyonlarTableAdapter = new Petrol_Otomasyon.petrolOtomasyonDataSet5TableAdapters.RezervasyonlarTableAdapter();
            this.dataGridViewpersonel = new System.Windows.Forms.DataGridView();
            this.rezervIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeAdiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervasyonlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.petrolOtomasyonDataSet6 = new Petrol_Otomasyon.petrolOtomasyonDataSet6();
            this.rezervasyonlarTableAdapter1 = new Petrol_Otomasyon.petrolOtomasyonDataSet6TableAdapters.RezervasyonlarTableAdapter();
            this.buttongirisyap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaRezervBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonlarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubeID
            // 
            this.lblSubeID.AutoSize = true;
            this.lblSubeID.Location = new System.Drawing.Point(26, 32);
            this.lblSubeID.Name = "lblSubeID";
            this.lblSubeID.Size = new System.Drawing.Size(46, 13);
            this.lblSubeID.TabIndex = 0;
            this.lblSubeID.Text = "Şube ID";
            // 
            // txtSubeID
            // 
            this.txtSubeID.Location = new System.Drawing.Point(78, 29);
            this.txtSubeID.Name = "txtSubeID";
            this.txtSubeID.Size = new System.Drawing.Size(156, 20);
            this.txtSubeID.TabIndex = 1;
            // 
            // lblSubeAdi
            // 
            this.lblSubeAdi.AutoSize = true;
            this.lblSubeAdi.Location = new System.Drawing.Point(22, 67);
            this.lblSubeAdi.Name = "lblSubeAdi";
            this.lblSubeAdi.Size = new System.Drawing.Size(50, 13);
            this.lblSubeAdi.TabIndex = 2;
            this.lblSubeAdi.Text = "Şube Adı";
            // 
            // txtSubeAdi
            // 
            this.txtSubeAdi.Location = new System.Drawing.Point(78, 64);
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.Size = new System.Drawing.Size(156, 20);
            this.txtSubeAdi.TabIndex = 3;
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(41, 100);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(31, 13);
            this.lblSehir.TabIndex = 4;
            this.lblSehir.Text = "Şehir";
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(78, 97);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(156, 20);
            this.txtSehir.TabIndex = 5;
            // 
            // lblFirmaID
            // 
            this.lblFirmaID.AutoSize = true;
            this.lblFirmaID.Location = new System.Drawing.Point(26, 133);
            this.lblFirmaID.Name = "lblFirmaID";
            this.lblFirmaID.Size = new System.Drawing.Size(46, 13);
            this.lblFirmaID.TabIndex = 6;
            this.lblFirmaID.Text = "Firma ID";
            // 
            // txtFirmaID
            // 
            this.txtFirmaID.Location = new System.Drawing.Point(78, 130);
            this.txtFirmaID.Name = "txtFirmaID";
            this.txtFirmaID.Size = new System.Drawing.Size(156, 20);
            this.txtFirmaID.TabIndex = 7;
            // 
            // lblSefID
            // 
            this.lblSefID.AutoSize = true;
            this.lblSefID.Location = new System.Drawing.Point(35, 169);
            this.lblSefID.Name = "lblSefID";
            this.lblSefID.Size = new System.Drawing.Size(37, 13);
            this.lblSefID.TabIndex = 8;
            this.lblSefID.Text = "Şef ID";
            // 
            // txtSefID
            // 
            this.txtSefID.Location = new System.Drawing.Point(78, 166);
            this.txtSefID.Name = "txtSefID";
            this.txtSefID.Size = new System.Drawing.Size(156, 20);
            this.txtSefID.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnEkle.Location = new System.Drawing.Point(78, 212);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(156, 37);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Şube Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(78, 277);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(156, 37);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Şube Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subeIDDataGridViewTextBoxColumn,
            this.subeAdiDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.firmaIDDataGridViewTextBoxColumn,
            this.sefIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subelerBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(271, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 160);
            this.dataGridView1.TabIndex = 12;
            // 
            // subeIDDataGridViewTextBoxColumn
            // 
            this.subeIDDataGridViewTextBoxColumn.DataPropertyName = "SubeID";
            this.subeIDDataGridViewTextBoxColumn.HeaderText = "SubeID";
            this.subeIDDataGridViewTextBoxColumn.Name = "subeIDDataGridViewTextBoxColumn";
            this.subeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subeAdiDataGridViewTextBoxColumn
            // 
            this.subeAdiDataGridViewTextBoxColumn.DataPropertyName = "SubeAdi";
            this.subeAdiDataGridViewTextBoxColumn.HeaderText = "SubeAdi";
            this.subeAdiDataGridViewTextBoxColumn.Name = "subeAdiDataGridViewTextBoxColumn";
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            // 
            // firmaIDDataGridViewTextBoxColumn
            // 
            this.firmaIDDataGridViewTextBoxColumn.DataPropertyName = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.HeaderText = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.Name = "firmaIDDataGridViewTextBoxColumn";
            // 
            // sefIDDataGridViewTextBoxColumn
            // 
            this.sefIDDataGridViewTextBoxColumn.DataPropertyName = "SefID";
            this.sefIDDataGridViewTextBoxColumn.HeaderText = "SefID";
            this.sefIDDataGridViewTextBoxColumn.Name = "sefIDDataGridViewTextBoxColumn";
            // 
            // subelerBindingSource
            // 
            this.subelerBindingSource.DataMember = "Subeler";
            this.subelerBindingSource.DataSource = this.petrolOtomasyonDataSet;
            // 
            // petrolOtomasyonDataSet
            // 
            this.petrolOtomasyonDataSet.DataSetName = "petrolOtomasyonDataSet";
            this.petrolOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subelerTableAdapter
            // 
            this.subelerTableAdapter.ClearBeforeFill = true;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(268, 236);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(174, 13);
            this.lblBilgi.TabIndex = 13;
            this.lblBilgi.Text = "Durum mesajları burada görünecek.";
            // 
            // btnpompa
            // 
            this.btnpompa.Location = new System.Drawing.Point(644, 648);
            this.btnpompa.Name = "btnpompa";
            this.btnpompa.Size = new System.Drawing.Size(174, 61);
            this.btnpompa.TabIndex = 14;
            this.btnpompa.Text = "Pompacı Arayüzü";
            this.btnpompa.UseVisualStyleBackColor = true;
            this.btnpompa.Click += new System.EventHandler(this.btnpompa_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervIDDataGridViewTextBoxColumn,
            this.toplamMiktarDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.anaRezervBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(29, 456);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(316, 93);
            this.dataGridView2.TabIndex = 15;
            // 
            // rezervIDDataGridViewTextBoxColumn
            // 
            this.rezervIDDataGridViewTextBoxColumn.DataPropertyName = "RezervID";
            this.rezervIDDataGridViewTextBoxColumn.HeaderText = "RezervID";
            this.rezervIDDataGridViewTextBoxColumn.Name = "rezervIDDataGridViewTextBoxColumn";
            // 
            // toplamMiktarDataGridViewTextBoxColumn
            // 
            this.toplamMiktarDataGridViewTextBoxColumn.DataPropertyName = "ToplamMiktar";
            this.toplamMiktarDataGridViewTextBoxColumn.HeaderText = "ToplamMiktar";
            this.toplamMiktarDataGridViewTextBoxColumn.Name = "toplamMiktarDataGridViewTextBoxColumn";
            // 
            // anaRezervBindingSource
            // 
            this.anaRezervBindingSource.DataMember = "AnaRezerv";
            this.anaRezervBindingSource.DataSource = this.petrolOtomasyonDataSet3;
            // 
            // petrolOtomasyonDataSet3
            // 
            this.petrolOtomasyonDataSet3.DataSetName = "petrolOtomasyonDataSet3";
            this.petrolOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anaRezervTableAdapter
            // 
            this.anaRezervTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ana Rezerv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Şubedeki Rezerv Miktarları";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depoIDDataGridViewTextBoxColumn,
            this.subeIDDataGridViewTextBoxColumn1,
            this.yakitIDDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.depoBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(29, 625);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(488, 93);
            this.dataGridView3.TabIndex = 18;
            // 
            // depoIDDataGridViewTextBoxColumn
            // 
            this.depoIDDataGridViewTextBoxColumn.DataPropertyName = "DepoID";
            this.depoIDDataGridViewTextBoxColumn.HeaderText = "DepoID";
            this.depoIDDataGridViewTextBoxColumn.Name = "depoIDDataGridViewTextBoxColumn";
            this.depoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subeIDDataGridViewTextBoxColumn1
            // 
            this.subeIDDataGridViewTextBoxColumn1.DataPropertyName = "SubeID";
            this.subeIDDataGridViewTextBoxColumn1.HeaderText = "SubeID";
            this.subeIDDataGridViewTextBoxColumn1.Name = "subeIDDataGridViewTextBoxColumn1";
            // 
            // yakitIDDataGridViewTextBoxColumn
            // 
            this.yakitIDDataGridViewTextBoxColumn.DataPropertyName = "YakitID";
            this.yakitIDDataGridViewTextBoxColumn.HeaderText = "YakitID";
            this.yakitIDDataGridViewTextBoxColumn.Name = "yakitIDDataGridViewTextBoxColumn";
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            // 
            // depoBindingSource
            // 
            this.depoBindingSource.DataMember = "Depo";
            this.depoBindingSource.DataSource = this.petrolOtomasyonDataSet4;
            // 
            // petrolOtomasyonDataSet4
            // 
            this.petrolOtomasyonDataSet4.DataSetName = "petrolOtomasyonDataSet4";
            this.petrolOtomasyonDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depoTableAdapter
            // 
            this.depoTableAdapter.ClearBeforeFill = true;
            // 
            // petrolOtomasyonDataSet5
            // 
            this.petrolOtomasyonDataSet5.DataSetName = "petrolOtomasyonDataSet5";
            this.petrolOtomasyonDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervasyonlarBindingSource
            // 
            this.rezervasyonlarBindingSource.DataMember = "Rezervasyonlar";
            this.rezervasyonlarBindingSource.DataSource = this.petrolOtomasyonDataSet5;
            // 
            // rezervasyonlarTableAdapter
            // 
            this.rezervasyonlarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewpersonel
            // 
            this.dataGridViewpersonel.AutoGenerateColumns = false;
            this.dataGridViewpersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervIDDataGridViewTextBoxColumn1,
            this.subeAdiDataGridViewTextBoxColumn1,
            this.yakitIDDataGridViewTextBoxColumn1,
            this.miktarDataGridViewTextBoxColumn1,
            this.talepTarihiDataGridViewTextBoxColumn});
            this.dataGridViewpersonel.DataSource = this.rezervasyonlarBindingSource1;
            this.dataGridViewpersonel.Location = new System.Drawing.Point(557, 212);
            this.dataGridViewpersonel.Name = "dataGridViewpersonel";
            this.dataGridViewpersonel.Size = new System.Drawing.Size(596, 124);
            this.dataGridViewpersonel.TabIndex = 19;
            // 
            // rezervIDDataGridViewTextBoxColumn1
            // 
            this.rezervIDDataGridViewTextBoxColumn1.DataPropertyName = "RezervID";
            this.rezervIDDataGridViewTextBoxColumn1.HeaderText = "RezervID";
            this.rezervIDDataGridViewTextBoxColumn1.Name = "rezervIDDataGridViewTextBoxColumn1";
            this.rezervIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // subeAdiDataGridViewTextBoxColumn1
            // 
            this.subeAdiDataGridViewTextBoxColumn1.DataPropertyName = "SubeAdi";
            this.subeAdiDataGridViewTextBoxColumn1.HeaderText = "SubeAdi";
            this.subeAdiDataGridViewTextBoxColumn1.Name = "subeAdiDataGridViewTextBoxColumn1";
            // 
            // yakitIDDataGridViewTextBoxColumn1
            // 
            this.yakitIDDataGridViewTextBoxColumn1.DataPropertyName = "YakitID";
            this.yakitIDDataGridViewTextBoxColumn1.HeaderText = "YakitID";
            this.yakitIDDataGridViewTextBoxColumn1.Name = "yakitIDDataGridViewTextBoxColumn1";
            // 
            // miktarDataGridViewTextBoxColumn1
            // 
            this.miktarDataGridViewTextBoxColumn1.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn1.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn1.Name = "miktarDataGridViewTextBoxColumn1";
            // 
            // talepTarihiDataGridViewTextBoxColumn
            // 
            this.talepTarihiDataGridViewTextBoxColumn.DataPropertyName = "TalepTarihi";
            this.talepTarihiDataGridViewTextBoxColumn.HeaderText = "TalepTarihi";
            this.talepTarihiDataGridViewTextBoxColumn.Name = "talepTarihiDataGridViewTextBoxColumn";
            // 
            // rezervasyonlarBindingSource1
            // 
            this.rezervasyonlarBindingSource1.DataMember = "Rezervasyonlar";
            this.rezervasyonlarBindingSource1.DataSource = this.petrolOtomasyonDataSet6;
            // 
            // petrolOtomasyonDataSet6
            // 
            this.petrolOtomasyonDataSet6.DataSetName = "petrolOtomasyonDataSet6";
            this.petrolOtomasyonDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervasyonlarTableAdapter1
            // 
            this.rezervasyonlarTableAdapter1.ClearBeforeFill = true;
            // 
            // buttongirisyap
            // 
            this.buttongirisyap.Location = new System.Drawing.Point(854, 648);
            this.buttongirisyap.Name = "buttongirisyap";
            this.buttongirisyap.Size = new System.Drawing.Size(174, 61);
            this.buttongirisyap.TabIndex = 20;
            this.buttongirisyap.Text = "Giriş paneli";
            this.buttongirisyap.UseVisualStyleBackColor = true;
            this.buttongirisyap.Click += new System.EventHandler(this.buttongirisyap_Click);
            // 
            // dgvSubeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1165, 823);
            this.Controls.Add(this.buttongirisyap);
            this.Controls.Add(this.dataGridViewpersonel);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnpompa);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSefID);
            this.Controls.Add(this.lblSefID);
            this.Controls.Add(this.txtFirmaID);
            this.Controls.Add(this.lblFirmaID);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.txtSubeAdi);
            this.Controls.Add(this.lblSubeAdi);
            this.Controls.Add(this.txtSubeID);
            this.Controls.Add(this.lblSubeID);
            this.Name = "dgvSubeler";
            this.Text = "Şube Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaRezervBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonlarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubeID;
        private System.Windows.Forms.TextBox txtSubeID;
        private System.Windows.Forms.Label lblSubeAdi;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Label lblFirmaID;
        private System.Windows.Forms.TextBox txtFirmaID;
        private System.Windows.Forms.Label lblSefID;
        private System.Windows.Forms.TextBox txtSefID;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private petrolOtomasyonDataSet petrolOtomasyonDataSet;
        private System.Windows.Forms.BindingSource subelerBindingSource;
        private petrolOtomasyonDataSetTableAdapters.SubelerTableAdapter subelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sefIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Button btnpompa;
        private System.Windows.Forms.DataGridView dataGridView2;
        private petrolOtomasyonDataSet3 petrolOtomasyonDataSet3;
        private System.Windows.Forms.BindingSource anaRezervBindingSource;
        private petrolOtomasyonDataSet3TableAdapters.AnaRezervTableAdapter anaRezervTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private petrolOtomasyonDataSet4 petrolOtomasyonDataSet4;
        private System.Windows.Forms.BindingSource depoBindingSource;
        private petrolOtomasyonDataSet4TableAdapters.DepoTableAdapter depoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private petrolOtomasyonDataSet5 petrolOtomasyonDataSet5;
        private System.Windows.Forms.BindingSource rezervasyonlarBindingSource;
        private petrolOtomasyonDataSet5TableAdapters.RezervasyonlarTableAdapter rezervasyonlarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewpersonel;
        private petrolOtomasyonDataSet6 petrolOtomasyonDataSet6;
        private System.Windows.Forms.BindingSource rezervasyonlarBindingSource1;
        private petrolOtomasyonDataSet6TableAdapters.RezervasyonlarTableAdapter rezervasyonlarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeAdiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttongirisyap;
    }
}

