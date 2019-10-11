using System.Threading;
using System.Threading.Tasks;
using CleanCode.Repository;
using MediatR;

namespace CleanCode.Services.Queries
{
    public class QuoteHandler : IRequestHandler<QuoteQuery, QuoteResponse>
    {
        public async Task<QuoteResponse> Handle(QuoteQuery request, CancellationToken cancellationToken)
        {
            QuoteResponse quoteResponse = new QuoteResponse();
            CotizarRapido cotizadorRapido = new CotizarRapido();
            
            var result = await cotizadorRapido.cotizar();

            quoteResponse.precio = result.Price;
            quoteResponse.SumaAsegurada = result.InsuredValue;

            return quoteResponse;
        }
    }
}
