using AutoMapper;
using indiGo.Core.ViewModels;
using indiGo.Data.Entities;

namespace indiGo.Business.MappingProfiles;

public class ViewModelMappingProfile : Profile
{
    public ViewModelMappingProfile()
    {
        CreateMap<Address, AddressViewModel>();
        
        
    }
}