namespace SalesWinApp.Normal_User
{
    partial class frmUserProfile
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
            label1 = new Label();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            label2 = new Label();
            txtCountry = new TextBox();
            label3 = new Label();
            txtCompanyName = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnClose = new Button();
            btnShowPassword = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(258, 30);
            txtEmail.Margin = new Padding(5, 5, 5, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(510, 39);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(258, 317);
            txtCity.Margin = new Padding(5, 5, 5, 5);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(510, 39);
            txtCity.TabIndex = 3;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 322);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 2;
            label2.Text = "City";
            label2.Click += label2_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(258, 414);
            txtCountry.Margin = new Padding(5, 5, 5, 5);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(510, 39);
            txtCountry.TabIndex = 5;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 419);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 32);
            label3.TabIndex = 4;
            label3.Text = "Country";
            label3.Click += label3_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(258, 222);
            txtCompanyName.Margin = new Padding(5, 5, 5, 5);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.ReadOnly = true;
            txtCompanyName.Size = new Size(510, 39);
            txtCompanyName.TabIndex = 7;
            txtCompanyName.TextChanged += txtCompanyName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 227);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(187, 32);
            label4.TabIndex = 6;
            label4.Text = "Company Name";
            label4.Click += label4_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(258, 126);
            txtPassword.Margin = new Padding(5, 5, 5, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(266, 39);
            txtPassword.TabIndex = 9;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 131);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 8;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(31, 505);
            btnUpdate.Margin = new Padding(5, 5, 5, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(206, 62);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(333, 505);
            btnClose.Margin = new Padding(5, 5, 5, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(206, 62);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Location = new Point(534, 119);
            btnShowPassword.Margin = new Padding(5, 5, 5, 5);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(234, 53);
            btnShowPassword.TabIndex = 12;
            btnShowPassword.Text = "Show Password";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // frmUserProfile
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 618);
            Controls.Add(btnShowPassword);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtCompanyName);
            Controls.Add(label4);
            Controls.Add(txtCountry);
            Controls.Add(label3);
            Controls.Add(txtCity);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "frmUserProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            FormClosing += frmUserProfile_FormClosing;
            Load += frmUserProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtCity;
        private Label label2;
        private TextBox txtCountry;
        private Label label3;
        private TextBox txtCompanyName;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private Button btnUpdate;
        private Button btnClose;
        private Button btnShowPassword;
    }
}