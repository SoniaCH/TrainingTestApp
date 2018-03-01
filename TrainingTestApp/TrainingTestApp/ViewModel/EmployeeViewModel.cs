using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using TrainingTestApp.Model;
using TrainingTestApp.Services;
using TrainingTestApp.View;

namespace TrainingTestApp.ViewModel
{
    class EmployeeViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Step 1: to identify all the properties of the class 
        /// Step 2: create the constructer of the class
        /// Step 4: load data from the service admin data 
        /// Step 5: create the method needed
        /// </summary>
        /// 

        //use employee entity
        public List<Employee> _employeesList;
        public List<Employee> EmployeesList
        {
            get { return _employeesList; }
            set
            {
                _employeesList = value;
                OnPropertyChanged();
            }
        }
        public EmployeeViewModel()
        {
            // List<Employee> _employeesList = EmlpoyeeService.LoadEmployees();
            EmployeesList = new EmlpoyeeService().LoadEmployees();

        }


        protected virtual void OnPropertyChanged(string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }






    }
}
