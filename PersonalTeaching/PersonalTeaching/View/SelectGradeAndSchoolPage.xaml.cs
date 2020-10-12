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
    public partial class SelectGradeAndSchoolPage : ContentPage
    {
        public SelectGradeAndSchoolPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BackgroundColor = Color.White;
        }


        private async void On_Si_FrameBoxTapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("시 선택", "닫기", null, "부산광역시");
            Si.Text = action;
        }

        private async void On_Gu_FrameBoxTapped(object sender, EventArgs e)
        {
            await DisplayAlert("", "구", "Ok");
        }

        private async void On_Dong_FrameBoxTapped(object sender, EventArgs e)
        {
            await DisplayAlert("", "동", "Ok");
        }
    }
}