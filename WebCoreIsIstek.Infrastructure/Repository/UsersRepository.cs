using Dapper;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using WebCoreIsIstek.Core.Entities;
using WebCoreIsIstek.Core.Repositories;
using WebCoreIsIstek.Infrastructure.Data;
using WebCoreIsIstek.Infrastructure.Repository.Base;

namespace WebCoreIsIstek.Infrastructure.Repository
{
    public class UsersRepository : Repository<TbUsers>, IUsersRepository
    {
        private   SqlConnection connection;

 
        public UsersRepository(WebCoreIsIstekContext dbContext) : base(dbContext)
        {
            connection = new SqlConnection(dbContext.Database.GetDbConnection().ConnectionString);

        }
       

        public async Task<IEnumerable<TbUsers>> GetAllUsersAsync()
        {
             return await connection.QueryAsync<TbUsers>("SELECT   * FROM dbo.TbUsers ");
        }

        public async  Task<IEnumerable<TbUsers>> GetActiveUsersAsync()
        {
             return await connection.QueryAsync<TbUsers>("SELECT * FROM dbo.TbUsers IsActive == 1"); 
        }
        public async Task<IEnumerable<TbUsers>> GetIsUsersActiveAsync(string UserName)
        {
             return await connection.QueryAsync<TbUsers>("SELECT * FROM dbo.TbUsers WHERE Active=1 AND UserName = @UserName");
        }
        public async Task<IEnumerable<TbUsers>> GetIsUsersActiveAsync(int UserId)
        {
             return await connection.QueryAsync<TbUsers>("SELECT * FROM dbo.TbUsers WHERE Active=1 AND UserId = @UserId");
        } 

        public async Task<TbUsers> GetUserByUserIDAsync(int UserId)
        {
             return (TbUsers)await connection.QueryAsync<TbUsers>("SELECT * FROM dbo.TbUsers WHERE UserId = @UserId");
        }

        public async Task<TbUsers> GetUserByUserNameAsync(string UserName)
        {
             return (TbUsers)await connection.QueryAsync<TbUsers>("SELECT * FROM dbo.TbUsers WHERE UserName = @UserName");
        }

        public async Task<IEnumerable<TbUsers>> GetUsersByTypeAsync(string Type)
        {
            return await connection.QueryAsync<TbUsers>("SELECT * FROM dbo.TbUsers WHERE Type=@Type ");
        }

         


    }
}
