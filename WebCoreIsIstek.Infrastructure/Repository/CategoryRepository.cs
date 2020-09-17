using WebCoreIsIstek.Core.Entities;
using WebCoreIsIstek.Core.Repositories;
using WebCoreIsIstek.Core.Specifications;
using WebCoreIsIstek.Infrastructure.Data;
using WebCoreIsIstek.Infrastructure.Repository.Base;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreIsIstek.Infrastructure.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(WebCoreIsIstekContext dbContext) : base(dbContext)
        {            
        }

        public async Task<Category> GetCategoryWithProductsAsync(int categoryId)
        {            
            var spec = new CategoryWithProductsSpecification(categoryId);
            var category = (await GetAsync(spec)).FirstOrDefault();
            return category;
        }
    }
}
