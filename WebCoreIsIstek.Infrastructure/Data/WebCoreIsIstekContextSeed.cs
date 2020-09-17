using WebCoreIsIstek.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreIsIstek.Infrastructure.Data;

namespace WebCoreIsIstek.Infrastructure.Data
{
    public class WebCoreIsIstekContextSeed
    {
        public static async Task SeedAsync(WebCoreIsIstekContext webCoreIsIstekContext, 
            ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;

            try
            {
                // TODO: Only run this if using a real database
                // aspnetrunContext.Database.Migrate();
                // aspnetrunContext.Database.EnsureCreated();

                //if (!webCoreIsIstekContext.Categories.Any())
                //{
                //    webCoreIsIstekContext.Categories.AddRange(GetPreconfiguredCategories());
                //    await webCoreIsIstekContext.SaveChangesAsync();
                //}

                //if (!webCoreIsIstekContext.Products.Any())
                //{
                //    webCoreIsIstekContext.Products.AddRange(GetPreconfiguredProducts());
                //    await webCoreIsIstekContext.SaveChangesAsync();
                //}
            }
            catch (Exception exception)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<WebCoreIsIstekContextSeed>();
                    log.LogError(exception.Message);
                    await SeedAsync(webCoreIsIstekContext, loggerFactory, retryForAvailability);
                }
                throw;
            }
        }

        //private static IEnumerable<Category> GetPreconfiguredCategories()
        //{
        //    return new List<Category>()
        //    {
        //        new Category() { CategoryName = "Phone"},
        //        new Category() { CategoryName = "TV"}
        //    };
        //}

        //private static IEnumerable<Product> GetPreconfiguredProducts()
        //{
        //    return new List<Product>()
        //    {
        //        new Product() { ProductName = "IPhone", CategoryId = 1 , UnitPrice = 19.5M , UnitsInStock = 10, QuantityPerUnit = "2", UnitsOnOrder = 1, ReorderLevel = 1, Discontinued = false },
        //        new Product() { ProductName = "Samsung", CategoryId = 1 , UnitPrice = 33.5M , UnitsInStock = 10, QuantityPerUnit = "2", UnitsOnOrder = 1, ReorderLevel = 1, Discontinued = false },
        //        new Product() { ProductName = "LG TV", CategoryId = 2 , UnitPrice = 33.5M , UnitsInStock = 10, QuantityPerUnit = "2", UnitsOnOrder = 1, ReorderLevel = 1, Discontinued = false }
        //    };
        //}


    }
}
