
using CleanCode.Domain;
using System.Threading.Tasks;

namespace CleanCode.Repository
{
    public class CotizarRapidoRepository
    {
        public async Task<Quote> cotizar() 
        {
            Quote quote = new Quote();
            return quote;
        }
    }
}
