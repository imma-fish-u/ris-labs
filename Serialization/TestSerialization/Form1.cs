using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DemoSerialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace TestSerialization
{
    public partial class Form1 : Form
    {
        private Employees emps = new Employees(); 

        public Form1()
        {
            InitializeComponent();
            emps = (Employees)BinaryDeserialize("binary.txt");
        }
        #region Binary

        private void btnBSerialize_Click(object sender, EventArgs e)
        {
            BinarySerialize(txtBinary.Text, emps);
            MessageBox.Show("Binary Serialize Done!");
        }

        private void btnBDSerialize_Click(object sender, EventArgs e)
        {
            Employees emps = (Employees)BinaryDeserialize(txtBinary.Text);
            lblBEmpCode.Text = "";
            lblBEmpName.Text = "";
            lblBEmpStart.Text = "";
            lblBEmpEnd.Text = "";

            foreach (Employee emp in emps)
            {
                lblBEmpCode.Text += Convert.ToString(emp.empCode) + "\n";
                lblBEmpName.Text += emp.EmpName + "\n";
                lblBEmpStart.Text += emp.EmpStart + "\n";
                lblBEmpEnd.Text += emp.EmpEnd + "\n";
            }

        }
        public void BinarySerialize(string filename, Employees emps)
        {
            FileStream fileStreamObject;
            fileStreamObject = new FileStream(filename, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStreamObject, emps);
            fileStreamObject.Close();

        }
        public static object BinaryDeserialize(string filename)
        {
            FileStream fileStreamObject = new FileStream(filename, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Employees emps = (Employees)binaryFormatter.Deserialize(fileStreamObject);
            fileStreamObject.Close();
            return emps;
        }

        #endregion

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.empCode = Convert.ToInt16(txtbEmpCode.Text);
            emp.EmpName = txtBEmpName.Text;
            emp.EmpStart = txtbEmpStart.Text;
            emp.EmpEnd = txtbEmpEnd.Text;
            txtbEmpCode.Text = "";
            txtBEmpName.Text = "";
            txtbEmpStart.Text = "";
            txtbEmpEnd.Text = "";
            emps.Add(emp);
        }
    }
}