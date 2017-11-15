namespace Xml_RSS_UI
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
            this.lstwHaberler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHaberiCek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRSSAdresleri = new System.Windows.Forms.ComboBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstwHaberler
            // 
            this.lstwHaberler.AllowColumnReorder = true;
            this.lstwHaberler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstwHaberler.BackColor = System.Drawing.Color.DarkGray;
            this.lstwHaberler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstwHaberler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstwHaberler.FullRowSelect = true;
            this.lstwHaberler.GridLines = true;
            this.lstwHaberler.Location = new System.Drawing.Point(17, 58);
            this.lstwHaberler.Name = "lstwHaberler";
            this.lstwHaberler.Size = new System.Drawing.Size(554, 225);
            this.lstwHaberler.TabIndex = 7;
            this.lstwHaberler.UseCompatibleStateImageBehavior = false;
            this.lstwHaberler.View = System.Windows.Forms.View.Details;
            this.lstwHaberler.Click += new System.EventHandler(this.lstwHaberler_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Haber:";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Haber Kaynagı:";
            this.columnHeader2.Width = 186;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Link:";
            this.columnHeader3.Width = 200;
            // 
            // btnHaberiCek
            // 
            this.btnHaberiCek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHaberiCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHaberiCek.Location = new System.Drawing.Point(991, 135);
            this.btnHaberiCek.Name = "btnHaberiCek";
            this.btnHaberiCek.Size = new System.Drawing.Size(200, 37);
            this.btnHaberiCek.TabIndex = 6;
            this.btnHaberiCek.Text = "Haberi Çek";
            this.btnHaberiCek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gazetenizi seçiniz:";
            // 
            // cbRSSAdresleri
            // 
            this.cbRSSAdresleri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbRSSAdresleri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cbRSSAdresleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRSSAdresleri.FormattingEnabled = true;
            this.cbRSSAdresleri.Items.AddRange(new object[] {
            "CNN TURK",
            "Milliyet"});
            this.cbRSSAdresleri.Location = new System.Drawing.Point(187, 23);
            this.cbRSSAdresleri.Name = "cbRSSAdresleri";
            this.cbRSSAdresleri.Size = new System.Drawing.Size(300, 24);
            this.cbRSSAdresleri.TabIndex = 8;
            // 
            // btnCek
            // 
            this.btnCek.BackColor = System.Drawing.Color.Transparent;
            this.btnCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCek.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnCek.Location = new System.Drawing.Point(493, 23);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(78, 25);
            this.btnCek.TabIndex = 9;
            this.btnCek.Text = "Çek";
            this.btnCek.UseVisualStyleBackColor = false;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 312);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(580, 25);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 20);
            this.toolStripStatusLabel1.Text = "Kaynak:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 337);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.cbRSSAdresleri);
            this.Controls.Add(this.lstwHaberler);
            this.Controls.Add(this.btnHaberiCek);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstwHaberler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnHaberiCek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRSSAdresleri;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

