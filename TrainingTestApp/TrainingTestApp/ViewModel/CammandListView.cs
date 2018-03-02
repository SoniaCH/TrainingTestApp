using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;

namespace TrainingTestApp.ViewModel
{
   public class CammandListView : ListView
    {
        public static BindableProperty ItemClickedCommandProperty = BindableProperty.Create(
            nameof(ItemClickCommand), typeof(ICommand), typeof(CammandListView), null);



        public ICommand ItemClickCommand
        {
            get
            {
                return (ICommand)this.GetValue(ItemClickedCommandProperty);
            }
            set
            {
                this.SetValue(ItemClickedCommandProperty, value);
            }

        }


        // constructer
        public CammandListView() {
            this.ItemTapped += OnItemTapped;
        }


        private void OnItemTapped(object sender, ItemTappedEventArgs e) {
            if (e.Item != null) {
                ItemClickCommand.Execute(e.Item);
                SelectedItem = null;
            }

        }



    }
}
