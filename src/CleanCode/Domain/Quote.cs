using System.Collections.Generic;

namespace CleanCode.Domain
{
    public class Quote
    {

        /// <summary>
        /// Coberturas
        /// </summary>
        public List<Coverage> Coverages { get; set; }
        /// <summary>
        /// Precio
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Suma Asegurada
        /// </summary>
        public decimal InsuredValue { get; set; }
    }
}
