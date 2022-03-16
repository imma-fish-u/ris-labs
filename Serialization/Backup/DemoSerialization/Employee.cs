using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DemoSerialization
{
    [Serializable]
    public class Employee
    {
        public int empCode;
        public string empName;

        [XmlAttribute("empName")]
        public string EmpName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }

    }

}
