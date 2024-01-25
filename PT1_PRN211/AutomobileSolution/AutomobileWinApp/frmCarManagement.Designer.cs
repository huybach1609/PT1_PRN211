namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            panel1 = new System.Windows.Forms.Panel();
            dgvCarList = new System.Windows.Forms.DataGridView();
            panel2 = new System.Windows.Forms.Panel();
            panel7 = new System.Windows.Forms.Panel();
            txtManufacturer = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            panel6 = new System.Windows.Forms.Panel();
            txtCarName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            txtCarID = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            btnDelete = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            panel9 = new System.Windows.Forms.Panel();
            txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            label5 = new System.Windows.Forms.Label();
            panel10 = new System.Windows.Forms.Panel();
            txtPrice = new System.Windows.Forms.MaskedTextBox();
            label6 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvCarList);
            panel1.Location = new System.Drawing.Point(12, 484);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1568, 357);
            panel1.TabIndex = 0;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new System.Drawing.Point(0, 0);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 82;
            dgvCarList.RowTemplate.Height = 41;
            dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new System.Drawing.Size(1568, 357);
            dgvCarList.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Location = new System.Drawing.Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(784, 350);
            panel2.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtManufacturer);
            panel7.Controls.Add(label3);
            panel7.Location = new System.Drawing.Point(11, 237);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(773, 86);
            panel7.TabIndex = 3;
            // 
            // txtManufacturer
            // 
            txtManufacturer.FormattingEnabled = true;
            txtManufacturer.Location = new System.Drawing.Point(198, 21);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new System.Drawing.Size(548, 40);
            txtManufacturer.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(158, 32);
            label3.TabIndex = 0;
            label3.Text = "Manufacturer";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtCarName);
            panel6.Controls.Add(label2);
            panel6.Location = new System.Drawing.Point(11, 124);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(773, 86);
            panel6.TabIndex = 3;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(198, 22);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(551, 39);
            txtCarName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 32);
            label2.TabIndex = 0;
            label2.Text = "Car Name";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtCarID);
            panel5.Controls.Add(label1);
            panel5.Location = new System.Drawing.Point(8, 23);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(773, 86);
            panel5.TabIndex = 2;
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(198, 22);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(551, 39);
            txtCarID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 32);
            label1.TabIndex = 0;
            label1.Text = "Car ID";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnNew);
            panel4.Controls.Add(btnLoad);
            panel4.Location = new System.Drawing.Point(282, 368);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(1050, 110);
            panel4.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(828, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(150, 64);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(450, 25);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(150, 64);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(72, 25);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(150, 64);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(732, 859);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(150, 64);
            button4.TabIndex = 3;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel10);
            panel3.Location = new System.Drawing.Point(799, 12);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(784, 350);
            panel3.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtReleaseYear);
            panel9.Controls.Add(label5);
            panel9.Location = new System.Drawing.Point(11, 124);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(773, 86);
            panel9.TabIndex = 3;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(198, 22);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(551, 39);
            txtReleaseYear.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(13, 25);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(162, 32);
            label5.TabIndex = 0;
            label5.Text = "Released date";
            // 
            // panel10
            // 
            panel10.Controls.Add(txtPrice);
            panel10.Controls.Add(label6);
            panel10.Location = new System.Drawing.Point(8, 23);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(773, 86);
            panel10.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(201, 22);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(551, 39);
            txtPrice.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(13, 25);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 32);
            label6.TabIndex = 0;
            label6.Text = "Price";
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1592, 935);
            Controls.Add(panel3);
            Controls.Add(button4);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCarManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.ComboBox txtManufacturer;
        private System.Windows.Forms.MaskedTextBox txtReleaseYear;
        private System.Windows.Forms.MaskedTextBox txtPrice;
    }
}