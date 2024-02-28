namespace SalesWinApp
{
    partial class frmMain
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
            btnMemberManagement = new Button();
            btnOrderManagement = new Button();
            btnProductManagement = new Button();
            btnClose = new Button();
            btnLogout = new Button();
            btnStatistics = new Button();
            infoText = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 38);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 86);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // btnMemberManagement
            // 
            btnMemberManagement.Location = new Point(51, 174);
            btnMemberManagement.Margin = new Padding(5, 5, 5, 5);
            btnMemberManagement.Name = "btnMemberManagement";
            btnMemberManagement.Size = new Size(311, 56);
            btnMemberManagement.TabIndex = 1;
            btnMemberManagement.Text = "Member Management";
            btnMemberManagement.UseVisualStyleBackColor = true;
            btnMemberManagement.Click += btnMemberManagement_Click;
            // 
            // btnOrderManagement
            // 
            btnOrderManagement.Location = new Point(51, 354);
            btnOrderManagement.Margin = new Padding(5, 5, 5, 5);
            btnOrderManagement.Name = "btnOrderManagement";
            btnOrderManagement.Size = new Size(311, 56);
            btnOrderManagement.TabIndex = 3;
            btnOrderManagement.Text = "Order Management";
            btnOrderManagement.UseVisualStyleBackColor = true;
            btnOrderManagement.Click += btnOrderManagement_Click;
            // 
            // btnProductManagement
            // 
            btnProductManagement.Location = new Point(51, 263);
            btnProductManagement.Margin = new Padding(5, 5, 5, 5);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(311, 56);
            btnProductManagement.TabIndex = 2;
            btnProductManagement.Text = "Product Management";
            btnProductManagement.UseVisualStyleBackColor = true;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(217, 542);
            btnClose.Margin = new Padding(5, 5, 5, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(145, 56);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(51, 542);
            btnLogout.Margin = new Padding(5, 5, 5, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(145, 56);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.Location = new Point(51, 438);
            btnStatistics.Margin = new Padding(5, 5, 5, 5);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(311, 56);
            btnStatistics.TabIndex = 4;
            btnStatistics.Text = "Sales Statistics";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // infoText
            // 
            infoText.AutoSize = true;
            infoText.Location = new Point(434, 38);
            infoText.Name = "infoText";
            infoText.Size = new Size(0, 32);
            infoText.TabIndex = 7;
            infoText.Click += label2_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 684);
            Controls.Add(infoText);
            Controls.Add(btnStatistics);
            Controls.Add(btnLogout);
            Controls.Add(btnClose);
            Controls.Add(btnProductManagement);
            Controls.Add(btnOrderManagement);
            Controls.Add(btnMemberManagement);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMemberManagement;
        private Button btnOrderManagement;
        private Button btnProductManagement;
        private Button btnClose;
        private Button btnLogout;
        private Button btnStatistics;
        private Label infoText;
    }
}