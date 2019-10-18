using CleanCode.Crosscutting.Globalization;
using CleanCode.Crosscutting.Identifiers;
using System;
using System.Collections.Generic;

namespace CleanCode.Domain.Factory
{

    public class QuoteFactory : IQuoteFactory
    {
        private readonly static IDictionary<string, Type> QuoteTypes = new Dictionary<string, Type>()
        {
            [Branch.Auto] = typeof(AutoQuote),
            [Branch.Hogar] = typeof(HogarQuote),

        };

        public IQuote Create(string branch)
        {
            Type type;

            if (QuoteTypes.TryGetValue(branch, out type))
                return (IQuote)Activator.CreateInstance(type);

            throw new NotSupportedException(String.Format(Messages.NoSuportedType, branch));
        }
    }

    public interface IQuoteFactory
    {
        IQuote Create(string branch);
    }
}
