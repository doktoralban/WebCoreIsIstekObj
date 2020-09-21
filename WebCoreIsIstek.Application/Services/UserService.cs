using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebCoreIsIstek.Core.Entities;
using WebCoreIsIstek.Core.Interfaces;
using WebCoreIsIstek.Core.Repositories;
using WebCoreIsIstek.Application.Models;
using WebCoreIsIstek.Application.Mapper;
using WebCoreIsIstek.Application.Interfaces;
using WebCoreIsIstek.Core.Specifications.Base;
using System.Linq.Expressions;
using System.Linq;

namespace WebCoreIsIstek.Application.Services
{
    // TODO : add validation , authorization, logging, exception handling etc. -- cross cutting activities in here.
    public class UserService : IUserService 
    {
        private readonly IUsersRepository _userRepository;
        //private readonly IAppLogger<UserService> _logger;

        public UserService(IUsersRepository userRepository, IAppLogger<UserService> logger)
        {
            //_userRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            //_logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task<TbUsers> AddAsync(TbUsers entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(ISpecification<TbUsers> spec)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TbUsers entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TbUsers>> GetActiveUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<TbUsers>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TbUsers>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<TbUsers>> GetAsync(Expression<Func<TbUsers, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<TbUsers>> GetAsync(Expression<Func<TbUsers, bool>> predicate = null, Func<IQueryable<TbUsers>, IOrderedQueryable<TbUsers>> orderBy = null, string includeString = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<TbUsers>> GetAsync(Expression<Func<TbUsers, bool>> predicate = null, Func<IQueryable<TbUsers>, IOrderedQueryable<TbUsers>> orderBy = null, List<Expression<Func<TbUsers, object>>> includes = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<TbUsers>> GetAsync(ISpecification<TbUsers> spec)
        {
            throw new NotImplementedException();
        }

        public Task<TbUsers> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TbUsers> GetUserByUserIDAsync(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<TbUsers> GetUserByUserNameAsync(string UserName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TbUsers>> GetUsersByTypeAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TbUsers entity)
        {
            throw new NotImplementedException();
        }


        //public async Task<ProductModel> Create(ProductModel productModel)
        //{
        //    await ValidateProductIfExist(productModel);

        //    var mappedEntity = ObjectMapper.Mapper.Map<Product>(productModel);
        //    if (mappedEntity == null)
        //        throw new ApplicationException($"Entity could not be mapped.");

        //    var newEntity = await _productRepository.AddAsync(mappedEntity);
        //    _logger.LogInformation($"Entity successfully added - AspnetRunAppService");

        //    var newMappedEntity = ObjectMapper.Mapper.Map<ProductModel>(newEntity);
        //    return newMappedEntity;
        //}

        //public async Task Update(ProductModel productModel)
        //{
        //    ValidateProductIfNotExist(productModel);

        //    var editProduct = await _productRepository.GetByIdAsync(productModel.Id);
        //    if (editProduct == null)
        //        throw new ApplicationException($"Entity could not be loaded.");

        //    ObjectMapper.Mapper.Map<ProductModel, Product>(productModel, editProduct);

        //    await _productRepository.UpdateAsync(editProduct);
        //    _logger.LogInformation($"Entity successfully updated - AspnetRunAppService");
        //}

        //public async Task Delete(ProductModel productModel)
        //{
        //    ValidateProductIfNotExist(productModel);
        //    var deletedProduct = await _productRepository.GetByIdAsync(productModel.Id);
        //    if (deletedProduct == null)
        //        throw new ApplicationException($"Entity could not be loaded.");

        //    await _productRepository.DeleteAsync(deletedProduct);
        //    _logger.LogInformation($"Entity successfully deleted - AspnetRunAppService");
        //}

        //private async Task ValidateProductIfExist(ProductModel productModel)
        //{
        //    var existingEntity = await _productRepository.GetByIdAsync(productModel.Id);
        //    if (existingEntity != null)
        //        throw new ApplicationException($"{productModel.ToString()} with this id already exists");
        //}

        //private void ValidateProductIfNotExist(ProductModel productModel)
        //{
        //    var existingEntity = _productRepository.GetByIdAsync(productModel.Id);
        //    if (existingEntity == null)
        //        throw new ApplicationException($"{productModel.ToString()} with this id is not exists");
        //}



    }
}
