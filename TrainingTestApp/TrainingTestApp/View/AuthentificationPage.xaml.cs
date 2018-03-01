using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingTestApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingTestApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AuthentificationPage : ContentPage
	{
		public AuthentificationPage ()
		{
          
            InitializeComponent ();
            var vm = new AdminViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login", "OK");
            vm.DisplayValidLoginPrompt += () => DisplayAlert("Welcome", "valid Login", "OK");
        }
	}
}