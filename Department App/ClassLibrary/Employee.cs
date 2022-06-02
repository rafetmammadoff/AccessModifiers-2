using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Employee

    {
        private string _name;
        private string _surname;
        private int _salary;

        public string NameProp
        {
            get => _name;

            set
            {   
                bool check=false;
                if (!String.IsNullOrWhiteSpace(value) && Char.IsUpper(value[0]))
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (Char.IsLetter(value[i]))
                        {
                            check = true;
                            continue;
                        }
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    _name = value;
                }
                    
            }
        }

        public string SurName
        {
            get => _surname;

            set
            {
                bool check = false;
                if (!String.IsNullOrWhiteSpace(value) && Char.IsUpper(value[0]))
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (Char.IsLetter(value[i]))
                        {
                            check = true;
                            continue;
                        }
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    _surname = value;
                }

            }
        }

        public int Salary
        {
            get => _salary; 
            set
            {
                if (value>=250) //Burda 250 eveezine SalaryLimit istifade etmek ucun employe departmentden miras almalidir
                {                    // Buda duzgun deyil. Isci bir bina deyilS
                    _salary = value;
                }
            }
        }
    }
}
