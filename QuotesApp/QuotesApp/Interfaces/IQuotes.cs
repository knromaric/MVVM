using QuotesApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuotesApp.Interfaces
{
    public interface IQuotes
    {
        Task<List<Quote>> GetQuotes();
    }
}
