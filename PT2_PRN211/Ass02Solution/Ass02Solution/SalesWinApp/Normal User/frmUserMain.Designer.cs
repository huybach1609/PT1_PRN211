namespace SalesWinApp.Normal_User
{
    partial class frmUserMain
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
            btnProfile = new Button();
            btnOrders = new Button();
            btnClose = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(543, 67);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 86);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(283, 234);
            btnProfile.Margin = new Padding(5, 5, 5, 5);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(736, 56);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "View Your Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(284, 355);
            btnOrders.Margin = new Padding(5, 5, 5, 5);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(736, 56);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "View Your Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(283, 477);
            btnClose.Margin = new Padding(5, 5, 5, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(736, 56);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1051, 96);
            btnLogout.Margin = new Padding(5, 5, 5, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(174, 62);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmUserMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(btnLogout);
            Controls.Add(btnClose);
            Controls.Add(btnOrders);
            Controls.Add(btnProfile);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "frmUserMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosing += frmUserMain_FormClosing;
            Load += frmUserMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProfile;
        private Button btnOrders;
        private Button btnClose;
        private Button btnLogout;
    }
}