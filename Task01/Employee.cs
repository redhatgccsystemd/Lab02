using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Task01
{
    class Employee
    {
        public Employee(string name, string surname, string patronymic, char gender, DateTime birthday, DateTime employmentDate, Company company)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Gender = gender;
            Birthday = birthday;
            EmploymentDate = employmentDate;
            Company = company;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public char Gender { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime EmploymentDate { get; set; }
        public Company Company { get; set; }
    }

    
}
