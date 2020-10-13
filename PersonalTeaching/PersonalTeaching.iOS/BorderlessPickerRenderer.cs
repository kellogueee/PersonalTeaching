using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using PersonalTeaching;
using PersonalTeaching.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderlessPicker),typeof(BorderlessPickerRenderer))]
namespace PersonalTeaching.iOS
{
    public class BorderlessPickerRenderer:PickerRenderer
    {
        //public static new void Init() { }
        //protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    base.OnElementPropertyChanged(sender, e);
        //    Control.Layer.BorderWidth = 0;
        //    Control.BorderStyle = UITextBorderStyle.None;
        //}
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}