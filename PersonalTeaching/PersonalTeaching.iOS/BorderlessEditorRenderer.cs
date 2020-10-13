using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using PersonalTeaching;
using PersonalTeaching.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(BorderlessEditor),typeof(BorderlessEditorRenderer))]
namespace PersonalTeaching.iOS
{
    public class BorderlessEditorRenderer:EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
            }
        }
    }
}