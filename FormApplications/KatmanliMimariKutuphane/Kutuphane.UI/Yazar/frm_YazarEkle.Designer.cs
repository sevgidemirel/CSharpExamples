namespace Kutuphane.UI.Yazar
{
    partial class frm_YazarEkle
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
            this.txtOzgecmis = new System.Windows.Forms.TextBox();
            this.txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOzgecmis
            // 
            this.txtOzgecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOzgecmis.Location = new System.Drawing.Point(157, 132);
            this.txtOzgecmis.Multiline = true;
            this.txtOzgecmis.Name = "txtOzgecmis";
            this.txtOzgecmis.Size = new System.Drawing.Size(135, 58);
            this.txtOzgecmis.TabIndex = 7;
            // 
            // txtYazarSoyad
            // 
            this.txtYazarSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarSoyad.Location = new System.Drawing.Point(157, 89);
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            this.txtYazarSoyad.Size = new System.Drawing.Size(135, 24);
            this.txtYazarSoyad.TabIndex = 8;
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarAd.Location = new System.Drawing.Point(157, 45);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(135, 24);
            this.txtYazarAd.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Özgeçmiş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yazar Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yazar Adı:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnEkle.Location = new System.Drawing.Point(205, 211);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 29);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frm_YazarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(317, 265);
            this.Controls.Add(this.txtOzgecmis);
            this.Controls.Add(this.txtYazarSoyad);
            this.Controls.Add(this.txtYazarAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Name = "frm_YazarEkle";
            this.Text = "\"- Yazar Ekle -\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOzgecmis;
        private System.Windows.Forms.TextBox txtYazarSoyad;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
    }
}