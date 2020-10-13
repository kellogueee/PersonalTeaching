using PersonalTeaching.CodeDictionary;
using PersonalTeaching.Constant;
using PersonalTeaching.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace PersonalTeaching.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddOptionPage : ContentPage
    {
        private int _currentPrice;
        private int _selectedPrice = 0;

        public AddOptionPage(int price)
        {
            InitializeComponent();
            var vm = new AddOptionPageViewModel();
            BindingContext = vm.GetAddOptionViewModel(price);
            _selectedPrice = price;
            _currentPrice = price;
            currentPriceLabel.Text = string.Format("{0:0,0}", _currentPrice) + "원";
        }


        private void OnStackTapped(object sender, EventArgs e)
        {
            var stack = (StackLayout)sender;
            var check = (CheckBox)stack.Children[0];

            //현재 체크되어있다면
            if (check.IsChecked)
            {
                check.IsChecked = false;
            }
            else
            {
                check.IsChecked = true;
            }
        }




        private async void OnCompleteButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WriteStudentInformationPage());
        }

        private void OnCheckboxChecked(object sender, CheckedChangedEventArgs e)
        {
            var checkBox = (CheckBox)sender;
            var stack = (StackLayout)checkBox.Parent;
            var thisPrice = int.Parse(((Label)stack.Children[2]).Text);

            //눌러서 지금 체크가 되었다면
            if (checkBox.IsChecked)
            {
                _currentPrice += thisPrice;
            }
            else
            {
                _currentPrice -= thisPrice;
            }
            currentPriceLabel.Text= string.Format("{0:0,0}", _currentPrice) + "원";

        }

    }
}