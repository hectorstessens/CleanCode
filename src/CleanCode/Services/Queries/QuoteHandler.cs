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
            CotizarRapidoRepository cotizadorRapido = new CotizarRapidoRepository();
            
            var result = await cotizadorRapido.Cotizar(request.Branch, request.InsuredValue);
            //Meaninful Names - Avoid Mental Mapping
            quoteResponse.Branch = request.Branch;
            quoteResponse.SumaAsegurada = result.InsuredValue;
            quoteResponse.Precio = result.P;
            return quoteResponse;
        }
    }
}
