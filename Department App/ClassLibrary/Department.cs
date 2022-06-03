using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Department
    {
        public string Name;
        private int _salaryLimit=25000;
        private int _employeeLimit=20;
        private Employee[] employees=new Employee[0];

        public void AddEmployee(Employee employe)
        {
            int sumSalary = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                sumSalary += employees[i].Salary;
            }

            if (employees.Length<_employeeLimit && sumSalary+employe.Salary<=_salaryLimit)
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
