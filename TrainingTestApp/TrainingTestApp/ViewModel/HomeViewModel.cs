using System;
using System.Collections.Generic;
using System.Text;
using TrainingTestApp.View;
using TrainingTestApp.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using TrainingTestApp.Services;

namespace TrainingTestApp.ViewModel
{
    class HomeViewModel: MasterDetailPage,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Pages _selectedPage;
        public Pages SelectedPage
        {
            get
            {
                return _selectedPage;
            }
            set
            {
                if (_selectedPage != value)
                {
                    _selectedPage = value;
                    GoToPage(_selectedPage);
                }
            }
        }

       

        private void GoToPage(Pages _selectedPage)
        {
            if (_selectedPage.NameOfPage == "Root Employees")
            {
                //Detail = new EmployeeViewPage();
                //IsPresented = false;
                Application.Current.MainPage.Navigation.PushModalAsync(new EmployeeViewPage());
            }

            else
            {
                //Detail = new InscriptionViewPage();
                //IsPresented = false;
                Application.Current.MainPage.Navigation.PushModalAsync(new InscriptionViewPage());
            }
        }

        private List<Pages> pageList;
        public List<Pages> PageList
        {
            get { return pageList; }
            set
            {
                pageList = value;
                OnPropertyChanged();
            }
        }

        // constructer with an employee information
        public HomeViewModel(Pages _selectedPage)
        {
            PageList = new PagesServices().LoadTheListOfPages();
            this.SelectedPage = _selectedPage;
            // configure the TapCommand with a method


        }

        public HomeViewModel()
        {
            PageList = new PagesServices().LoadTheListOfPages();
        }

        protected virtual void OnPropertyChanged(string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }



    }


}
