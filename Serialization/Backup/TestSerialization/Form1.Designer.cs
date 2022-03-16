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
            this.btnBDSerialize = new System.Windows.Forms.Button();
            this.btnBSerialize = new System.Windows.Forms.Button();
            this.lblBEmpName = new System.Windows.Forms.Label();
            this.lblBEmpCode = new System.Windows.Forms.Label();
            this.txtBEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbEmpCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSDeSerialize = new System.Windows.Forms.Button();
            this.btnSSerialize = new System.Windows.Forms.Button();
            this.lblSEmpName = new System.Windows.Forms.Label();
            this.lblSEmpCode = new System.Windows.Forms.Label();
            this.txtSEmpName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSEmpCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXDeSerialize = new System.Windows.Forms.Button();
            this.btnXSerialize = new System.Windows.Forms.Button();
            this.lblXEmpName = new System.Windows.Forms.Label();
            this.lblXEmpCode = new System.Windows.Forms.Label();
            this.txtXEmpName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtXEmpCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBDSerialize);
            this.groupBox1.Controls.Add(this.btnBSerialize);
            this.groupBox1.Controls.Add(this.lblBEmpName);
            this.groupBox1.Controls.Add(this.lblBEmpCode);
            this.groupBox1.Controls.Add(this.txtBEmpName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbEmpCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBinary);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Binary Serialization";
            // 
            // btnBDSerialize
            // 
            this.btnBDSerialize.AllowDrop = true;
            this.btnBDSerialize.Location = new System.Drawing.Point(304, 71);
            this.btnBDSerialize.Name = "btnBDSerialize";
            this.btnBDSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnBDSerialize.TabIndex = 9;
            this.btnBDSerialize.Text = "De-Serialize";
            this.btnBDSerialize.UseVisualStyleBackColor = true;
            this.btnBDSerialize.Click += new System.EventHandler(this.btnBDSerialize_Click);
            // 
            // btnBSerialize
            // 
            this.btnBSerialize.Location = new System.Drawing.Point(201, 71);
            this.btnBSerialize.Name = "btnBSerialize";
            this.btnBSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnBSerialize.TabIndex = 8;
            this.btnBSerialize.Text = "Serialize";
            this.btnBSerialize.UseVisualStyleBackColor = true;
            this.btnBSerialize.Click += new System.EventHandler(this.btnBSerialize_Click);
            // 
            // lblBEmpName
            // 
            this.lblBEmpName.AutoSize = true;
            this.lblBEmpName.Location = new System.Drawing.Point(181, 45);
            this.lblBEmpName.Name = "lblBEmpName";
            this.lblBEmpName.Size = new System.Drawing.Size(59, 13);
            this.lblBEmpName.TabIndex = 7;
            this.lblBEmpName.Text = "Emp Name";
            // 
            // lblBEmpCode
            // 
            this.lblBEmpCode.AutoSize = true;
            this.lblBEmpCode.Location = new System.Drawing.Point(15, 45);
            this.lblBEmpCode.Name = "lblBEmpCode";
            this.lblBEmpCode.Size = new System.Drawing.Size(56, 13);
            this.lblBEmpCode.TabIndex = 6;
            this.lblBEmpCode.Text = "Emp Code";
            // 
            // txtBEmpName
            // 
            this.txtBEmpName.Location = new System.Drawing.Point(371, 16);
            this.txtBEmpName.Name = "txtBEmpName";
            this.txtBEmpName.Size = new System.Drawing.Size(63, 20);
            this.txtBEmpName.TabIndex = 5;
            this.txtBEmpName.Text = "Binary Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Emp Name";
            // 
            // txtbEmpCode
            // 
            this.txtbEmpCode.Location = new System.Drawing.Point(241, 15);
            this.txtbEmpCode.Name = "txtbEmpCode";
            this.txtbEmpCode.Size = new System.Drawing.Size(63, 20);
            this.txtbEmpCode.TabIndex = 3;
            this.txtbEmpCode.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Emp Code";
            // 
            // txtBinary
            // 
            this.txtBinary.Location = new System.Drawing.Point(75, 13);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(100, 20);
            this.txtBinary.TabIndex = 1;
            this.txtBinary.Text = "binary.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSDeSerialize);
            this.groupBox2.Controls.Add(this.btnSSerialize);
            this.groupBox2.Controls.Add(this.lblSEmpName);
            this.groupBox2.Controls.Add(this.lblSEmpCode);
            this.groupBox2.Controls.Add(this.txtSEmpName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSEmpCode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoap);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SOAP Serialization";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXDeSerialize);
            this.groupBox3.Controls.Add(this.btnXSerialize);
            this.groupBox3.Controls.Add(this.lblXEmpName);
            this.groupBox3.Controls.Add(this.lblXEmpCode);
            this.groupBox3.Controls.Add(this.txtXEmpName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtXEmpCode);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtXml);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XML Serialization";
            // 
            // btnSDeSerialize
            // 
            this.btnSDeSerialize.AllowDrop = true;
            this.btnSDeSerialize.Location = new System.Drawing.Point(300, 68);
            this.btnSDeSerialize.Name = "btnSDeSerialize";
            this.btnSDeSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnSDeSerialize.TabIndex = 19;
            this.btnSDeSerialize.Text = "De-Serialize";
            this.btnSDeSerialize.UseVisualStyleBackColor = true;
            this.btnSDeSerialize.Click += new System.EventHandler(this.btnSDeSerialize_Click);
            // 
            // btnSSerialize
            // 
            this.btnSSerialize.Location = new System.Drawing.Point(197, 68);
            this.btnSSerialize.Name = "btnSSerialize";
            this.btnSSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnSSerialize.TabIndex = 18;
            this.btnSSerialize.Text = "Serialize";
            this.btnSSerialize.UseVisualStyleBackColor = true;
            this.btnSSerialize.Click += new System.EventHandler(this.btnSSerialize_Click);
            // 
            // lblSEmpName
            // 
            this.lblSEmpName.AutoSize = true;
            this.lblSEmpName.Location = new System.Drawing.Point(177, 42);
            this.lblSEmpName.Name = "lblSEmpName";
            this.lblSEmpName.Size = new System.Drawing.Size(59, 13);
            this.lblSEmpName.TabIndex = 17;
            this.lblSEmpName.Text = "Emp Name";
            // 
            // lblSEmpCode
            // 
            this.lblSEmpCode.AutoSize = true;
            this.lblSEmpCode.Location = new System.Drawing.Point(11, 42);
            this.lblSEmpCode.Name = "lblSEmpCode";
            this.lblSEmpCode.Size = new System.Drawing.Size(56, 13);
            this.lblSEmpCode.TabIndex = 16;
            this.lblSEmpCode.Text = "Emp Code";
            // 
            // txtSEmpName
            // 
            this.txtSEmpName.Location = new System.Drawing.Point(367, 13);
            this.txtSEmpName.Name = "txtSEmpName";
            this.txtSEmpName.Size = new System.Drawing.Size(63, 20);
            this.txtSEmpName.TabIndex = 15;
            this.txtSEmpName.Text = "Soap Test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Emp Name";
            // 
            // txtSEmpCode
            // 
            this.txtSEmpCode.Location = new System.Drawing.Point(237, 12);
            this.txtSEmpCode.Name = "txtSEmpCode";
            this.txtSEmpCode.Size = new System.Drawing.Size(63, 20);
            this.txtSEmpCode.TabIndex = 13;
            this.txtSEmpCode.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Emp Code";
            // 
            // txtSoap
            // 
            this.txtSoap.Location = new System.Drawing.Point(71, 10);
            this.txtSoap.Name = "txtSoap";
            this.txtSoap.Size = new System.Drawing.Size(100, 20);
            this.txtSoap.TabIndex = 11;
            this.txtSoap.Text = "SoapFile.txt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "File Name";
            // 
            // btnXDeSerialize
            // 
            this.btnXDeSerialize.AllowDrop = true;
            this.btnXDeSerialize.Location = new System.Drawing.Point(300, 68);
            this.btnXDeSerialize.Name = "btnXDeSerialize";
            this.btnXDeSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnXDeSerialize.TabIndex = 29;
            this.btnXDeSerialize.Text = "De-Serialize";
            this.btnXDeSerialize.UseVisualStyleBackColor = true;
            this.btnXDeSerialize.Click += new System.EventHandler(this.btnXDeSerialize_Click);
            // 
            // btnXSerialize
            // 
            this.btnXSerialize.Location = new System.Drawing.Point(197, 68);
            this.btnXSerialize.Name = "btnXSerialize";
            this.btnXSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnXSerialize.TabIndex = 28;
            this.btnXSerialize.Text = "Serialize";
            this.btnXSerialize.UseVisualStyleBackColor = true;
            this.btnXSerialize.Click += new System.EventHandler(this.btnXSerialize_Click);
            // 
            // lblXEmpName
            // 
            this.lblXEmpName.AutoSize = true;
            this.lblXEmpName.Location = new System.Drawing.Point(177, 42);
            this.lblXEmpName.Name = "lblXEmpName";
            this.lblXEmpName.Size = new System.Drawing.Size(59, 13);
            this.lblXEmpName.TabIndex = 27;
            this.lblXEmpName.Text = "Emp Name";
            // 
            // lblXEmpCode
            // 
            this.lblXEmpCode.AutoSize = true;
            this.lblXEmpCode.Location = new System.Drawing.Point(11, 42);
            this.lblXEmpCode.Name = "lblXEmpCode";
            this.lblXEmpCode.Size = new System.Drawing.Size(56, 13);
            this.lblXEmpCode.TabIndex = 26;
            this.lblXEmpCode.Text = "Emp Code";
            // 
            // txtXEmpName
            // 
            this.txtXEmpName.Location = new System.Drawing.Point(367, 13);
            this.txtXEmpName.Name = "txtXEmpName";
            this.txtXEmpName.Size = new System.Drawing.Size(63, 20);
            this.txtXEmpName.TabIndex = 25;
            this.txtXEmpName.Text = "Xml Test";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Emp Name";
            // 
            // txtXEmpCode
            // 
            this.txtXEmpCode.Location = new System.Drawing.Point(237, 12);
            this.txtXEmpCode.Name = "txtXEmpCode";
            this.txtXEmpCode.Size = new System.Drawing.Size(63, 20);
            this.txtXEmpCode.TabIndex = 23;
            this.txtXEmpCode.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Emp Code";
            // 
            // txtXml
            // 
            this.txtXml.Location = new System.Drawing.Point(71, 10);
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(100, 20);
            this.txtXml.TabIndex = 21;
            this.txtXml.Text = "XmlFile.txt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "File Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 413);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBEmpName;
        private System.Windows.Forms.Label lblBEmpCode;
        private System.Windows.Forms.Button btnBSerialize;
        private System.Windows.Forms.Button btnBDSerialize;
        private System.Windows.Forms.Button btnSDeSerialize;
        private System.Windows.Forms.Button btnSSerialize;
        private System.Windows.Forms.Label lblSEmpName;
        private System.Windows.Forms.Label lblSEmpCode;
        private System.Windows.Forms.TextBox txtSEmpName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSEmpCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXDeSerialize;
        private System.Windows.Forms.Button btnXSerialize;
        private System.Windows.Forms.Label lblXEmpName;
        private System.Windows.Forms.Label lblXEmpCode;
        private System.Windows.Forms.TextBox txtXEmpName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtXEmpCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.Label label11;

    }
}

