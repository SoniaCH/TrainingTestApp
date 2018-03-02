using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TrainingTestApp
{
    public class BetterListView : ListView
    {

        public static BindableProperty ItemClickedCommandProperty = BindableProperty.Create(
           nameof(ItemClickCommand), typeof(ICommand), typeof(BetterListView), null);



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
        public BetterListView()
        {
            this.ItemTapped += OnItemTapped;
        }


        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                ItemClickCommand.Execute(e.Item);
                SelectedItem = null;
            }

        }


    }
}
