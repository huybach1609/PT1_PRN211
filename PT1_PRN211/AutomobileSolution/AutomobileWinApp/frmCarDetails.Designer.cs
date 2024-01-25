namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            panel6 = new System.Windows.Forms.Panel();
            txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            lbReleaseYear = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            txtPrice = new System.Windows.Forms.MaskedTextBox();
            lbPrice = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            cboManufacturer = new System.Windows.Forms.ComboBox();
            lbManufacturer = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            txtCarName = new System.Windows.Forms.TextBox();
            lbCarName = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            txtCarID = new System.Windows.Forms.TextBox();
            lbCarID = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(793, 736);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(589, 514);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(150, 60);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancle";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(416, 514);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(150, 60);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtReleaseYear);
            panel6.Controls.Add(lbReleaseYear);
            panel6.Location = new System.Drawing.Point(49, 415);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(717, 79);
            panel6.TabIndex = 3;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(167, 22);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(523, 39);
            txtReleaseYear.TabIndex = 3;
            txtReleaseYear.Text = "0";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new System.Drawing.Point(3, 22);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(165, 32);
            lbReleaseYear.TabIndex = 1;
            lbReleaseYear.Text = "Released Date";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtPrice);
            panel5.Controls.Add(lbPrice);
            panel5.Location = new System.Drawing.Point(49, 330);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(720, 79);
            panel5.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(167, 19);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(523, 39);
            txtPrice.TabIndex = 2;
            txtPrice.Text = "0";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(3, 22);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(65, 32);
            lbPrice.TabIndex = 1;
            lbPrice.Text = "Price";
            // 
            // panel4
            // 
            panel4.Controls.Add(cboManufacturer);
            panel4.Controls.Add(lbManufacturer);
            panel4.Location = new System.Drawing.Point(49, 245);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(717, 79);
            panel4.TabIndex = 3;
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Huyndai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new System.Drawing.Point(167, 14);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new System.Drawing.Size(523, 40);
            cboManufacturer.TabIndex = 2;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(3, 22);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(158, 32);
            lbManufacturer.TabIndex = 1;
            lbManufacturer.Text = "Manufacturer";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtCarName);
            panel3.Controls.Add(lbCarName);
            panel3.Location = new System.Drawing.Point(49, 160);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(717, 79);
            panel3.TabIndex = 3;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(167, 19);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(523, 39);
            txtCarName.TabIndex = 2;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(3, 22);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(120, 32);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCarID);
            panel2.Controls.Add(lbCarID);
            panel2.Location = new System.Drawing.Point(49, 75);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(717, 79);
            panel2.TabIndex = 0;
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(167, 19);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(523, 39);
            txtCarID.TabIndex = 2;
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(3, 22);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(79, 32);
            lbCarID.TabIndex = 1;
            lbCarID.Text = "Car ID";
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(789, 778);
            Controls.Add(panel1);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.MaskedTextBox txtReleaseYear;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}