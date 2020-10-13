using PersonalTeaching.Constant;
using PersonalTeaching.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalTeaching.ViewModel
{
    public class AddOptionPageViewModel
    {
        public AddOptionPageModel GetAddOptionViewModel(int selectedPrice)
        {
            var addOptionModel = new AddOptionPageModel
            {
                AddHourOption = Constants.AddHourOption,
                PreEduOption = Constants.PreEduOption,
                PrepareContestOption = Constants.PrepareContestOption,
                PrepareSpecialHighSchoolOption = Constants.PrepareSpecialHighSchoolOption,
                MathAndSciencePartOption = Constants.MathAndSciencePartOption,

                AddHourOptionPrice = Constants.GetAddHourOptionPrice(selectedPrice),
                PreEduOptionPrice = Constants.PreEduOptionPrice,
                PrepareContestOptionPrice = Constants.PrepareContestOptionPrice,
                PrepareSpecialHighSchoolOptionPrice = Constants.PrepareSpecialHighSchoolOptionPrice,
                MathAndSciencePartOptionPrice = Constants.MathAndSciencePartOptionPrice,

                AddHourOptionPriceString = "+ " + string.Format("{0:0,0}", Constants.GetAddHourOptionPrice(selectedPrice)) + "원",
                PreEduOptionPriceString= "+ " + string.Format("{0:0,0}", Constants.PreEduOptionPrice) + "원",
                PrepareContestOptionPriceString = "+ " + string.Format("{0:0,0}", Constants.PrepareContestOptionPrice) + "원",
                PrepareSpecialHighSchoolOptionPriceString = "+ " + string.Format("{0:0,0}", Constants.PrepareSpecialHighSchoolOptionPrice) + "원",
                MathAndSciencePartOptionPriceString = "+ " + string.Format("{0:0,0}", Constants.MathAndSciencePartOptionPrice) + "원"
            };

            return addOptionModel;
        }
    }
}
