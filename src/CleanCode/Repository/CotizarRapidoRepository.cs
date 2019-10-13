
using CleanCode.Domain;
using System.Threading.Tasks;

namespace CleanCode.Repository
{
    public class CotizarRapidoRepository
    {

        public async Task<Quote> Cotizar(decimal i, decimal p) 
        {
            Quote quote = new Quote();
            quote.I = i;
            quote.P = p;

            return quote;
        }
    }
}
