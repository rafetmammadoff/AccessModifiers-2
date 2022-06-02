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
            Employee employee = new Employee();
            Employee employee1 = new Employee();
            Employee employee2= new Employee();
            Employee employee3 = new Employee();
            employee1.NameProp = "Rafet";
            department1.AddEmployee(employee1);
            department1.AddEmployee(employee);
            department1.AddEmployee(employee2);
            department1.AddEmployee(employee3);

            foreach (var item in department1.newArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
