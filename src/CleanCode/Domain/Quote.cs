using System.Collections.Generic;

namespace CleanCode.Domain
{
    public class Quote
    {

        /// <summary>
        /// Coberturas
        /// </summary>
        public List<Coverage> Coverages { get; set; }

        //Use Intention-Revealing Names
        public decimal P { get; set; }
        public decimal I { get; set; }
        public decimal S { get; set; }
        public decimal I2 { get; set; }
    }
}
