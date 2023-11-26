using API.Data.DTOs;
using API.Data.Models;
using AutoMapper;

namespace API.Services.AutoMapperProfiles;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        CreateMap<User, UserDTO>();
        CreateMap<Product, ProductDTO>();
        CreateMap<AuthRequestDTO, UserDTO>();
    }
}