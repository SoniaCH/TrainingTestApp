using System;
using System.Collections.Generic;
using TrainingTestApp.Model;
using System.Text;

namespace TrainingTestApp.Services
{
    public class EmlpoyeeService
    {
        public List<Employee> LoadEmployees()
        {
            var list = new List<Employee>
            {
                new Employee
                {   ImgUrl="m.png", 
                    Name="Mohamed",
                    Departement="Backend" },
                new Employee
                {   ImgUrl="r.png",
                    Name="Refka",
                    Departement="FrontEnd" },
                new Employee
                {   ImgUrl="a.png",
                    Name="Aiman",
                    Departement="Services" },

                new Employee
                {   ImgUrl="s.png",
                    Name="Sonia",
                    Departement="Backend" },
                new Employee
                {   ImgUrl="r.png",
                    Name="Ramzi",
                    Departement="Backend" },
               new Employee
                {   ImgUrl="h.png",
                    Name="Hana",
                    Departement="Backend" },

            };
            return list;
        }

    }
}
