using PersonalTeaching.CodeDictionary;
using PersonalTeaching.Constant;
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
        int _currentPrice;
        int _selectedPrice;

        public AddOptionPage(int price)
        {
            InitializeComponent();
            _selectedPrice = price;
            _currentPrice = price;

            priceLabel.Text = string.Format("{0:0,0}", _selectedPrice) + "원";
            CompleteButton.Text = string.Format("{0:0,0}", _selectedPrice) + "원";

            int rowCount = AddOptionGrid.RowDefinitions.Count;
            for(var row = 0; row < rowCount; row++)
            {
                var stack = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal
                };

                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += OnStackTapped;
                stack.GestureRecognizers.Add(tapGestureRecognizer);
                Grid.SetRow(stack, row);

                var checkBox = new CheckBox();
                checkBox.CheckedChanged += OnCheckboxChecked;

                var optionNameLabel = ResourceDictionaryInCode.ListLabelStyle();
                optionNameLabel.Text = Constants.OptionStringArray[row];
                var optionPriceLabel = ResourceDictionaryInCode.ListLabelStyle();
                optionPriceLabel.Text = Constants.GetOptionPriceStringArray(_selectedPrice).ToArray()[row];
                optionPriceLabel.FontAttributes = FontAttributes.Bold;
                optionPriceLabel.HorizontalOptions = LayoutOptions.EndAndExpand;

                stack.Children.Add(checkBox);
                stack.Children.Add(optionNameLabel);
                stack.Children.Add(optionPriceLabel);

                AddOptionGrid.Children.Add(stack);

            }


        }


        private void OnStackTapped(object sender, EventArgs e)
        {
            var stack = (StackLayout)sender;
            var child = (CheckBox)(stack.Children.FirstOrDefault());
            if (child.IsChecked)
            {
                child.IsChecked = false;
            }
            else
            {
                child.IsChecked = true;
            }
        }


        private async void OnCompleteButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WriteStudentInformationPage());
        }

        private void OnCheckboxChecked(object sender, CheckedChangedEventArgs e)
        {
            var checkBox = (CheckBox)sender;
            var parent = (StackLayout)checkBox.Parent;

            var label1 = (Label)parent.Children[1];

            var idx = Constants.OptionStringArray.IndexOf(label1.Text);

            if (checkBox.IsChecked)
            {
                _currentPrice += Constants.GetOptionPriceArray(_selectedPrice).ToArray()[idx];
                priceLabel.Text = string.Format("{0:0,0}", _currentPrice)+"원";
                //CompleteButton.Text = string.Format("{0:0,0}", _currentPrice) + "원 제출하기";
                CompleteButton.Text ="견적서 완성하기";
            }
            else
            {
                _currentPrice -= Constants.GetOptionPriceArray(_selectedPrice).ToArray()[idx];
                priceLabel.Text = string.Format("{0:0,0}", _currentPrice) + "원";
                //CompleteButton.Text = string.Format("{0:0,0}", _currentPrice) + "원 제출하기";
                CompleteButton.Text = "견적서 완성하기";
            }
            
        }

    }
}