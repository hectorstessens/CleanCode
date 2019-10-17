using MediatR;

namespace CleanCode.Services.Queries
{
    public class QuoteQuery : IRequest<QuoteResponse>
    {
        public string Branch { get; set; }
        public decimal InsuredValue { get; set; }
    }
}
