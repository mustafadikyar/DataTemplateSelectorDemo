using DataTemplateSelectorDemo.Pages;
using Xamarin.Forms;

namespace DataTemplateSelectorDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new QuestionPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
