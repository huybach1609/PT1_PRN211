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
            lbCarId = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            textBox2 = new System.Windows.Forms.TextBox();
            car = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lbCarId);
            panel1.Location = new System.Drawing.Point(46, 52);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(767, 90);
            panel1.TabIndex = 0;
            // 
            // lbCarId
            // 
            lbCarId.AutoSize = true;
            lbCarId.Location = new System.Drawing.Point(3, 27);
            lbCarId.Name = "lbCarId";
            lbCarId.Size = new System.Drawing.Size(79, 32);
            lbCarId.TabIndex = 0;
            lbCarId.Text = "Car ID";
            lbCarId.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(180, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(551, 39);
            textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(car);
            panel2.Location = new System.Drawing.Point(46, 157);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(767, 90);
            panel2.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(180, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(551, 39);
            textBox2.TabIndex = 1;
            // 
            // car
            // 
            car.AutoSize = true;
            car.Location = new System.Drawing.Point(3, 27);
            car.Name = "car";
            car.Size = new System.Drawing.Size(120, 32);
            car.TabIndex = 0;
            car.Text = "Car Name";
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new System.Drawing.Point(46, 268);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(767, 90);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(158, 32);
            label2.TabIndex = 0;
            label2.Text = "Manufacturer";
            // 
            // panel4
            // 
            panel4.Controls.Add(maskedTextBox2);
            panel4.Controls.Add(label3);
            panel4.Location = new System.Drawing.Point(46, 377);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(767, 90);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 27);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 32);
            label3.TabIndex = 0;
            label3.Text = "Price";
            // 
            // panel5
            // 
            panel5.Controls.Add(maskedTextBox1);
            panel5.Controls.Add(label4);
            panel5.Location = new System.Drawing.Point(46, 485);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(767, 90);
            panel5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 27);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(160, 32);
            label4.TabIndex = 0;
            label4.Text = "Released year";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(180, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(551, 40);
            comboBox1.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new System.Drawing.Point(180, 24);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new System.Drawing.Size(551, 39);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.Text = "2000";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new System.Drawing.Point(180, 27);
            maskedTextBox2.Mask = "00000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new System.Drawing.Size(551, 39);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.Text = "0";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(217, 624);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(150, 70);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(453, 624);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(150, 70);
            button2.TabIndex = 4;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(859, 725);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCarDetails";
            Text = "Car Detail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCarId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label car;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}