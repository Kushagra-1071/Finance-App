using Backend.Models;

namespace Backend.Interface
{
    public interface IFMPService
    {
        Task<Stock> FindStockBySymbolAsync(string symbol);

    }
}
