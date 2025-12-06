using MauiPrjekt.MVVM.Model;

namespace MauiPrjekt
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new KezdoPage();
        }
    }
}
