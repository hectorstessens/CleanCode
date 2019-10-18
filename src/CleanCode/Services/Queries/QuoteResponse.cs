using CleanCode.Domain;
using MediatR;
using System.Collections.Generic;

namespace CleanCode.Services.Queries
{
    public class QuoteResponse : IRequest
    {
        public QuoteResponse() 
        {
            this.Coverages = new List<Coverage>();
        }

        public string Branch { get; set; }
        public decimal SumaAsegurada { get; set; }
        public decimal Precio { get; set; }
        public  List<Coverage>  Coverages { get; set; }

    }
}
