using PersonalTeaching.Model;
using PersonalTeaching.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PersonalTeaching.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WriteStudentInformationPage : ContentPage
    {

        public WriteStudentInformationPage()
        {
            InitializeComponent();

            BindingContext = new WriteStudentInformationPageViewModel();
        }
        
    }
}