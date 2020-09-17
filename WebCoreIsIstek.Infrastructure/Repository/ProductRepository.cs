using WebCoreIsIstek.Core.Entities;
using WebCoreIsIstek.Core.Repositories;
using WebCoreIsIstek.Core.Specifications;
using WebCoreIsIstek.Infrastructure.Data;
using WebCoreIsIstek.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCoreIsIstek.Infrastructure.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(WebCoreIsIstekContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Product>> GetProductListAsync()
        {
            var spec = new ProductWithCategorySpecification();
            return await GetAsync(spec);

            // second way
            // return await GetAllAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByNameAsync(string productName)
        {
            var spec = new ProductWithCategorySpecification(productName);
            return await GetAsync(spec);

            // second way
            // return await GetAsync(x => x.ProductName.ToLower().Contains(productName.ToLower()));

            // third way
            //return await _dbContext.Products
            //    .Where(x => x.ProductName.Contains(productName))
            //    .ToListAsync();
        }

        //TODO: Değiştirilecek
        public async Task<IEnumerable<TbJobTypes>> GetProductByCategoryAsync(int categoryId)
        {
            return await _dbContext.TbJobTypes
                .Where(x => x.JobTypeId==categoryId)
                .ToListAsync();
        }

        Task<IEnumerable<Product>> IProductRepository.GetProductByCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
