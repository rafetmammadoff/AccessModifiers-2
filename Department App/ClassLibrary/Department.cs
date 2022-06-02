using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Department
    {
        public string Name;
        protected int _salaryLimit=250;
        private int _employeeLimit=20;
        private Employee[] employees=new Employee[0];

        public void AddEmployee(Employee employe)
        {
            if (employees.Length<_employeeLimit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employe;
            }
            
        }
        public Employee[] newArr
        {
            get { return employees; }
        }




    }
}
