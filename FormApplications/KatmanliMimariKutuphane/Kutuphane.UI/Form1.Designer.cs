namespace Kutuphane.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbYazarlar = new System.Windows.Forms.ComboBox();
            this.lbKitaplar = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guncelleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazarlar: ";
            // 
            // cbYazarlar
            // 
            this.cbYazarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbYazarlar.FormattingEnabled = true;
            this.cbYazarlar.Location = new System.Drawing.Point(110, 48);
            this.cbYazarlar.Name = "cbYazarlar";
            this.cbYazarlar.Size = new System.Drawing.Size(185, 26);
            this.cbYazarlar.TabIndex = 1;
            this.cbYazarlar.SelectedIndexChanged += new System.EventHandler(this.cbYazarlar_SelectedIndexChanged);
            // 
            // lbKitaplar
            // 
            this.lbKitaplar.FormattingEnabled = true;
            this.lbKitaplar.Location = new System.Drawing.Point(37, 84);
            this.lbKitaplar.Name = "lbKitaplar";
            this.lbKitaplar.Size = new System.Drawing.Size(258, 251);
            this.lbKitaplar.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazarToolStripMenuItem,
            this.kitapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(345, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yazarToolStripMenuItem
            // 
            this.yazarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.guncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.yazarToolStripMenuItem.Name = "yazarToolStripMenuItem";
            this.yazarToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.yazarToolStripMenuItem.Text = "Yazar";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.guncelleToolStripMenuItem.Text = "Guncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // kitapToolStripMenuItem
            // 
            this.kitapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1,
            this.guncelleToolStripMenuItem1,
            this.silToolStripMenuItem1});
            this.kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            this.kitapToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.kitapToolStripMenuItem.Text = "Kitap";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(137, 24);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            this.ekleToolStripMenuItem1.Click += new System.EventHandler(this.ekleToolStripMenuItem1_Click);
            // 
            // guncelleToolStripMenuItem1
            // 
            this.guncelleToolStripMenuItem1.Name = "guncelleToolStripMenuItem1";
            this.guncelleToolStripMenuItem1.Size = new System.Drawing.Size(137, 24);
            this.guncelleToolStripMenuItem1.Text = "Guncelle";
            this.guncelleToolStripMenuItem1.Click += new System.EventHandler(this.guncelleToolStripMenuItem1_Click);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Beige;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 353);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(345, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(345, 375);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbKitaplar);
            this.Controls.Add(this.cbYazarlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "-* Kütüphane *-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKitaplar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yazarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        protected System.Windows.Forms.ComboBox cbYazarlar;
    }
}

