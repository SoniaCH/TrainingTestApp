using System;
using System.Collections.Generic;
using System.Text;
using TrainingTestApp.Model;

namespace TrainingTestApp.Services
{
    public class AdminServices
    {
        public static List<Admin> GetAdmin()
        {
            var list = new List<Admin>
            {
                new Admin
                {
                    Username="Sonia",
                    Password="Backend" },
                new Admin
                {
                    Username="Hana",
                    Password="Backend" },
                 new Admin
                {
                    Username="Ramzi",
                    Password="Backend" },
                  new Admin
                {
                    Username="Imed",
                    Password="Backend" },
            };
            return list;
        }
    }
}
