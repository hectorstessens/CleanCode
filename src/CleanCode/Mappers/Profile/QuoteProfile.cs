using AutoMapper;
using CleanCode.Domain;
using CleanCode.Services.Queries;

namespace CleanCode.Mappers
{
    public class QuoteProfile : Profile
    {
        public QuoteProfile()
        {
            CreateMap<Quote, QuoteResponse>()
                .ForMember(d => d.Branch, s => s.Ignore())
                .ForMember(d => d.SumaAsegurada, s => s.MapFrom(x => x.InsuredValue))
                .ForMember(d => d.Precio, s => s.MapFrom(x => x.P));
        }
    }
}
