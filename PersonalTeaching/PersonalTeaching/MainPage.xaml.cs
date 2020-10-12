using PersonalTeaching.CodeDictionary;
using PersonalTeaching.Constant;
using PersonalTeaching.View;
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

        private static int currentPrice = 0;

        public MainPage()
        {
            InitializeComponent();
            int rowCount = MainGrid.RowDefinitions.Count;

            for (var row = 0; row < rowCount; row++)
            {
                var stack = new StackLayout
                {
                    BackgroundColor = Color.White
                };

                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += OnStackTapped;
                stack.GestureRecognizers.Add(tapGestureRecognizer);
                Grid.SetRow(stack, row);

                var LineGrid = new Grid
                {
                    ColumnDefinitions =
                    {
                        new ColumnDefinition{Width=new GridLength(1,GridUnitType.Auto)},
                        new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                    },
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };


                var radioGrid = new Grid
                {
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) }
                    },
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };

                var radio = new RadioButton
                {
                    GroupName = "GradeRadioButton",
                };
                radio.CheckedChanged += OnRadioCheckChanged;

                Grid.SetColumn(radio, 0);

                var labelRadio = ResourceDictionaryInCode.ListLabelStyle();
                labelRadio.Text = Constants.GradeStringArray[row];

                Grid.SetColumn(labelRadio, 1);

                radioGrid.Children.Add(radio);
                radioGrid.Children.Add(labelRadio);


                var labelPrice = ResourceDictionaryInCode.ListLabelStyle();
                labelPrice.Text = Constants.GetPriceForeachGradeStringArray().ToArray()[row];
                labelPrice.FontAttributes = FontAttributes.Bold;
                labelPrice.HorizontalOptions = LayoutOptions.EndAndExpand;


                labelPrice.BindingContext = radio;
                labelPrice.SetBinding(Label.IsVisibleProperty, "IsChecked");

                Grid.SetColumn(labelPrice, 1);

                LineGrid.Children.Add(radioGrid);
                LineGrid.Children.Add(labelPrice);

                stack.Children.Add(LineGrid);
                MainGrid.Children.Add(stack);
            }
        }

        private void OnRadioCheckChanged(object sender, CheckedChangedEventArgs e)
        {
            var item = (RadioButton)sender;
            var parent = (Grid)item.Parent;
            var label = (Label)parent.Children[1];
            var idx = Constants.GradeStringArray.IndexOf(label.Text);
            SelectButton.Text = Constants.GradeStringArray[idx] + " 신청하기";
            priceLabel.Text = Constants.GetPriceForeachGradeStringArray().ToArray()[idx].Substring(1).Trim();
            currentPrice = Constants.PriceForeachGrade[idx];
        }

        private void OnStackTapped(object sender, EventArgs e)
        {
            var stack = (StackLayout)sender;
            var child = stack.Children.FirstOrDefault();
            var childChild = (RadioButton)((Grid)((Grid)child).Children[0]).Children[0];
            childChild.IsChecked = true;
        }

        private async void OnSelectButtonClicked(object sender, EventArgs e)
        {
            if (currentPrice == 0)
            {
                await DisplayAlert("견적서", "학년을 선택해주세요.", "Ok");
                return;
            }

            await Navigation.PushAsync(new AddOptionPage(currentPrice));
        }


    }
}
