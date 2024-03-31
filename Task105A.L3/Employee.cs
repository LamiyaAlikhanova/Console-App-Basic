using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task105A.L3
{
    internal class Employee
    {
        public string Name;
        public string Surname;
        private double _age;
        public double Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (_age > 0)
                {
                    _age = value;
                }
            }
        }
        private double _salary;
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (_salary > 0)
                {
                    _salary = value;
                }
            }
        }
        public string DepartmentName;
        public Employee() { }

        public Employee(string name, string surname, double age, double salary, string departmentName)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            DepartmentName = departmentName;
        }

    }
}
