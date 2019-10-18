using System;
namespace CleanCode.Domain.Factory
{
    public class AutoQuote : QuoteBase
    {
        public AutoQuote()
        {
            decimal scoring = 10;
            this.Scoring = scoring;
            this.Taxes = 0.21M;
        }
        public override Quote GetQuote(decimal insuredValue)
        {
            return new Quote(insuredValue * Scoring * Taxes, insuredValue);
        }
    }
}
