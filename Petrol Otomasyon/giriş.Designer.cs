namespace Petrol_Otomasyon
{
    partial class giriş
    {
       
        private System.ComponentModel.IContainer components = null;

        
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

        
        private void InitializeComponent()
        {
            this.labeladsoyad = new System.Windows.Forms.Label();
            this.labelpozisyon = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttongiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.labeladsoyad.AutoSize = true;
            this.labeladsoyad.Location = new System.Drawing.Point(57, 42);
            this.labeladsoyad.Name = "labeladsoyad";
            this.labeladsoyad.Size = new System.Drawing.Size(53, 13);
            this.labeladsoyad.TabIndex = 0;
            this.labeladsoyad.Text = "Ad Soyad";
            
            this.labelpozisyon.AutoSize = true;
            this.labelpozisyon.Location = new System.Drawing.Point(61, 79);
            this.labelpozisyon.Name = "labelpozisyon";
            this.labelpozisyon.Size = new System.Drawing.Size(49, 13);
            this.labelpozisyon.TabIndex = 1;
            this.labelpozisyon.Text = "Pozisyon";
            this.labelpozisyon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelpozisyon.Click += new System.EventHandler(this.labelpozisyon_Click);
            
            this.textBox1.Location = new System.Drawing.Point(116, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 2;
            
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yönetici ",
            "Kasa Görevlisi",
            "Pompacı"});
            this.comboBox1.Location = new System.Drawing.Point(116, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            
            this.buttongiris.Location = new System.Drawing.Point(150, 103);
            this.buttongiris.Name = "buttongiris";
            this.buttongiris.Size = new System.Drawing.Size(75, 23);
            this.buttongiris.TabIndex = 4;
            this.buttongiris.Text = "GİRİŞ YAP";
            this.buttongiris.UseVisualStyleBackColor = true;
            this.buttongiris.Click += new System.EventHandler(this.button1_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 615);
            this.Controls.Add(this.buttongiris);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelpozisyon);
            this.Controls.Add(this.labeladsoyad);
            this.Name = "giriş";
            this.Text = "giriş";
            this.Load += new System.EventHandler(this.giriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeladsoyad;
        private System.Windows.Forms.Label labelpozisyon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttongiris;
    }
}