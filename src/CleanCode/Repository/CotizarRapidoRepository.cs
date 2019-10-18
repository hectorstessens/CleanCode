
using CleanCode.Domain;
using System.Threading.Tasks;

namespace CleanCode.Repository
{
    public class CotizarRapidoRepository
    {

        public decimal Taxes { get; set; }
        public decimal Scoring { get; set; }
        public async Task<Quote> Cotizar(string branch, decimal insuredValue)
        {


            if (branch == "auto")
            {
                this.Taxes = 1.21M;
                this.Scoring = 1.0M;
            }
            else if (branch == "hogar")
            {
                this.Taxes = 1.25M;
                this.Scoring = 1.0M;
            }
            else if (branch == "motos")
            {
                throw new System.Exception("Ramo no soportado por el cotizador");
            }

            var price = insuredValue * Taxes * Scoring / 100;

            Quote quote = new Quote(price, insuredValue);
            return quote;
        }
    }
}
