using WebCoreIsIstek.Core.Entities;
using WebCoreIsIstek.Core.Repositories.Base;
using System.Threading.Tasks;

namespace WebCoreIsIstek.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetCategoryWithProductsAsync(int categoryId);
    }
}
