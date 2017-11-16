using System;
using Lottie.Forms;
using Xamarin.Forms;
using XamarinFormsGestureRecognizers;

namespace Example.Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //var fancyAnimationVew = new FancyAnimationView
            //{
            //    Animation = "TwitterHeart.json",
            //    Loop = true,
            //    AutoPlay = true
            //};

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.NumberOfTapsRequired = 2;
            tapGestureRecognizer.Tapped += (s, e) => {
                Sld.Value += 10;
            };

            FancyAnimationView.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            AnimationView.Progress = (float) e.NewValue;
            Name.Text = AnimationView.Animation;
        }

        void Btn_Clicked(object sender, EventArgs e)
        {
            if(AnimationView.Animation == "LottieLogo1.json") 
            {
                AnimationView.Animation = "HamburgerArrow.json";
                Btn.Text = "Load Logo";
                AnimationView.Scale = 1;
            }
            else {
                AnimationView.Animation = "LottieLogo1.json";
                Btn.Text = "Load Hamburger";

                AnimationView.Scale = 0.8;
            }
            Sld.Value = Sld.Minimum;
            Name.Text = AnimationView.GestureRecognizers.Count.ToString() + " -- " + FancyAnimationView.GestureRecognizers.Count.ToString();
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            Name.Text = "Tapped at" + DateTime.Now;
        }

    }
}
