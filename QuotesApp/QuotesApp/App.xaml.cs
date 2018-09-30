using CommonServiceLocator;
using QuotesApp.Interfaces;
using QuotesApp.Services;
using QuotesApp.Views;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace QuotesApp
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            //create the container
            var unityContainer = new UnityContainer();
            //Register the dependencies
            unityContainer.RegisterType<IQuotes, QuotesApi>();
            //configure the application to look for our dependencies within this container using service locator
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(unityContainer));
			MainPage = new QuotesPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
