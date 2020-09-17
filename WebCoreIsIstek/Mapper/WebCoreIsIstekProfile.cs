//using WebCoreIsIstek.Application.Models;
using WebCoreIsIstek.ViewModels;
using AutoMapper;
using WebCoreIsIstek.Application.Models;

namespace WebCoreIsIstek.Mapper
{
    public class WebCoreIsIstekProfile : Profile
    {
        public WebCoreIsIstekProfile()
        {
            CreateMap<ProductModel, ProductViewModel>();
            CreateMap<CategoryModel, CategoryViewModel>();
        }
    }
}
