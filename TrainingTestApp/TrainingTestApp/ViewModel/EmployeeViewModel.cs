using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using TrainingTestApp.Model;
using TrainingTestApp.Services;
using TrainingTestApp.View;
using System.Windows.Input;
using Xamarin.Forms;
using System.Diagnostics;

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

        private Employee _selectedEmployee;
        public Employee SelectedEmployee
        {
            get
            {
                return _selectedEmployee;
            }
            set
            {
                if (_selectedEmployee != value)
                {
                    _selectedEmployee = value;
                    HandleSelectedItem();
                }
            }
        }

        private void HandleSelectedItem() {

            Application.Current.MainPage.Navigation.PushModalAsync(new AuthentificationPage());

        }


        private List<Employee> _employeesList;
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
            EmployeesList = new EmlpoyeeService().LoadEmployees();
        }


        protected virtual void OnPropertyChanged(string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


     
       

        //public ICommand ItemClickCommand
        //{
        //    get
        //    {
        //        return new Command((Item) =>
        //        {
        //            Application.Current.MainPage.Navigation.PushModalAsync(new AuthentificationPage());

        //        }
        //        );
        //    }
        //}


    }



    }

