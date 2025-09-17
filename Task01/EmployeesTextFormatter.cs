using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task01
{
    class EmployeesTextFormatter
    {
        public static void Serialize(IList<Employee> employees)
        {

        }
        public static void Serialize(IList<Employee> employees, StreamWriter employeesWriter, StreamWriter companiesWriter)
        {
            HashSet<Company> companies = new HashSet<Company>();

            foreach(var employee in employees)
            {
                if (!companies.Contains(employee.Company))
                {
                    companies.Add(employee.Company);
                }
                employeesWriter.Write(employee.Name);
                employeesWriter.Write(' ');
                employeesWriter.Write(employee.Surname);
                employeesWriter.Write(' ');
                employeesWriter.Write(employee.Patronymic);
                employeesWriter.Write(' ');
                employeesWriter.Write(employee.Gender);
                employeesWriter.Write(' ');
                employeesWriter.Write(employee.Birthday);
                employeesWriter.Write(' ');
                employeesWriter.Write(employee.EmploymentDate);
                employeesWriter.Write(' ');
                employeesWriter.Write(employee.Company.Name);
                employeesWriter.Write('\n');
            }
            foreach (var company in companies)
            {
                companiesWriter.Write(company.Name);
                employeesWriter.Write(' ');
                companiesWriter.Write(company.Code);
                employeesWriter.Write('\n');
            }
        }
        public static void Deserialize(IList<Employee> employees, StreamWriter employeesWriter, StreamWriter companiesWriter)
        {
            HashSet<Company> companies = new HashSet<Company>();

            foreach (var employee in employees)
            {
                if (!companies.Contains(employee.Company))
                {
                    companies.Add(employee.Company);
                }
                employeesWriter.Write(employee.Name);
                employeesWriter.Write(' ');
                employeesWriter.Write(employee.Surname);
                employeesWriter.Write(' ');
                employeesWriter.Write(employee.Patronymic);
                employeesWriter.Write(' ');
                employeesWriter.Write(employee.Gender);
                employeesWriter.Write(' ');
                employeesWriter.Write(employee.Birthday);
                employeesWriter.Write(' ');
                employeesWriter.Write(employee.EmploymentDate);
                employeesWriter.Write(' ');
                employeesWriter.Write(employee.Company.Name);
                employeesWriter.Write('\n');
            }
            foreach (var company in companies)
            {
                companiesWriter.Write(company.Name);
                employeesWriter.Write(' ');
                companiesWriter.Write(company.Code);
                employeesWriter.Write('\n');
            }
        }
    }
}
