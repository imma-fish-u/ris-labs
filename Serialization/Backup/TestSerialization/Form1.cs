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
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;


namespace TestSerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Binary

        private void btnBSerialize_Click(object sender, EventArgs e)
        {
            Employee emp=new Employee();
            emp.empCode=Convert.ToInt16(txtbEmpCode.Text);
            emp.EmpName=txtBEmpName.Text;
            BinarySerialize(txtBinary.Text, emp);
            MessageBox.Show("Binary Serialize Done!");
        }

        private void btnBDSerialize_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp = (Employee)BinaryDeserialize(txtBinary.Text);
            lblBEmpCode.Text ="Emp Code:" + Convert.ToString(emp.empCode);
            lblBEmpName.Text = "Emp Name:" + emp.EmpName;

        }
        public void BinarySerialize(string filename, Employee emp)
        {
            FileStream fileStreamObject;
            fileStreamObject = new FileStream(filename, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStreamObject, emp);
            fileStreamObject.Close();

        }
        public static object BinaryDeserialize(string filename)
        {
            FileStream fileStreamObject = new FileStream(filename, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            object obj = (object)binaryFormatter.Deserialize(fileStreamObject);
            fileStreamObject.Close();
            return obj;
        }
         #endregion

        #region SOAP
            
        private void btnSSerialize_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.empCode = Convert.ToInt16(txtSEmpCode.Text);
            emp.EmpName = txtSEmpName.Text;
            SOAPSerialize(txtSoap.Text, emp);
            MessageBox.Show("SOAP Serialize Done!");
        }
       

        private void btnSDeSerialize_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp = (Employee)SOAPDeserialize(txtSoap.Text);
            lblSEmpCode.Text = "Emp Code:" + Convert.ToString(emp.empCode);
            lblSEmpName.Text = "Emp Name:" + emp.EmpName;
        }
        public void SOAPSerialize(string filename, Employee employeeObject)
        {
            FileStream fileStreamObject = new FileStream(filename, FileMode.Create);
            SoapFormatter soapFormatter = new SoapFormatter();
            soapFormatter.Serialize(fileStreamObject, employeeObject);
            fileStreamObject.Close();
        }
        public static object SOAPDeserialize(string filename)
        {
            FileStream fileStreamObject = new FileStream(filename, FileMode.Open);
            SoapFormatter soapFormatter = new SoapFormatter();
            object obj = (object)soapFormatter.Deserialize(fileStreamObject);
            fileStreamObject.Close();
            return obj;
        }
        #endregion
        #region Xml

        private void btnXSerialize_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.empCode = Convert.ToInt16(txtXEmpCode.Text);
            emp.EmpName = txtXEmpName.Text;
            XMLSerialize(txtXml.Text, emp);
            MessageBox.Show("Xml Serialize Done!");
        }
        private void btnXDeSerialize_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp = (Employee)XMLDeserialize(txtXml.Text);
            lblXEmpCode.Text = "Emp Code:" + Convert.ToString(emp.empCode);
            lblXEmpName.Text = "Emp Name:" + emp.EmpName;
        }
        public void XMLSerialize(String filename, Employee emp)
        {
            XmlSerializer serializer = null;
            FileStream stream = null;
            serializer = new XmlSerializer(typeof(Employee));
            stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            serializer.Serialize(stream, emp);
            if (stream != null)
                stream.Close();
        }
        public static Employee XMLDeserialize(String filename)
        {
            XmlSerializer serializer = null;
            FileStream stream = null;
            Employee emp = new Employee();
            serializer = new XmlSerializer(typeof(Employee));
            stream = new FileStream(filename, FileMode.Open);
            emp = (Employee)serializer.Deserialize(stream);
            if (stream != null)
                stream.Close();

            return emp;
        }
        #endregion

       

    }
}