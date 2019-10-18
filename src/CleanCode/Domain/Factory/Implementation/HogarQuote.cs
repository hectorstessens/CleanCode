
namespace CleanCode.Domain.Factory
{
    public class HogarQuote : QuoteBase
    {
        private const decimal scoring = 1.5M;

        public HogarQuote() 
        {
            this.Scoring = scoring;
            this.Taxes = 0.21M;
        }
        public override Quote GetQuote(decimal insuredValue)
        {
            return new Quote(insuredValue * Scoring * Taxes, insuredValue);
        }
    }
}
