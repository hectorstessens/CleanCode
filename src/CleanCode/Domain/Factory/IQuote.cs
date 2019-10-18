namespace CleanCode.Domain.Factory
{
    public interface IQuote
    {
        Quote GetQuote(decimal insuredValue);
    }
}