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

        public BasicAddressPage()
        {
            InitializeComponent();
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
            await Navigation.PushAsync(new MainPage());
        }
    }
}