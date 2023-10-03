using ShopNow.Model;
using ShopNow.Repository.Common.Repository.Inerface;
using ShopNow.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Repository.Common.Repository.Impl
{
    public class ProductRepository :EFRepositoryBase<EcommerceContext,Product,int>,IProductRepository
    {
    }
}
