using System;
using System.Collections.Generic;
using System.Text;
using TrainingTestApp.Model;

namespace TrainingTestApp.Services
{
    class PagesServices
    {
        // create a list for the pages
        List<Pages> _pages = new List<Pages>();

        // load the list for the pages that I want to add the to the menu
        public List<Pages> LoadTheListOfPages()
        {
            _pages.Add(new Pages() { NameOfPage = "Root Employees", IconUrl = "eml.ico" });
            _pages.Add(new Pages() { NameOfPage = "Inscription ", IconUrl = "adduser.ico" });
            return _pages;
        }
    }
}
