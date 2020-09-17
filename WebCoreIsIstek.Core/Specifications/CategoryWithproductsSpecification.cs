using WebCoreIsIstek.Core.Entities;
using WebCoreIsIstek.Core.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebCoreIsIstek.Core.Specifications
{
    public sealed class CategoryWithProductsSpecification : BaseSpecification<Category>
    {
        public CategoryWithProductsSpecification(int categoryId)
            : base(b => b.Id == categoryId)
        {
            AddInclude(b => b.Products);
        }
    }    
}
