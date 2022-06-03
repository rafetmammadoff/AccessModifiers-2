using ClassLibrary;
using System;

namespace AccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Employee class
                // - Name
                // - Surname
                // - Salary

                //   Department class
                // - Name
                // - EmployeeLimit
                // - SalaryLimit 
                // - Employees
                // - AddEmployee()

                //Employee ve Department classlarını ClassLibrary-de yazın
                //Employee Name və Surname dəyərləri yalnız hərflərdən ibarət olmalıdır və Böyük hərflə başlamalıdır
                //Salary dəyəri 250-dən aşağı ola bilməz
                //AddEmployee metodu employees array-e employee obyekti əlavə etmək üçündür.

            Department department1 =new Department();
            Employee employee = new Employee(300);
            Employee employee1 = new Employee(2320);
            Employee employee2= new Employee(280);
            Employee employee3 = new Employee(300);
            employee1.NameProp = "Rafet";
            employee2.NameProp = "Nurlan";
            employee3.NameProp = "Eli";
            employee.NameProp = "Hiss";
            department1.AddEmployee(employee1);
            department1.AddEmployee(employee);
            department1.AddEmployee(employee2);
            department1.AddEmployee(employee3);
            Employee employee4 = new Employee(7654);
            employee4.NameProp = "Rich";
            department1.AddEmployee(employee4);

            foreach (var item in department1.newArr)
            {
                Console.WriteLine(item.NameProp);
            }
        }
    }
}
