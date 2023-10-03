using ShopNow.Model;
using ShopNow.Repository.Common.Repository.Inerface;
using ShopNow.Repository.EF;





namespace ShopNow.Repository.Common.Repository.Impl
{
    public class CategoryRepositery:EFRepositoryBase<EcommerceContext,Category,int>,ICategoryRepositery
    {
    }
}
