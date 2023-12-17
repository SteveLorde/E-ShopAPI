using API.Data.DTOs;
using API.Data.Models;
using AutoMapper;

namespace API.Services.AutoMapperProfiles;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        CreateMap<UserDTO, User>();
        CreateMap<ProductDTO, Product>();
        CreateMap<PurchaseLogDTO, PurchaseLog>();
        CreateMap<AuthRequestDTO, UserDTO>();
    }
}