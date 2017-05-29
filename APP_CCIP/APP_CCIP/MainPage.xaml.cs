using Xamarin.Forms;

namespace APP_CCIP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Browser.Source = "http://www.m.ccip.pt/";
        }
    }
}