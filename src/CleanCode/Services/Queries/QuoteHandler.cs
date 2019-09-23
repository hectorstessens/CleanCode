using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace CleanCode.Services.Queries
{
    public class QuoteHandler : IRequestHandler<QuoteQuery, QuoteResponse>
    {
        public Task<QuoteResponse> Handle(QuoteQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
