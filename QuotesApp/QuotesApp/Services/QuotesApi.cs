using Newtonsoft.Json;
using QuotesApp.Interfaces;
using QuotesApp.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuotesApp.Services
{
    public class QuotesApi: IQuotes
    {
        public async Task<List<Quote>> GetQuotes()
        {
            string _quotesUrl = "http://quotesondesign.com/wp-json/posts?filter[orderby]=rand&filter[posts_per_page]=10";
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(_quotesUrl);
            return JsonConvert.DeserializeObject<List<Quote>>(response);
        }
    }
}
