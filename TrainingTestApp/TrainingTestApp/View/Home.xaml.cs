﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using TrainingTestApp.ViewModel;
using Xamarin.Forms.Xaml;

namespace TrainingTestApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : MasterDetailPage
	{
		public Home ()
		{
			InitializeComponent ();
            BindingContext = new HomeViewModel();
            IsPresented = true;
            
		}


       
        

      

        //void PageToGo() {

        //}

        //private void ListPageClicked(object sender, EventArgs e) {
        //    Detail = new EmployeeViewPage();
        //    IsPresented = false;
        //}

        //private void InscriptionPageClicked(object sender, EventArgs e)
        //{
        //    Detail = new InscriptionViewPage();
        //    IsPresented = false;
        //}

    }
}