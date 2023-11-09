using System.Diagnostics;

namespace Color_Maker
{
    public partial class MainPage : ContentPage
    {
        bool isRandom;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if(!isRandom) { 
                var red = sldRed.Value;
                var green = sldGreen.Value;
                var blue = sldBlue.Value;

                Color color = Color.FromRgb(red, green, blue);

                SetColor(color);
            }
        }
        private void SetColor(Color color) 
        {

            Debug.WriteLine(color.ToString());
            btnRandom.Background = color;
            Container.BackgroundColor = color;
            lblHex.Text = color.ToHex();

        }

        private void btnRandom_Clicked(object sender, EventArgs e)
        {
            isRandom = true;
            var Random = new Random();
            var color = Color.FromRgb(Random.Next(0, 255), Random.Next(0, 255), Random.Next(0, 255));
            SetColor(color);

            sldRed.Value = color.Red;
            sldGreen.Value = color.Green;
            sldBlue.Value = color.Blue;
            isRandom = false;
        }
    }
}