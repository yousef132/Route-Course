using AutoMapper;
using Store.Data.Entities;
using Store.Repository.Interfaces;
using Store.Service.Services.ProductService.Dtos;

namespace Store.Service.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IReadOnlyList<BrandTypeDetailsDto>> GetAllBrandsAsync()
        {
            var brands = await unitOfWork.Reposirory<ProductBrand, int>().GetAllAsync();

            var mappedBrands = mapper.Map<IReadOnlyList<BrandTypeDetailsDto>>(brands);

            return mappedBrands;
        }

        public async Task<IReadOnlyList<ProductDetailsDto>> GetAllProductsAsync()
        {
            var products = await unitOfWork.Reposirory<Product, int>().GetAllAsync();

            var mappedProducts = mapper.Map<IReadOnlyList<ProductDetailsDto>>(products);

            return mappedProducts;
        }

        public async Task<IReadOnlyList<BrandTypeDetailsDto>> GetAllTypesAsync()
        {
           var types = await unitOfWork.Reposirory<ProductType, int>().GetAllAsync();
            var mappedTypes = mapper.Map<IReadOnlyList<BrandTypeDetailsDto>>(types);
            return mappedTypes;
        }

        public async Task<ProductDetailsDto> GetProductByIdAsync(int? Id)
        {
            if(Id is null) 
                throw new ArgumentNullException("Id Is Null");
            Product product = await unitOfWork.Reposirory<Product, int>().GetByIdAsync(Id.Value);
            var mappedProduct = mapper.Map<ProductDetailsDto>(product);
            return mappedProduct;
        }
    }
}