using PersonalTeaching.Model;
using PersonalTeaching.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PersonalTeaching.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicAddressPage : ContentPage
    {

        BasicAddressPageViewModel vm;
        WriteStudentInformationPageModel _infoModel;

        public BasicAddressPage()
        {
            InitializeComponent();
            _infoModel = new WriteStudentInformationPageModel();
            vm = new BasicAddressPageViewModel();
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void On_Si_FrameBoxTapped(object sender, EventArgs e)
        {
            Si_Picker.Focus();
        }

        private  void On_Gu_FrameBoxTapped(object sender, EventArgs e)
        {
            Gu_Picker.Focus();
        }

        private  void On_Dong_FrameBoxTapped(object sender, EventArgs e)
        {
            Dong_Picker.Focus();
        }

        private void OnGuChanged(object sender, EventArgs e)
        {
            vm.CreateDong((string)Gu_Picker.SelectedItem);
            Dong_Picker.ItemsSource = null;
            Dong_Picker.ItemsSource = vm.Dongs;
        }

        private async void OnNextButtonClicked(object sender, EventArgs e)
        {
            _infoModel.Si = (string)Si_Picker.SelectedItem;
            _infoModel.Gu = (string)Gu_Picker.SelectedItem;
            _infoModel.Dong = (string)Dong_Picker.SelectedItem;
            await Navigation.PushAsync(new SelectGradePage(_infoModel));
        }
    }
}