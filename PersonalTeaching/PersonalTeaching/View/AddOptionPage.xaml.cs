using PersonalTeaching.CodeDictionary;
using PersonalTeaching.Constant;
using PersonalTeaching.Model;
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
        WriteStudentInformationPageModel _infoModel;
        public AddOptionPage(WriteStudentInformationPageModel infoModel)
        {
            InitializeComponent();
            _infoModel = infoModel;
            _infoModel.Options = new List<string>();
            var vm = new AddOptionPageViewModel();
            BindingContext = vm.GetAddOptionViewModel(_infoModel.GradePrice);
            _selectedPrice = _infoModel.GradePrice;
            _currentPrice = _infoModel.GradePrice;
            currentPriceLabel.Text = string.Format("{0:0,0}", _currentPrice) + "원";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var idx = Constants.PriceForeachGrade.IndexOf(_infoModel.GradePrice);

            //중등
            if (idx < 3)
            {
                MathAndScienceOption.IsVisible = false;
            }

            //고등
            else if(idx<4)
            {
                SpecialHighschoolOption.IsVisible = false;
            }
            else if (idx == 5)
            {
                PreEduOption.IsVisible = false;
            }
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


        private void OnCheckboxChecked(object sender, CheckedChangedEventArgs e)
        {
            var checkBox = (CheckBox)sender;
            var stack = (StackLayout)checkBox.Parent;
            var thisPrice = int.Parse(((Label)stack.Children[2]).Text);
            var thisOption = (string)(((Label)stack.Children[1]).Text);

            //눌러서 지금 체크가 되었다면
            if (checkBox.IsChecked)
            {
                _currentPrice += thisPrice;
                _infoModel.Options.Add(thisOption);
            }
            else
            {
                _currentPrice -= thisPrice;
                _infoModel.Options.Remove(thisOption);
            }
            currentPriceLabel.Text= string.Format("{0:0,0}", _currentPrice) + "원";
        }



        private async void OnCompleteButtonClicked(object sender, EventArgs e)
        {
            _infoModel.TotalPrice = _currentPrice;
            _infoModel.TotalPriceString= string.Format("{0:0,0}", _currentPrice) + "원";
            await Navigation.PushAsync(new WriteStudentInformationPage(_infoModel));
        }
    }
}