namespace LaboViews
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await BorderFront.RotateYTo(360, 500);
            BorderFront.RotationY = 0;
            if (BorderFront.BackgroundColor == Colors.Black)
            {
                BorderFront.BackgroundColor = Colors.DarkSlateGray;
            }
            else
            {
                BorderFront.BackgroundColor = Colors.Black;
            }
        }
    }
}