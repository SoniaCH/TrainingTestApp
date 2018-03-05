using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingTestApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmployeeViewPage : ContentPage
	{
		public EmployeeViewPage ()
		{
			InitializeComponent ();
        }

        /// <summary>
        /// For the humburger icon Tap
        /// </summary>
        /// 

        protected void OnImageTapped(object sender, EventArgs args)
        {
            try
            {
                //Code to execute on tapped event

                Application.Current.MainPage.Navigation.PushModalAsync(new Home());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void BackTapped(object sender, EventArgs args)
        {
            try
            {
                //Code to execute on tapped event

                Application.Current.MainPage.Navigation.PushModalAsync(new Home());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}