
namespace CleanCode.Domain.Factory
{
    public class HogarQuote : QuoteBase
    {

        public HogarQuote() 
        {
            this.Scoring = 1.5M;
            this.Taxes = 0.21M;
        }
        public override Quote GetQuote(decimal insuredValue)
        {
            return new Quote(insuredValue * Scoring * Taxes / 100, insuredValue);
        }
    }
}
