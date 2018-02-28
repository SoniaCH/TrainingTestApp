using System;
using System.Collections.Generic;
using System.Text;
using TrainingTestApp.Model;

namespace TrainingTestApp.Services
{
    class AdminServices
    {
        public List<Admin> GetAdmin()
        {
            var list = new List<Admin>
            {
                new Admin
                {
                    Username="Mohamed",
                    Password="Backend" },
                new Admin
                {
                    Username="Refka",
                    Password="FrontEnd" },                 
            };
            return list;
        }
    }
}
