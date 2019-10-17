
using CleanCode.Domain;
using System.Threading.Tasks;

namespace CleanCode.Repository
{
    public class CotizarRapidoRepository
    {

        public async Task<Quote> Cotizar(string branch,decimal insuredValue) 
        {
            Quote quote = new Quote();
            quote.InsuredValue = insuredValue;
            // Use Intention-Revealing Names
            quote.P = 1;

            return quote;
        }
    }
}
