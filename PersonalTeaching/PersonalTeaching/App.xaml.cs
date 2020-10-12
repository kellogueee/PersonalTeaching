using PersonalTeaching.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PersonalTeaching
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new[] { "RadioButton_Experimental", "Shapes_Experimental" });

            InitializeComponent();
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new SelectGradeAndSchoolPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
