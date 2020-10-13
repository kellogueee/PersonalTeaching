using PersonalTeaching.CodeDictionary;
using PersonalTeaching.Constant;
using PersonalTeaching.View;
using PersonalTeaching.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace PersonalTeaching
{
    public partial class MainPage : ContentPage
    {

        private int _currentPrice = 0;

        public MainPage()
        {
            InitializeComponent();
            var vm = new MainPageViewModel();
            BindingContext = vm.GetMainPageBindingContext();
        }

        private void OnRadioCheckChanged(object sender, CheckedChangedEventArgs e)
        {
            var radio = (RadioButton)sender;
            var stack = (StackLayout)radio.Parent;
            var label = (Label)stack.Children[2];

            _currentPrice = int.Parse(label.Text);

            currentPriceLabel.Text = string.Format("{0:0,0}", _currentPrice) + "원";
        }

        private void OnStackTapped(object sender, EventArgs e)
        {
            var stack = (StackLayout)sender;
            var radio = (RadioButton)stack.Children[0];
            radio.IsChecked = true;

        }

        private async void OnNextButtonClicked(object sender, EventArgs e)
        {
            if (_currentPrice == 0)
            {
                await DisplayAlert("", "학년을 선택해 주세요.", "확인");
                return;
            }
            await Navigation.PushAsync(new AddOptionPage(_currentPrice));
        }

    }
}
