using PersonalTeaching.Model;
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
    public partial class SearchSchoolPage : ContentPage
    {
        WriteStudentInformationPageModel _infoModel;
        public SearchSchoolPage(WriteStudentInformationPageModel infoModel)
        {
            InitializeComponent();
            _infoModel = infoModel;

        }


    }
}