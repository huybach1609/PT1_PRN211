﻿namespace MyStoreWinApp
{
    partial class FormMemberManagerment
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
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            txtCountry = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            lbPassword = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            btnSort = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            cbxCity = new System.Windows.Forms.ComboBox();
            cbxCountry = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            txtSearchBox = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            dgvMember = new System.Windows.Forms.DataGridView();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtCountry);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(lbPassword);
            panel1.Location = new System.Drawing.Point(3, 151);
            panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(362, 339);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(143, 345);
            button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(81, 33);
            button1.TabIndex = 32;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(75, 242);
            txtCountry.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(279, 23);
            txtCountry.TabIndex = 31;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(75, 196);
            txtCity.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(279, 23);
            txtCity.TabIndex = 30;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(262, 295);
            btnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(81, 33);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(143, 295);
            btnNew.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(81, 33);
            btnNew.TabIndex = 28;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(25, 295);
            btnLoad.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(81, 33);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(10, 243);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 15);
            label5.TabIndex = 25;
            label5.Text = "Country";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(10, 197);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 15);
            label4.TabIndex = 24;
            label4.Text = "City";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(75, 150);
            txtPassword.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(279, 23);
            txtPassword.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(10, 151);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 15);
            label3.TabIndex = 22;
            label3.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(75, 104);
            txtEmail.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(279, 23);
            txtEmail.TabIndex = 21;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(10, 105);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 20;
            label2.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(75, 58);
            txtName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(279, 23);
            txtName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(10, 60);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 18;
            label1.Text = "Name";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(75, 12);
            txtID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(279, 23);
            txtID.TabIndex = 17;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.ForeColor = System.Drawing.Color.Black;
            lbPassword.Location = new System.Drawing.Point(10, 14);
            lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(17, 15);
            lbPassword.TabIndex = 16;
            lbPassword.Text = "Id";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSort);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(cbxCity);
            panel3.Controls.Add(cbxCountry);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtSearchBox);
            panel3.Location = new System.Drawing.Point(3, 6);
            panel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(360, 135);
            panel3.TabIndex = 0;
            // 
            // btnSort
            // 
            btnSort.Location = new System.Drawing.Point(213, 9);
            btnSort.Name = "btnSort";
            btnSort.Size = new System.Drawing.Size(139, 23);
            btnSort.TabIndex = 31;
            btnSort.Text = "sort ascending";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(10, 65);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(34, 15);
            label7.TabIndex = 30;
            label7.Text = "filter:";
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(271, 90);
            btnClear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(81, 22);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cbxCity
            // 
            cbxCity.FormattingEnabled = true;
            cbxCity.Items.AddRange(new object[] { "Hanoi ", "Ho Chi Minh City ", "Da Nang", "Hai Phong", "Can Tho", "Nha Trang", "Hue", "Vinh", "Qui Nhon", "Ha Long" });
            cbxCity.Location = new System.Drawing.Point(75, 62);
            cbxCity.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            cbxCity.Name = "cbxCity";
            cbxCity.Size = new System.Drawing.Size(136, 23);
            cbxCity.TabIndex = 29;
            cbxCity.SelectedIndexChanged += cbxCity_SelectedIndexChanged;
            // 
            // cbxCountry
            // 
            cbxCountry.FormattingEnabled = true;
            cbxCountry.Items.AddRange(new object[] { "Hanoi ", "Ho Chi Minh City ", "Da Nang", "Hai Phong", "Can Tho", "Nha Trang", "Hue", "Vinh", "Qui Nhon", "Ha Long" });
            cbxCountry.Location = new System.Drawing.Point(213, 62);
            cbxCountry.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            cbxCountry.Name = "cbxCountry";
            cbxCountry.Size = new System.Drawing.Size(141, 23);
            cbxCountry.TabIndex = 28;
            cbxCountry.SelectedIndexChanged += cbxCountry_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(10, 36);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(44, 15);
            label6.TabIndex = 28;
            label6.Text = "search:";
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new System.Drawing.Point(75, 36);
            txtSearchBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new System.Drawing.Size(279, 23);
            txtSearchBox.TabIndex = 0;
            txtSearchBox.TextChanged += txtSearchBox_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvMember);
            panel2.Location = new System.Drawing.Point(365, 0);
            panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(789, 575);
            panel2.TabIndex = 1;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new System.Drawing.Point(11, 9);
            dgvMember.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 82;
            dgvMember.RowTemplate.Height = 41;
            dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMember.Size = new System.Drawing.Size(652, 481);
            dgvMember.TabIndex = 0;
            dgvMember.CellDoubleClick += dgvMember_CellDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { loadToolStripMenuItem, newToolStripMenuItem, deleteToolStripMenuItem, closeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(108, 92);
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // FormMemberManagerment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1036, 497);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            Name = "FormMemberManagerment";
            Text = "Member Managerment";
            Load += FormMemberManagerment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxCountry;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSort;
    }
}