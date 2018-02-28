using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TrainingTestApp.Model;
using TrainingTestApp.Services;

namespace TrainingTestApp.ViewModel
{
    class AdminViewModel : INotifyPropertyChanged
    {
        public List<Admin> _adminList;
        public List<Admin> AdminList
        {
            get { return _adminList; }
            set
            {
                _adminList = value;
                OnPropertyChanged();
            }
        }
        public AdminViewModel()
        {
            var adminService = new AdminServices();
            AdminList = adminService.GetAdmin();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }


}
