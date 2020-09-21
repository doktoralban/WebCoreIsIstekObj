using WebCoreIsIstek.Core.Entities;
using WebCoreIsIstek.Core.Repositories.Base;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebCoreIsIstek.Core.Repositories
{
    public interface IUsersRepository : IRepository<TbUsers>
    {
        Task<IEnumerable<TbUsers>> GetAllUsersAsync();
        Task<TbUsers> GetUserByUserIDAsync(int UserId);

        Task<TbUsers> GetUserByUserNameAsync(string UserName);

         Task<IEnumerable<TbUsers>> GetUsersByTypeAsync(string Type);

         Task<IEnumerable<TbUsers>> GetActiveUsersAsync();

        Task<IEnumerable<TbUsers>> GetIsUsersActiveAsync(string UserName);
        Task<IEnumerable<TbUsers>> GetIsUsersActiveAsync(int UserId);

 

    }
}
