using MediatR;

namespace CleanCode.Services.Queries
{
    public class QuoteResponse : IRequest
    {
        public decimal precio { get; set; }
        public decimal SumaAsegurada { get; set; }
    }
}
