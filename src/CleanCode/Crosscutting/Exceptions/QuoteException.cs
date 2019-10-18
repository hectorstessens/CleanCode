using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using FluentValidation.Results;

namespace CleanCode.Crosscutting.Exceptions
{

    [Serializable()]
    public class QuoteException : Exception
    {
        public QuoteException(string message) : base(message) { }
        public QuoteException(string message, Exception inner) : base(message, inner) { }
        protected QuoteException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}
