using WebCoreIsIstek.Core.Entities;
using WebCoreIsIstek.Core.Specifications.Base;

namespace WebCoreIsIstek.Core.Specifications
{
    public class ProductWithCategorySpecification : BaseSpecification<Product>
    {
        public ProductWithCategorySpecification(string productName) 
            : base(p => p.ProductName.ToLower().Contains(productName.ToLower()))
        {
            AddInclude(p => p.Category);
        }

        public ProductWithCategorySpecification() : base(null)
        {
            AddInclude(p => p.Category);
        }
    }
}
