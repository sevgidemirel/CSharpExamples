namespace CRM.UI.Customers
{
    partial class frm_CustomerAdd
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
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomer
            // 
            this.gbCustomer.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gbCustomer.Controls.Add(this.rbMale);
            this.gbCustomer.Controls.Add(this.rbFemale);
            this.gbCustomer.Controls.Add(this.label1);
            this.gbCustomer.Controls.Add(this.btnAdd);
            this.gbCustomer.Controls.Add(this.txtName);
            this.gbCustomer.Controls.Add(this.txtSurname);
            this.gbCustomer.Controls.Add(this.txtAdress);
            this.gbCustomer.Controls.Add(this.txtPhone);
            this.gbCustomer.Controls.Add(this.label8);
            this.gbCustomer.Controls.Add(this.txtMail);
            this.gbCustomer.Controls.Add(this.label7);
            this.gbCustomer.Controls.Add(this.txtCity);
            this.gbCustomer.Controls.Add(this.label6);
            this.gbCustomer.Controls.Add(this.txtCountry);
            this.gbCustomer.Controls.Add(this.label5);
            this.gbCustomer.Controls.Add(this.label2);
            this.gbCustomer.Controls.Add(this.label4);
            this.gbCustomer.Controls.Add(this.label3);
            this.gbCustomer.Location = new System.Drawing.Point(12, 12);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(418, 167);
            this.gbCustomer.TabIndex = 7;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(277, 70);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(333, 70);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Khaki;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(277, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Tag = "Ad";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(86, 39);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(108, 20);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.Tag = "Soyad";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(86, 65);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(108, 20);
            this.txtAdress.TabIndex = 0;
            this.txtAdress.Tag = "Adres";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(86, 91);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(108, 20);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.Tag = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Gender";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(86, 119);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(108, 20);
            this.txtMail.TabIndex = 0;
            this.txtMail.Tag = "Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Country:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(277, 13);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(115, 20);
            this.txtCity.TabIndex = 0;
            this.txtCity.Tag = "Sehir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "City:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(277, 39);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(115, 20);
            this.txtCountry.TabIndex = 0;
            this.txtCountry.Tag = "Ülke";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address:";
            // 
            // frm_CustomerAdd
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 193);
            this.Controls.Add(this.gbCustomer);
            this.Name = "frm_CustomerAdd";
            this.Text = "- Customer Add -";
            this.Load += new System.EventHandler(this.frm_CustomerAdd_Load);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}