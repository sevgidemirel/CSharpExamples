namespace Kutuphane.UI.Yazar
{
    partial class frm_YazarGuncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.txtOzgecmis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Pink;
            this.btnGuncelle.Location = new System.Drawing.Point(166, 214);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(87, 29);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yazar Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Özgeçmiş:";
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarAd.Location = new System.Drawing.Point(145, 42);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(135, 24);
            this.txtYazarAd.TabIndex = 2;
            // 
            // txtYazarSoyad
            // 
            this.txtYazarSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarSoyad.Location = new System.Drawing.Point(145, 86);
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            this.txtYazarSoyad.Size = new System.Drawing.Size(135, 24);
            this.txtYazarSoyad.TabIndex = 2;
            // 
            // txtOzgecmis
            // 
            this.txtOzgecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOzgecmis.Location = new System.Drawing.Point(145, 129);
            this.txtOzgecmis.Multiline = true;
            this.txtOzgecmis.Name = "txtOzgecmis";
            this.txtOzgecmis.Size = new System.Drawing.Size(135, 58);
            this.txtOzgecmis.TabIndex = 2;
            // 
            // frm_YazarGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(314, 270);
            this.Controls.Add(this.txtOzgecmis);
            this.Controls.Add(this.txtYazarSoyad);
            this.Controls.Add(this.txtYazarAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "frm_YazarGuncelle";
            this.Text = "# Yazar Güncelle #";
            this.Load += new System.EventHandler(this.frm_YazarGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.TextBox txtYazarSoyad;
        private System.Windows.Forms.TextBox txtOzgecmis;
    }
}