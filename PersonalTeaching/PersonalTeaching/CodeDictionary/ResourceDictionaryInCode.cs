using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace PersonalTeaching.CodeDictionary
{
    public static class ResourceDictionaryInCode
    {
        public static Label ListLabelStyle()
        {
            var label = new Label
            {
                FontSize = 17,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Start
            };
            return label;
        }
    }
}
