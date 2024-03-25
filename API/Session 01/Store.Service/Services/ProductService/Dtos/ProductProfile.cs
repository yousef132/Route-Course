using AutoMapper;
using Store.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Services.ProductService.Dtos
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDetailsDto>()
                .ForMember(

                dist => dist.BrandName, // ProductDetailsDto
                options => options.MapFrom(src => src.Brand.Name)//Product

                )
                .ForMember(

                dist => dist.TypeName, // ProductDetailsDto
                options => options.MapFrom(src => src.Type.Name)//Product

                )
                .ForMember(

                dist => dist.PictureUrl, // ProductDetailsDto
                options => options.MapFrom<ProductUrlResolver>()//Product

                );


            CreateMap<ProductBrand, BrandTypeDetailsDto>();
            CreateMap<ProductType, BrandTypeDetailsDto>();



        }

    }
}
