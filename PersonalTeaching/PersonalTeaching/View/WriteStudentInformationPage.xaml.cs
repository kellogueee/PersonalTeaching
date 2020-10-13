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
        WriteStudentInformationPageModel _infoModel;
        public WriteStudentInformationPage(WriteStudentInformationPageModel infoModel)
        {
            InitializeComponent();
            _infoModel = infoModel;
            BindingContext = new WriteStudentInformationPageViewModel(_infoModel);
        }
        
        private async void OnSearchSchoolFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SearchSchoolPage(_infoModel));
        }
    }
}