namespace PacMan
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
            this.tmrSag = new System.Windows.Forms.Timer(this.components);
            this.tmrSol = new System.Windows.Forms.Timer(this.components);
            this.tmrYukari = new System.Windows.Forms.Timer(this.components);
            this.tmrAsagi = new System.Windows.Forms.Timer(this.components);
            this.pbCanavar = new System.Windows.Forms.PictureBox();
            this.pbPacMan = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusPuan = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCan = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrCanavar = new System.Windows.Forms.Timer(this.components);
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanavar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacMan)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrSag
            // 
            this.tmrSag.Tick += new System.EventHandler(this.tmrSag_Tick);
            // 
            // tmrSol
            // 
            this.tmrSol.Tick += new System.EventHandler(this.tmrSol_Tick);
            // 
            // tmrYukari
            // 
            this.tmrYukari.Tick += new System.EventHandler(this.tmrYukari_Tick);
            // 
            // tmrAsagi
            // 
            this.tmrAsagi.Tick += new System.EventHandler(this.tmrAsagi_Tick);
            // 
            // pbCanavar
            // 
            this.pbCanavar.BackColor = System.Drawing.Color.Transparent;
            this.pbCanavar.Image = global::PacMan.Properties.Resources.ghost;
            this.pbCanavar.Location = new System.Drawing.Point(524, 355);
            this.pbCanavar.Name = "pbCanavar";
            this.pbCanavar.Size = new System.Drawing.Size(50, 50);
            this.pbCanavar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCanavar.TabIndex = 2;
            this.pbCanavar.TabStop = false;
            // 
            // pbPacMan
            // 
            this.pbPacMan.BackColor = System.Drawing.Color.Transparent;
            this.pbPacMan.Image = global::PacMan.Properties.Resources.openPacman;
            this.pbPacMan.Location = new System.Drawing.Point(234, 182);
            this.pbPacMan.Name = "pbPacMan";
            this.pbPacMan.Size = new System.Drawing.Size(50, 50);
            this.pbPacMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPacMan.TabIndex = 1;
            this.pbPacMan.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPuan,
            this.statusCan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(636, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusPuan
            // 
            this.statusPuan.Name = "statusPuan";
            this.statusPuan.Size = new System.Drawing.Size(48, 20);
            this.statusPuan.Text = "Puan:";
            // 
            // statusCan
            // 
            this.statusCan.Name = "statusCan";
            this.statusCan.Size = new System.Drawing.Size(39, 20);
            this.statusCan.Text = "Can:";
            // 
            // tmrCanavar
            // 
            this.tmrCanavar.Interval = 300;
            this.tmrCanavar.Tick += new System.EventHandler(this.tmrCanavar_Tick);
            // 
            // btn1
            // 
            this.btn1.Enabled = false;
            this.btn1.Location = new System.Drawing.Point(220, 61);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(317, 10);
            this.btn1.TabIndex = 4;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Enabled = false;
            this.btn2.Location = new System.Drawing.Point(89, 329);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(115, 10);
            this.btn2.TabIndex = 4;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Enabled = false;
            this.btn3.Location = new System.Drawing.Point(444, 285);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(10, 120);
            this.btn3.TabIndex = 4;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(636, 456);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbCanavar);
            this.Controls.Add(this.pbPacMan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pac Man";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanavar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacMan)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPacMan;
        private System.Windows.Forms.Timer tmrSag;
        private System.Windows.Forms.Timer tmrSol;
        private System.Windows.Forms.Timer tmrYukari;
        private System.Windows.Forms.Timer tmrAsagi;
        private System.Windows.Forms.PictureBox pbCanavar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusPuan;
        private System.Windows.Forms.ToolStripStatusLabel statusCan;
        private System.Windows.Forms.Timer tmrCanavar;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}

