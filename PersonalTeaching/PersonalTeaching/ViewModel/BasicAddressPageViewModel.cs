using PersonalTeaching.Constant;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace PersonalTeaching.ViewModel
{
    public class BasicAddressPageViewModel
    {
        private IList<string> siSource;
        private IList<string> guSource;
        private IList<string> dongSource;

        public ObservableCollection<string> Sis { get; set; }
        public ObservableCollection<string> Gus { get; set; }
        public ObservableCollection<string> Dongs { get; set; }

        string selected_Si;

        public string Selected_Si
        {
            get
            {
                return selected_Si;
            }
            set
            {
                selected_Si = value;
            }
        }


        public BasicAddressPageViewModel()
        {
            siSource = new List<string>();
            guSource = new List<string>();
            dongSource = new List<string>();

            CreateSi();
            CreateGu();
        }

        void CreateSi()
        {
            siSource.Add("부산광역시");
            selected_Si = siSource[0];
            Sis = new ObservableCollection<string>(siSource);

        }
        void CreateGu()
        {
            guSource.Add("서구");
            guSource.Add("중구");
            guSource.Add("동구");
            guSource.Add("남구");
            guSource.Add("북구");
            guSource.Add("영도구");
            guSource.Add("동래구");
            guSource.Add("부산진구");
            guSource.Add("해운대진구");
            guSource.Add("사하구");
            guSource.Add("금정구");
            guSource.Add("강서구");
            guSource.Add("연제구");
            guSource.Add("수영구");
            guSource.Add("사상구");
            guSource.Add("기장군");
            guSource.OrderBy(x => x).ToList();

            Gus = new ObservableCollection<string>(guSource);
        }
        public void CreateDong(string key)
        {
            if (dongSource.Count != 0)
            {
                dongSource.Clear();
            }
            var dic = Constants.GetDongDictionary();
            var dong = dic[key];
            foreach (var item in dong.Split(','))
            {
                dongSource.Add(item);
            }
           
            Dongs = new ObservableCollection<string>(dongSource);
        }
    }
}
