using PersonalTeaching.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PersonalTeaching.ViewModel
{
    public class WriteStudentInformationPageViewModel
    {
        readonly IList<string> hourSource;
        readonly IList<string> minuteSource;

        public ObservableCollection<string> Hours { get; set; }
        public ObservableCollection<string> Minutes { get; set; }

        public WriteStudentInformationPageModel Model { get; set; }

        public WriteStudentInformationPageViewModel(WriteStudentInformationPageModel model)
        {
            Model = model;

            hourSource = new List<string>();
            minuteSource = new List<string>();
            CreateHours();
            CreateMinutes();
        }
        void CreateHours()
        {
            for (var h = 0; h < 24; h++)
            {
                hourSource.Add(string.Format("{0:00}", h));
            }

            Hours = new ObservableCollection<string>(hourSource);

        }
        void CreateMinutes()
        {
            for (var m = 0; m < 60; m++)
            {
                minuteSource.Add(string.Format("{0:00}", m));
            }
            Minutes = new ObservableCollection<string>(minuteSource);
        }
    }
}
