using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanCode.Domain;
using CleanCode.Domain.Factory;
using CleanCode.Repository;
using MediatR;

namespace CleanCode.Services.Queries
{
    public class QuoteHandler : IRequestHandler<QuoteQuery, QuoteResponse>
    {
        private readonly IMapper mapper;
        private readonly ICoverageRepository coverageRepository;
        private readonly IQuoteFactory quoteFactory;

        public QuoteHandler(IMapper mapper, ICoverageRepository coverageRepository, IQuoteFactory quoteFactory) 
        {
            this.mapper = mapper;
            this.coverageRepository = coverageRepository;
            this.quoteFactory = quoteFactory;

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
            quoteResponse.Coverages = await coverageRepository.GetCoverageByBranch(request.Branch);
            return quoteResponse;
        }
    }
}





// var quoteService = quoteFactory.Create(request.Branch);
//Quote quote = quoteService.GetQuote(request.InsuredValue);
//quoteResponse = mapper.Map<Domain.Quote, QuoteResponse>(quote);
