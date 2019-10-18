using System.Collections.Generic;

namespace CleanCode.Domain
{
    public class Quote
    {
        public Quote(decimal price ,decimal insuredValue) 
        {
            this.P = price;
            this.InsuredValue = insuredValue;
        }

        //Meaninful Names - Use Intention-Revealing Names
        /// <summary>
        /// Precio
        /// </summary>
        public decimal P { get; set; }
        /// <summary>
        /// Suma asegurada
        /// </summary>
        public decimal InsuredValue { get; set; }
    }
}
