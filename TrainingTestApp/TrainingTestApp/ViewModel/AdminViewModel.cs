﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Diagnostics;
using System.Windows.Input;
using TrainingTestApp.Model;
using TrainingTestApp.Services;
using TrainingTestApp.View;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace TrainingTestApp.ViewModel
{
    public class AdminViewModel : INotifyPropertyChanged
    {

        public Action DisplayInvalidLoginPrompt;// display alerte

        public Action DisplayValidLoginPrompt;

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Step 1: to identify all the properties of the class 
        /// Step 2: create the constructer of the class
        /// Step 4: load data from the service admin data 
        /// Step 5: create the method needed
        /// </summary>
       #region defining the atribute 
        // Step 1:
        // the First property to be recovered from the UI
        private String username;
        public String Username //paramètre de Binding au niveau du view
        {
            get { return username; }
            set
            {
                username = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Username"));
            }
        }

        //The second property to be recovered from the UI
        private String password;
        public String Password //paramètre de Binding au niveau du view
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        #endregion

        #region the function to enter the home page 
        public ICommand SubmitCommand
        { protected set; get; }

        public AdminViewModel() {

            SubmitCommand = new Command(OnSubmit);
        }


        
        public  void OnSubmit()
        {
            // Loading the datas of the admin from services
            ObservableCollection<Admin>  adminDatas = AdminServices.GetAdmin();
            int i = 0;
            bool exist = false;

            while (exist==false && i < adminDatas.Count) {
                if (username == adminDatas[i].Username && password == adminDatas[i].Password)
                {
                    // DisplayValidLoginPrompt();
                    exist = true;
                    // Navigation
                    Application.Current.MainPage.Navigation.PushModalAsync(new Home());
                }
                else
                {
                    i = i + 1;
                }
            }

            if (exist == false)
            {
                DisplayInvalidLoginPrompt();
            }           
           
        }

        #endregion

    }


}
