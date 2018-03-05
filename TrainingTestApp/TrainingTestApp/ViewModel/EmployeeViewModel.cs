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
using System.Collections.ObjectModel;
using System.Linq;

namespace TrainingTestApp.ViewModel
{
    public class EmployeeViewModel:INotifyPropertyChanged
    {
        

        #region handling the changes of the property
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
        #endregion

        
        #region handling the Item to select from the list
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

            Application.Current.MainPage.Navigation.PushModalAsync(new PopUpPage(_selectedEmployee.Name, _selectedEmployee.Departement, _selectedEmployee.ImgUrl));

        }
        #endregion

        //step1: add an attribute for word to search
        private string _searchText = string.Empty;

        public string SearchText

        {

            get
            {
                return _searchText;
            }

            set
            {
                if (_searchText != value)
                {
                    _searchText = value ?? string.Empty;
                    // RaisePropertyChanged();
                    // RaisePropertyChanged(() => SearchText);
                    OnPropertyChanged();
                    // Perform the search

                    if (SearchCommand.CanExecute(null))

                    {

                        SearchCommand.Execute(null);

                    }
                }
            }

        }

        private ObservableCollection<Employee> _employeesListAll;
        public ObservableCollection<Employee> EmployeesListAll
        {
            get
            {
                ObservableCollection<Employee> _employeesListFound = new ObservableCollection<Employee>();
                if (_employeesListAll != null)
                {

                    List<Employee> entities = (from e in _employeesListAll where e.Name.Contains(_searchText) select e).ToList();

                    if (entities != null && entities.Any())

                    {

                        _employeesListFound = new ObservableCollection<Employee>(entities);

                    }
                }
                return _employeesListFound;
            }
            set
            {
                _employeesListAll = value;
                OnPropertyChanged();
            }
        }

        // OnResearch

        //step 2: create the command method for searching

        #region Command and associated methods for SearchCommand

        private Command _searchCommand;

        public ICommand SearchCommand

        {

            get

            {

                _searchCommand = _searchCommand ?? new Xamarin.Forms.Command(DoSearchCommand, CanExecuteSearchCommand);

                return _searchCommand;

            }

        }

        private void DoSearchCommand()

        {

            // Refresh the list, which will automatically apply the search text

            //RaisePropertyChanged(() => YourList);
            OnPropertyChanged();

        }

        private bool CanExecuteSearchCommand()

        {

            return true;

        }

        #endregion


        #region Constructer
        public EmployeeViewModel()
        {
            EmployeesListAll = new EmlpoyeeService().LoadEmployees();
        }


   

        // constructer with an employee information
        public EmployeeViewModel(Employee _selectedEmployee)
        {
            EmployeesListAll = new EmlpoyeeService().LoadEmployees();
            this.SelectedEmployee = _selectedEmployee;
        }
        #endregion






    }



}

