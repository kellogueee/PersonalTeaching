using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PersonalTeaching;
using PersonalTeaching.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(BorderlessEditor), typeof(BorderlessEditorRenderer))]
namespace PersonalTeaching.Droid
{
    public class BorderlessEditorRenderer:EditorRenderer
    {
        public BorderlessEditorRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if(e.OldElement == null)
            {
                Control.Background = null;
            }

        }

    }
}