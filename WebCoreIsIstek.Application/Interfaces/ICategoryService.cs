using WebCoreIsIstek.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebCoreIsIstek.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryModel>> GetCategoryList();
    }
}
