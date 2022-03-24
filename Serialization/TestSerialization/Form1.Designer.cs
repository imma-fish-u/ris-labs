namespace TestSerialization
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbEmpEnd = new System.Windows.Forms.TextBox();
            this.btnBDSerialize = new System.Windows.Forms.Button();
            this.txtbEmpStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBSerialize = new System.Windows.Forms.Button();
            this.txtBEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbEmpCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBEmpName = new System.Windows.Forms.Label();
            this.lblBEmpCode = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBEmpEnd = new System.Windows.Forms.Label();
            this.lblBEmpStart = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtbEmpEnd);
            this.groupBox1.Controls.Add(this.btnBDSerialize);
            this.groupBox1.Controls.Add(this.txtbEmpStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBSerialize);
            this.groupBox1.Controls.Add(this.txtBEmpName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbEmpCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBinary);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(587, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serialization";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(469, 82);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtbEmpEnd
            // 
            this.txtbEmpEnd.Location = new System.Drawing.Point(324, 85);
            this.txtbEmpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtbEmpEnd.Name = "txtbEmpEnd";
            this.txtbEmpEnd.Size = new System.Drawing.Size(116, 22);
            this.txtbEmpEnd.TabIndex = 12;
            // 
            // btnBDSerialize
            // 
            this.btnBDSerialize.AllowDrop = true;
            this.btnBDSerialize.Location = new System.Drawing.Point(32, 91);
            this.btnBDSerialize.Margin = new System.Windows.Forms.Padding(4);
            this.btnBDSerialize.Name = "btnBDSerialize";
            this.btnBDSerialize.Size = new System.Drawing.Size(100, 28);
            this.btnBDSerialize.TabIndex = 9;
            this.btnBDSerialize.Text = "De-Serialize";
            this.btnBDSerialize.UseVisualStyleBackColor = true;
            this.btnBDSerialize.Click += new System.EventHandler(this.btnBDSerialize_Click);
            // 
            // txtbEmpStart
            // 
            this.txtbEmpStart.Location = new System.Drawing.Point(324, 55);
            this.txtbEmpStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtbEmpStart.Name = "txtbEmpStart";
            this.txtbEmpStart.Size = new System.Drawing.Size(116, 22);
            this.txtbEmpStart.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sickleave end";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sickleave start";
            // 
            // btnBSerialize
            // 
            this.btnBSerialize.Location = new System.Drawing.Point(32, 55);
            this.btnBSerialize.Margin = new System.Windows.Forms.Padding(4);
            this.btnBSerialize.Name = "btnBSerialize";
            this.btnBSerialize.Size = new System.Drawing.Size(100, 28);
            this.btnBSerialize.TabIndex = 8;
            this.btnBSerialize.Text = "Serialize";
            this.btnBSerialize.UseVisualStyleBackColor = true;
            this.btnBSerialize.Click += new System.EventHandler(this.btnBSerialize_Click);
            // 
            // txtBEmpName
            // 
            this.txtBEmpName.Location = new System.Drawing.Point(484, 17);
            this.txtBEmpName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBEmpName.Name = "txtBEmpName";
            this.txtBEmpName.Size = new System.Drawing.Size(95, 22);
            this.txtBEmpName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Emp Name";
            // 
            // txtbEmpCode
            // 
            this.txtbEmpCode.Location = new System.Drawing.Point(297, 17);
            this.txtbEmpCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtbEmpCode.Name = "txtbEmpCode";
            this.txtbEmpCode.Size = new System.Drawing.Size(83, 22);
            this.txtbEmpCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Emp Code";
            // 
            // txtBinary
            // 
            this.txtBinary.Location = new System.Drawing.Point(100, 16);
            this.txtBinary.Margin = new System.Windows.Forms.Padding(4);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(102, 22);
            this.txtBinary.TabIndex = 1;
            this.txtBinary.Text = "binary.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // lblBEmpName
            // 
            this.lblBEmpName.AutoSize = true;
            this.lblBEmpName.Location = new System.Drawing.Point(125, 60);
            this.lblBEmpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBEmpName.Name = "lblBEmpName";
            this.lblBEmpName.Size = new System.Drawing.Size(0, 17);
            this.lblBEmpName.TabIndex = 7;
            // 
            // lblBEmpCode
            // 
            this.lblBEmpCode.AutoSize = true;
            this.lblBEmpCode.Location = new System.Drawing.Point(18, 60);
            this.lblBEmpCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBEmpCode.Name = "lblBEmpCode";
            this.lblBEmpCode.Size = new System.Drawing.Size(0, 17);
            this.lblBEmpCode.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblBEmpEnd);
            this.groupBox2.Controls.Add(this.lblBEmpStart);
            this.groupBox2.Controls.Add(this.lblBEmpCode);
            this.groupBox2.Controls.Add(this.lblBEmpName);
            this.groupBox2.Location = new System.Drawing.Point(16, 159);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(587, 136);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deserialization";
            // 
            // lblBEmpEnd
            // 
            this.lblBEmpEnd.AutoSize = true;
            this.lblBEmpEnd.Location = new System.Drawing.Point(354, 60);
            this.lblBEmpEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBEmpEnd.Name = "lblBEmpEnd";
            this.lblBEmpEnd.Size = new System.Drawing.Size(0, 17);
            this.lblBEmpEnd.TabIndex = 13;
            // 
            // lblBEmpStart
            // 
            this.lblBEmpStart.AutoSize = true;
            this.lblBEmpStart.Location = new System.Drawing.Point(231, 60);
            this.lblBEmpStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBEmpStart.Name = "lblBEmpStart";
            this.lblBEmpStart.Size = new System.Drawing.Size(0, 17);
            this.lblBEmpStart.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Emp Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Emp Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sickleave start";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sickleave end";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbEmpCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBEmpName;
        private System.Windows.Forms.Label lblBEmpCode;
        private System.Windows.Forms.Button btnBSerialize;
        private System.Windows.Forms.Button btnBDSerialize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbEmpEnd;
        private System.Windows.Forms.TextBox txtbEmpStart;
        private System.Windows.Forms.Label lblBEmpEnd;
        private System.Windows.Forms.Label lblBEmpStart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

