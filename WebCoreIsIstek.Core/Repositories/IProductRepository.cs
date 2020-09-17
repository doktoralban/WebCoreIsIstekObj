﻿using WebCoreIsIstek.Core.Entities;
using WebCoreIsIstek.Core.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebCoreIsIstek.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductListAsync();
        Task<IEnumerable<Product>> GetProductByNameAsync(string productName);
        Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId);
    }
}
