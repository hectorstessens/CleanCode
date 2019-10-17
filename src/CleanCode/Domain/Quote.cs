using System.Collections.Generic;

namespace CleanCode.Domain
{
    public class Quote
    {

        /// <summary>
        /// Coberturas
        /// </summary>
        public List<Coverage> Coverages { get; set; }

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
