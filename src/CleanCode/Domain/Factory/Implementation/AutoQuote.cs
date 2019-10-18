using System;
namespace CleanCode.Domain.Factory
{
    public class AutoQuote : QuoteBase
    {
        public AutoQuote()
        {
            this.Scoring = 1;
            this.Taxes = 0.21M;
        }
        public override Quote GetQuote(decimal insuredValue)
        {
            return new Quote(insuredValue * Scoring * Taxes /100, insuredValue);
        }
    }
}
