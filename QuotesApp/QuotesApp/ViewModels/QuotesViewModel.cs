using QuotesApp.Interfaces;
using QuotesApp.Models;
using System.Collections.ObjectModel;

namespace QuotesApp.ViewModels
{
    public class QuotesViewModel: BaseViewModel
    {
        public ObservableCollection<Quote> QuotesCollection { get;  set; }
        private readonly IQuotes _quotes;
        public QuotesViewModel(IQuotes quotes)
        {
            _quotes = quotes;
            QuotesCollection = new ObservableCollection<Quote>();
            LoadQuotes();
        }

        private async void LoadQuotes()
        {
            var quotes = await _quotes.GetQuotes();

            foreach (var quote in quotes)
            {
                QuotesCollection.Add(quote);
            }
        }
    }
}
