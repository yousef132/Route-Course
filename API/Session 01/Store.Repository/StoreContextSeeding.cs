using Microsoft.Extensions.Logging;
using Store.Data.Entities;
using Store.Data.StoreDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Store.Repository
{
    public class StoreContextSeeding
    {


        public static async Task SeedAsync(StoreDbContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (context.ProductBrands != null && !context.ProductBrands.Any())
                {
                    var brandsdata = File.ReadAllText("../Store.Repository/DataSeeding/brands.json");

                    // Deserialization (json=>object)

                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsdata);

                    if (brands != null)
                    {
                         await context.ProductBrands.AddRangeAsync(brands);

                    }

                }
                if (context.ProductTypes != null && !context.ProductTypes.Any())
                {
                    var typesData = File.ReadAllText("../Store.Repository/DataSeeding/types.json");

                    // Deserialization (json=>object)

                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                    if (types != null)
                    {
                        await context.ProductTypes.AddRangeAsync(types);

                    }

                } 
                if (context.Products != null && !context.Products.Any())
                {
                    var ProductssData = File.ReadAllText("../Store.Repository/DataSeeding/products.json");

                    // Deserialization (json=>object)

                    var products = JsonSerializer.Deserialize<List<Product>>(ProductssData);

                    if (products != null)
                    {
                        await context.Products.AddRangeAsync(products);

                    }

                }
                await context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeeding>();
                logger.LogError(ex.Message);
            }
        }
    }
}
