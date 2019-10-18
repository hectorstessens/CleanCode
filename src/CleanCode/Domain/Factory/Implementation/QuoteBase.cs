namespace CleanCode.Domain.Factory
{
    public abstract class QuoteBase : IQuote
    {
        /// <summary>
        /// Iva
        /// </summary>
        public decimal Taxes { get; set; }

        /// <summary>
        /// Scoring
        /// </summary>
        public decimal Scoring { get; set; }

        public virtual Quote GetQuote(decimal insuredValue)
        {
            throw new System.NotImplementedException();
        }
    }
}
