namespace e_okul_projesi_1
{
    partial class OgrenciOrtalaması
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_ogrenci_ortalama = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrencinin ortalamsını öğrenmek istiyorsanız lütfen butona basınız";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_ogrenci_ortalama
            // 
            this.lbl_ogrenci_ortalama.AutoSize = true;
            this.lbl_ogrenci_ortalama.Location = new System.Drawing.Point(191, 273);
            this.lbl_ogrenci_ortalama.Name = "lbl_ogrenci_ortalama";
            this.lbl_ogrenci_ortalama.Size = new System.Drawing.Size(13, 13);
            this.lbl_ogrenci_ortalama.TabIndex = 0;
            this.lbl_ogrenci_ortalama.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(554, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 79);
            this.button3.TabIndex = 2;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OgrenciOrtalaması
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_ogrenci_ortalama);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciOrtalaması";
            this.Text = "OgrenciOrtalaması";
            this.Load += new System.EventHandler(this.OgrenciOrtalaması_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_ogrenci_ortalama;
        private System.Windows.Forms.Button button3;
    }
}