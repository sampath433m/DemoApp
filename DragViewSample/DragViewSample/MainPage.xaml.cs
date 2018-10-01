using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace DragViewSample
{
    public partial class MainPage : ContentPage
    {
        private double startScale;
        private double currentScale;
        private double xOffset;
        private double yOffset;

        public MainPage()
        {
            InitializeComponent();

            TapGestureRecognizer GreenBtnGesture = new TapGestureRecognizer();
            GreenBtnGesture.Tapped += GreenBtnGesture_Tapped;
            GreenBtn.GestureRecognizers.Add(GreenBtnGesture);


            TapGestureRecognizer RedBtnGesture = new TapGestureRecognizer();
            RedBtnGesture.Tapped += RedBtnGesture_Tapped;
            RedBtn.GestureRecognizers.Add(RedBtnGesture);

            

            TapGestureRecognizer BlueBtnGesture = new TapGestureRecognizer();
            BlueBtnGesture.Tapped += BlueBtnGesture_Tapped;
            BlueBtn.GestureRecognizers.Add(BlueBtnGesture);

            TapGestureRecognizer YellowBtnGesture = new TapGestureRecognizer();
            YellowBtnGesture.Tapped += YellowBtnGesture_Tapped;
            YellowBtn.GestureRecognizers.Add(YellowBtnGesture);

          

            TapGestureRecognizer PurpleBtnGesture = new TapGestureRecognizer();
            PurpleBtnGesture.Tapped += PurpleBtnGesture_Tapped;
            PurpleBtn.GestureRecognizers.Add(PurpleBtnGesture);

            if (!string.IsNullOrEmpty(Settings.opacity))
            {
                image.Opacity = Convert.ToDouble(Settings.opacity);
                if (!string.IsNullOrEmpty(Settings.sliderval))
                    SDemo.Value = Convert.ToDouble(Settings.sliderval) ;
            }

            if (!string.IsNullOrEmpty(Settings.rotation))
            {
                image.Rotation = Convert.ToDouble(Settings.rotation);
                if (!string.IsNullOrEmpty(Settings.sliderval2))
                    SDemo2.Value = Convert.ToDouble(Settings.sliderval2);
            }

            if (!string.IsNullOrEmpty(Settings.color))
            {
                if (Settings.color == Color.Green.ToString())
                {
                    image.BackgroundColor = Color.Green;
                    A1.TextColor = Color.Green;
                    A2.TextColor = Color.Green;
                    A3.TextColor = Color.Green;
                }
                else if (Settings.color == Color.Red.ToString())
                {
                    image.BackgroundColor = Color.Red;
                    A1.TextColor = Color.Red;
                    A2.TextColor = Color.Red;
                    A3.TextColor = Color.Red;
                }

                else if (Settings.color == Color.Blue.ToString())
                {
                    image.BackgroundColor = Color.Blue;
                    A1.TextColor = Color.Blue;
                    A2.TextColor = Color.Blue;
                    A3.TextColor = Color.Blue;
                }
                else if (Settings.color == Color.Purple.ToString())
                {
                    image.BackgroundColor = Color.Purple;
                    A1.TextColor = Color.Purple;
                    A2.TextColor = Color.Purple;
                    A3.TextColor = Color.Purple;
                }
                else if (Settings.color == Color.Yellow.ToString())
                {
                    image.BackgroundColor = Color.Yellow;
                    A1.TextColor = Color.Yellow;
                    A2.TextColor = Color.Yellow;
                    A3.TextColor = Color.Yellow;
                }
            }
            A1.Clicked += async (object sender, EventArgs e) => {
                try
                {
                    uint duration = 2 * 1000;

                    await Task.WhenAll(
                      image.RotateTo(307 * 360, duration),
                      image.RotateXTo(251 * 360, duration),
                      image.RotateYTo(199 * 360, duration)
                    );
                }
                catch (Exception)
                {

                }


            };

            A2.Clicked += async (object sender, EventArgs e) => {
                try
                {
                    await image.TranslateTo(-100, 0, 1000);    // Move image left
                    await image.TranslateTo(-100, -100, 1000); // Move image up
                    await image.TranslateTo(100, 100, 2000);   // Move image diagonally down and right
                    await image.TranslateTo(0, 100, 1000);     // Move image left
                    await image.TranslateTo(0, 0, 1000);       // Move image up
                }
                catch (Exception)
                {

                }


            };

            A3.Clicked += async (object sender, EventArgs e) => {
                try{
                    image.RotateTo(360, 4000);
                    await image.ScaleTo(2, 2000);
                    await image.ScaleTo(1, 2000);
                } catch(Exception){
                    
                }


            };


            picBtn.IsVisible = Device.RuntimePlatform == Device.iOS;

        }




        private void GreenBtnGesture_Tapped(object sender, EventArgs e)
        {
            try
            {
                A1.TextColor = Color.Green;
                A2.TextColor = Color.Green;
                A3.TextColor = Color.Green;

                image.BackgroundColor = Color.Green;
                Settings.color = Color.Green.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void BlueBtnGesture_Tapped(object sender, EventArgs e)
        {
            try
            {
                A1.TextColor = Color.Blue;
                A2.TextColor = Color.Blue;
                A3.TextColor = Color.Blue;
                image.BackgroundColor = Color.Blue;
                Settings.color = Color.Blue.ToString();
            }
            catch (Exception ex)
            {
            }
        }


        private void YellowBtnGesture_Tapped(object sender, EventArgs e)
        {
            try
            {
                A1.TextColor=Color.Yellow;
                A2.TextColor = Color.Yellow;
                A3.TextColor = Color.Yellow;
                image.BackgroundColor = Color.Yellow;
                Settings.color = Color.Yellow.ToString();

            }
            catch (Exception ex)
            {
            }
        }
        private void RedBtnGesture_Tapped(object sender, EventArgs e)
        {
            try
            {
                A1.TextColor = Color.Red;
                A2.TextColor = Color.Red;
                A3.TextColor = Color.Red;
                image.BackgroundColor = Color.Red;
                Settings.color = Color.Red.ToString();
            }
            catch (Exception ex)
            {
            }
        }


       

        private void PurpleBtnGesture_Tapped(object sender, EventArgs e)
        {
            try
            {
                A1.TextColor = Color.Purple;
                A2.TextColor = Color.Purple;
                A3.TextColor = Color.Purple;
                image.BackgroundColor = Color.Purple;
                Settings.color = Color.Purple.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        async void OnPicImageButtonClicked(object sender, System.EventArgs e)
        {
            
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;

            picBtn.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            }); 

        }

        void OnFabImageButtonClicked(object sender, System.EventArgs e)
        {
            menus.IsVisible = !menus.IsVisible;

        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            Settings.sliderval = Convert.ToString(e.NewValue);
            image.Opacity = (100-e.NewValue)/100;
            Settings.opacity = Convert.ToString(image.Opacity);
        }

        void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            try
            {
                if (e.Status == GestureStatus.Started)
                {
                    startScale = Content.Scale;
                    Content.AnchorX = 0;
                    Content.AnchorY = 0;
                }
                if (e.Status == GestureStatus.Running)
                {
                    currentScale += (e.Scale - 1) * startScale;
                    currentScale = Math.Max(1, currentScale);
                    double renderedX = Content.X + xOffset;
                    double deltaX = renderedX / Width;
                    double deltaWidth = Width / (Content.Width * startScale);
                    double originX = (e.ScaleOrigin.X - deltaX) * deltaWidth;
                    double renderedY = Content.Y + yOffset;
                    double deltaY = renderedY / Height;
                    double deltaHeight = Height / (Content.Height * startScale);
                    double originY = (e.ScaleOrigin.Y - deltaY) * deltaHeight;
                    double targetX = xOffset - (originX * Content.Width) * (currentScale - startScale);
                    double targetY = yOffset - (originY * Content.Height) * (currentScale - startScale);
                    Content.TranslationX = Math.Min(0, Math.Max(targetX, -Content.Width * (currentScale - 1)));
                    Content.TranslationY = Math.Min(0, Math.Max(targetY, -Content.Height * (currentScale - 1)));
                    Content.Scale = currentScale;
                }
                if (e.Status == GestureStatus.Completed)
                {
                    xOffset = Content.TranslationX;
                    yOffset = Content.TranslationY;
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void SDemo2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //image.TranslateTo(-100, e.NewValue, 1000);
            Settings.sliderval2 = e.NewValue.ToString();
            image.Rotation =  e.NewValue;
            Settings.rotation = e.NewValue.ToString();
        }
    }
}
