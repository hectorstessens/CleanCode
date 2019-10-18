
using CleanCode.Domain;
using System.Threading.Tasks;

namespace CleanCode.Repository
{
    public class CotizarRapidoRepository
    {

        public decimal Taxes { get; set; }
        public decimal Scoring { get; set; }
        public async Task<Quote> Cotizar(string branch,decimal insuredValue) 
        {


            if (branch == "auto")
            {
                this.Taxes = 1.21M;
                this.Scoring = 2.0M;
            }
            else if (branch == "hogar")
            {
                this.Taxes = 1.21M;
                this.Scoring = 2.0M;
            }

            var price = insuredValue * Taxes * Scoring;

            Quote quote = new Quote(price,insuredValue);
            return quote;
        }
    }
}
