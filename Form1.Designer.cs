namespace SlotMakinası
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblSayi1 = new System.Windows.Forms.Label();
            this.LblSayi2 = new System.Windows.Forms.Label();
            this.LblSayi3 = new System.Windows.Forms.Label();
            this.LblKasadakiPara = new System.Windows.Forms.Label();
            this.BtnDurdur = new System.Windows.Forms.Button();
            this.BtnBasla = new System.Windows.Forms.Button();
            this.BtnJetonAt = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblSayi1
            // 
            this.LblSayi1.AutoSize = true;
            this.LblSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSayi1.ForeColor = System.Drawing.Color.Red;
            this.LblSayi1.Location = new System.Drawing.Point(56, 25);
            this.LblSayi1.Name = "LblSayi1";
            this.LblSayi1.Size = new System.Drawing.Size(70, 76);
            this.LblSayi1.TabIndex = 0;
            this.LblSayi1.Text = "0";
            // 
            // LblSayi2
            // 
            this.LblSayi2.AutoSize = true;
            this.LblSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSayi2.ForeColor = System.Drawing.Color.Red;
            this.LblSayi2.Location = new System.Drawing.Point(255, 25);
            this.LblSayi2.Name = "LblSayi2";
            this.LblSayi2.Size = new System.Drawing.Size(70, 76);
            this.LblSayi2.TabIndex = 1;
            this.LblSayi2.Text = "0";
            // 
            // LblSayi3
            // 
            this.LblSayi3.AutoSize = true;
            this.LblSayi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSayi3.ForeColor = System.Drawing.Color.Red;
            this.LblSayi3.Location = new System.Drawing.Point(444, 25);
            this.LblSayi3.Name = "LblSayi3";
            this.LblSayi3.Size = new System.Drawing.Size(70, 76);
            this.LblSayi3.TabIndex = 2;
            this.LblSayi3.Text = "0";
            // 
            // LblKasadakiPara
            // 
            this.LblKasadakiPara.AutoSize = true;
            this.LblKasadakiPara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblKasadakiPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKasadakiPara.ForeColor = System.Drawing.Color.Lime;
            this.LblKasadakiPara.Location = new System.Drawing.Point(22, 189);
            this.LblKasadakiPara.Name = "LblKasadakiPara";
            this.LblKasadakiPara.Size = new System.Drawing.Size(137, 27);
            this.LblKasadakiPara.TabIndex = 4;
            this.LblKasadakiPara.Text = "KasadakiPara";
            // 
            // BtnDurdur
            // 
            this.BtnDurdur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDurdur.ForeColor = System.Drawing.Color.Black;
            this.BtnDurdur.Location = new System.Drawing.Point(516, 296);
            this.BtnDurdur.Name = "BtnDurdur";
            this.BtnDurdur.Size = new System.Drawing.Size(117, 39);
            this.BtnDurdur.TabIndex = 5;
            this.BtnDurdur.Text = "DURDUR";
            this.BtnDurdur.UseVisualStyleBackColor = false;
            this.BtnDurdur.Click += new System.EventHandler(this.BtnDurdur_Click_1);
            // 
            // BtnBasla
            // 
            this.BtnBasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBasla.Location = new System.Drawing.Point(22, 296);
            this.BtnBasla.Name = "BtnBasla";
            this.BtnBasla.Size = new System.Drawing.Size(113, 39);
            this.BtnBasla.TabIndex = 6;
            this.BtnBasla.Text = "BAŞLAT";
            this.BtnBasla.UseVisualStyleBackColor = false;
            this.BtnBasla.Click += new System.EventHandler(this.BtnBasla_Click_1);
            // 
            // BtnJetonAt
            // 
            this.BtnJetonAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnJetonAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnJetonAt.ForeColor = System.Drawing.Color.Black;
            this.BtnJetonAt.Location = new System.Drawing.Point(174, 296);
            this.BtnJetonAt.Name = "BtnJetonAt";
            this.BtnJetonAt.Size = new System.Drawing.Size(151, 39);
            this.BtnJetonAt.TabIndex = 7;
            this.BtnJetonAt.Text = "JETON EKLE";
            this.BtnJetonAt.UseVisualStyleBackColor = false;
            this.BtnJetonAt.Click += new System.EventHandler(this.BtnJetonAt_Click_1);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackColor = System.Drawing.Color.Red;
            this.BtnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKapat.Location = new System.Drawing.Point(380, 296);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(119, 39);
            this.BtnKapat.TabIndex = 8;
            this.BtnKapat.Text = "KAPAT";
            this.BtnKapat.UseVisualStyleBackColor = false;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click_1);
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.BackColor = System.Drawing.Color.Red;
            this.LblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSonuc.Location = new System.Drawing.Point(28, 138);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(58, 18);
            this.LblSonuc.TabIndex = 9;
            this.LblSonuc.Text = "SONUC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(636, 347);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnJetonAt);
            this.Controls.Add(this.BtnBasla);
            this.Controls.Add(this.BtnDurdur);
            this.Controls.Add(this.LblKasadakiPara);
            this.Controls.Add(this.LblSayi3);
            this.Controls.Add(this.LblSayi2);
            this.Controls.Add(this.LblSayi1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "slotmakinası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblSayi1;
        private System.Windows.Forms.Label LblSayi2;
        private System.Windows.Forms.Label LblSayi3;
        private System.Windows.Forms.Label LblKasadakiPara;
        private System.Windows.Forms.Button BtnDurdur;
        private System.Windows.Forms.Button BtnBasla;
        private System.Windows.Forms.Button BtnJetonAt;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Label LblSonuc;
    }
}

