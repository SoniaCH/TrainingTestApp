using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TrainingTestApp.CustomFormElements;
using System.ComponentModel;


namespace TrainingTestApp.View
{
    public partial class PopUpPage : ModalPage

    {
       

        public string name;
        public string Name {
            get { return name; }
            set
            {
                name = value;
                
            }

        }

        public string departement;
        public string Departement
        {
            get { return departement; }
            set
            {
                departement = value;

            }

        }

        public string img;
        public string Img
        {
            get { return img; }
            set
            {
                img = value;

            }

        }




        ICommand CloseCommand { get; }



        public PopUpPage(string name,string departement, string img)

        {
            this.Name = name;
            this.Departement = departement;
            this.Img = img;

            InitializeComponent();

            employeeName.Text = name;
            employeeDepartement.Text = departement;
            employeeImg.Source = img;

            // Close this pop-up using the custom mechanism on ModalPageRenderer

            CloseCommand = new Command(() => Close());



            Shadow1.GestureRecognizers.Add(new TapGestureRecognizer { Command = CloseCommand });

            Shadow2.GestureRecognizers.Add(new TapGestureRecognizer { Command = CloseCommand });

            Shadow3.GestureRecognizers.Add(new TapGestureRecognizer { Command = CloseCommand });

            Shadow4.GestureRecognizers.Add(new TapGestureRecognizer { Command = CloseCommand });

        }



    }
}