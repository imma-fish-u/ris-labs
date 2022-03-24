using System;
using System.Collections;

namespace DemoSerialization
{
    [Serializable]
    public class Employee
    {
        public int empCode;
        public string empName;
        public string empStart;
        public string empEnd;

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

        public string EmpStart
        {
            get
            {
                return empStart;
            }
            set
            {
                if (DateTime.TryParse(value, out DateTime dateTime))
                {
                    empStart = value;
                }
            }
        }

        public string EmpEnd
        {
            get
            {
                return empEnd;
            }
            set
            {
                if (DateTime.TryParse(value, out DateTime dateTime))
                {
                    empEnd = value;
                }
            }
        }
    }

    [Serializable]
    public class Employees : CollectionBase
    {
        public Employees()
        {
        }

        public void Add(Employee objT)
        {
            this.List.Add(objT);
        }

        public Employee this[int i]
        {
            get
            {
                return (Employee)this.List[i];
            }
            set
            {
                this.List.Add(value);
            }
        }

    }

}
