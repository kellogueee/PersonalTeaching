using PersonalTeaching.Constant;
using PersonalTeaching.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalTeaching.ViewModel
{
    public class MainPageViewModel
    {
        public MainPageModel GetMainPageBindingContext()
        {
            var model = new MainPageModel();
            model.Middle1 = Constants.Middle1;
            model.Middle2 = Constants.Middle2;
            model.Middle3 = Constants.Middle3;
            model.High1 = Constants.High1;
            model.High2 = Constants.High2;
            model.High3 = Constants.High3;


            model.Middle1Price = Constants.Middle1Price;
            model.Middle2Price = Constants.Middle2Price;
            model.Middle3Price = Constants.Middle3Price;
            model.High1Price = Constants.High1Price;
            model.High2Price = Constants.High2Price;
            model.High3Price = Constants.High3Price;


            model.Middle1PriceString = "+ " + string.Format("{0:0,0}", Constants.Middle1Price) + "원";
            model.Middle2PriceString = "+ " + string.Format("{0:0,0}", Constants.Middle2Price) + "원";
            model.Middle3PriceString = "+ " + string.Format("{0:0,0}", Constants.Middle3Price) + "원";
            model.High1PriceString = "+ " + string.Format("{0:0,0}", Constants.High1Price) + "원";
            model.High2PriceString = "+ " + string.Format("{0:0,0}", Constants.High2Price) + "원";
            model.High3PriceString = "+ " + string.Format("{0:0,0}", Constants.High3Price) + "원";


            return model;
        }
    }
}
