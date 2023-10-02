using System.Data.Entity;



namespace ShopNow.Repository.EF
{
    public class EcommerceContext :DbContext
    {
        public EcommerceContext() :base("EcommConnSt") 
        {

        }

        public DbSet<Model.Product> Products { get; set; }
        public DbSet<Model.Category> Categories { get; set; }
    }
}
