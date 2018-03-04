using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TrainingTestApp.Model;

namespace TrainingTestApp.Services
{
    public class AdminServices
    {
        public static ObservableCollection<Admin> GetAdmin()
        {
            var list = new ObservableCollection<Admin>
            {
                new Admin
                {
                    Username="s",
                    Password="s" },
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
