namespace Kutuphane.UI.Kitap
{
    partial class frm_KitapGuncelle
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cbYazar = new System.Windows.Forms.ComboBox();
            this.txtYayinTarihi = new System.Windows.Forms.TextBox();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.txtKitapKonusu = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Pink;
            this.btnGuncelle.Location = new System.Drawing.Point(155, 256);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(142, 30);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbYazar
            // 
            this.cbYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbYazar.FormattingEnabled = true;
            this.cbYazar.Location = new System.Drawing.Point(156, 222);
            this.cbYazar.Name = "cbYazar";
            this.cbYazar.Size = new System.Drawing.Size(143, 23);
            this.cbYazar.TabIndex = 17;
            // 
            // txtYayinTarihi
            // 
            this.txtYayinTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinTarihi.Location = new System.Drawing.Point(156, 182);
            this.txtYayinTarihi.Name = "txtYayinTarihi";
            this.txtYayinTarihi.Size = new System.Drawing.Size(143, 21);
            this.txtYayinTarihi.TabIndex = 16;
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinEvi.Location = new System.Drawing.Point(156, 144);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(143, 21);
            this.txtYayinEvi.TabIndex = 15;
            // 
            // txtKitapKonusu
            // 
            this.txtKitapKonusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapKonusu.Location = new System.Drawing.Point(155, 70);
            this.txtKitapKonusu.Multiline = true;
            this.txtKitapKonusu.Name = "txtKitapKonusu";
            this.txtKitapKonusu.Size = new System.Drawing.Size(143, 56);
            this.txtKitapKonusu.TabIndex = 14;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdi.Location = new System.Drawing.Point(155, 30);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(143, 21);
            this.txtKitapAdi.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yayınevi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yazar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yayın Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kitap Konusu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kitap Adı:";
            // 
            // frm_KitapGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(336, 314);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cbYazar);
            this.Controls.Add(this.txtYayinTarihi);
            this.Controls.Add(this.txtYayinEvi);
            this.Controls.Add(this.txtKitapKonusu);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_KitapGuncelle";
            this.Text = "# Kitap Güncelle #";
            this.Load += new System.EventHandler(this.frm_KitapGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cbYazar;
        private System.Windows.Forms.TextBox txtYayinTarihi;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.TextBox txtKitapKonusu;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}