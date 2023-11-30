using AutoMapper;
using WebApiAdvance.Entities;
using WebApiAdvance.Entities.Dtos.Products;

namespace WebApiAdvance.Profiles
{
    public class ProductProfile:Profile
    { 
        public ProductProfile()
        {
            CreateMap<Product, GetProductDto>();    
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}
