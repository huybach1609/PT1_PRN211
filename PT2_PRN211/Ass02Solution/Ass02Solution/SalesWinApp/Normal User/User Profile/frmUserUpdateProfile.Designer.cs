namespace SalesWinApp.Normal_User
{
    partial class frmUserUpdateProfile
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
            txtSubmitPassword = new TextBox();
            label5 = new Label();
            txtCompanyName = new TextBox();
            label4 = new Label();
            txtCountry = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            btnClose = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // txtSubmitPassword
            // 
            txtSubmitPassword.Location = new Point(265, 140);
            txtSubmitPassword.Margin = new Padding(5, 5, 5, 5);
            txtSubmitPassword.Name = "txtSubmitPassword";
            txtSubmitPassword.PasswordChar = '*';
            txtSubmitPassword.Size = new Size(607, 39);
            txtSubmitPassword.TabIndex = 19;
            txtSubmitPassword.TextChanged += txtSubmitPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 145);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 32);
            label5.TabIndex = 18;
            label5.Text = "Submit Password";
            label5.Click += label5_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(265, 236);
            txtCompanyName.Margin = new Padding(5, 5, 5, 5);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(607, 39);
            txtCompanyName.TabIndex = 17;
            txtCompanyName.TextChanged += txtCompanyName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 241);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(187, 32);
            label4.TabIndex = 16;
            label4.Text = "Company Name";
            label4.Click += label4_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(265, 428);
            txtCountry.Margin = new Padding(5, 5, 5, 5);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(607, 39);
            txtCountry.TabIndex = 15;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 433);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 32);
            label3.TabIndex = 14;
            label3.Text = "Country";
            label3.Click += label3_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(265, 331);
            txtCity.Margin = new Padding(5, 5, 5, 5);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(607, 39);
            txtCity.TabIndex = 13;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 336);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 12;
            label2.Text = "City";
            label2.Click += label2_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(265, 44);
            txtPassword.Margin = new Padding(5, 5, 5, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(607, 39);
            txtPassword.TabIndex = 11;
            txtPassword.TextChanged += txtPassword_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 49);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 10;
            label1.Text = "New Password";
            label1.Click += label1_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(343, 498);
            btnClose.Margin = new Padding(5, 5, 5, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(206, 62);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = DialogResult.OK;
            btnUpdate.Location = new Point(41, 498);
            btnUpdate.Margin = new Padding(5, 5, 5, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(206, 62);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Submit";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmUserUpdateProfile
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 591);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(txtSubmitPassword);
            Controls.Add(label5);
            Controls.Add(txtCompanyName);
            Controls.Add(label4);
            Controls.Add(txtCountry);
            Controls.Add(label3);
            Controls.Add(txtCity);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "frmUserUpdateProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Profile";
            FormClosing += frmUserUpdateProfile_FormClosing;
            Load += frmUserUpdateProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubmitPassword;
        private Label label5;
        private TextBox txtCompanyName;
        private Label label4;
        private TextBox txtCountry;
        private Label label3;
        private TextBox txtCity;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private Button btnClose;
        private Button btnUpdate;
    }
}