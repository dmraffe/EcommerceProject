using AutoMapper;
using Domino;

namespace Ecommerce.Models
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDTIN, Product>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre));
            CreateMap<Product, ProductDTO>().ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Name));
            CreateMap<Product, ProductDTIN>().ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Name));

            CreateMap<Category, CategoryDTO>().ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Name)).ForMember(dest=>dest.Descripcion, opt => opt.MapFrom(src => src.Description));CreateMap<Category, CategoryDTO>().ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Name)).ForMember(dest=>dest.Descripcion, opt => opt.MapFrom(src => src.Description));
            CreateMap<CategoryDTO, Category>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre)).ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Descripcion));

            CreateMap<CustomerAddres, AddressDTO>();
            CreateMap<AddressDTI, CustomerAddres>();

        }
    }
}
