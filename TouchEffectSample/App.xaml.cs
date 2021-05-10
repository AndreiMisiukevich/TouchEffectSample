using Xamarin.Forms;

namespace TouchEffectSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPage
            {
                Children =
                {
                    new TapGesturePage { BindingContext = new SampleViewModel() },
                    new TouchEffectPage { BindingContext = new SampleViewModel() }
                }
            };
        }
    }
}
