using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanCode.Repository;
using MediatR;

namespace CleanCode.Services.Queries
{
    public class QuoteHandler : IRequestHandler<QuoteQuery, QuoteResponse>
    {
        private readonly IMapper mapper;
        private readonly ICoverageRepository coverageRepository;

        public QuoteHandler(IMapper mapper, ICoverageRepository coverageRepository) 
        {
            this.mapper = mapper;
            this.coverageRepository = coverageRepository;
        }
        public async Task<QuoteResponse> Handle(QuoteQuery request, CancellationToken cancellationToken)
        {
            QuoteResponse quoteResponse = new QuoteResponse();
            CotizarRapidoRepository cotizadorRapido = new CotizarRapidoRepository();
            
            var result = await cotizadorRapido.Cotizar(request.Branch, request.InsuredValue);
            //Meaninful Names - Avoid Mental Mapping
            quoteResponse.Branch = request.Branch;
            quoteResponse.SumaAsegurada = result.InsuredValue;
            quoteResponse.Precio = result.P;
            quoteResponse = mapper.Map<Domain.Quote, QuoteResponse>(result);
            quoteResponse.Coverages = await coverageRepository.GetCoverageByBranch(request.Branch);
            return quoteResponse;
        }
    }
}
