using CommonServiceLocator;
using QuotesApp.Services;
using QuotesApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuotesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{

        
		public QuotesPage ()
		{
			InitializeComponent ();
            BindingContext = ServiceLocator.Current.GetInstance(typeof(QuotesViewModel));
		}

      
    }
}