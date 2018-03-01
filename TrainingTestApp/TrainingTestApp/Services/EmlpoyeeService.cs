using System;
using System.Collections.Generic;
using TrainingTestApp.Model;
using System.Text;

namespace TrainingTestApp.Services
{
    public class EmlpoyeeService
    {
        public static List<Employee> LoadEmployees()
        {
            var list = new List<Employee>
            {
                new Employee
                {
                    Name="Mohamed",
                    Departement="Backend" },
                new Employee
                {
                    Name="Refka",
                    Departement="FrontEnd" },
                new Employee
                {
                    Name="Aiman",
                    Departement="Services" },

                new Employee
                {
                    Name="Sonia",
                    Departement="Backend" },
                new Employee
                {
                    Name="Ramzi",
                    Departement="Backend" },
               new Employee
                {
                    Name="Hana",
                    Departement="Backend" },

            };
            return list;
        }

    }
}
