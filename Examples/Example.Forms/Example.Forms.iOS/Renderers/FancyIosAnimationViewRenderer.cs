using System;
using Lottie.Forms;
using Lottie.Forms.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsGestureRecognizers;
using XamarinFormsGestureRecognizers.iOS;

[assembly: ExportRenderer(typeof(FancyAnimationView), typeof(FancyIosLabelRenderer))]

namespace XamarinFormsGestureRecognizers.iOS
{
    public class FancyIosLabelRenderer : AnimationViewRenderer
    {
        UITapGestureRecognizer tapGestureRecognizer;

        protected override void OnElementChanged(ElementChangedEventArgs<AnimationView> e)
        {
            base.OnElementChanged(e);

            tapGestureRecognizer = new UITapGestureRecognizer(() => Console.WriteLine("Tapped FancyAnimation!")); 

            if (e.NewElement == null)
            {
                if (tapGestureRecognizer != null)
                {
                    this.RemoveGestureRecognizer(tapGestureRecognizer);
                }
            }

            if (e.OldElement == null)
            {
                this.AddGestureRecognizer(tapGestureRecognizer);
            }
        }
    }
}