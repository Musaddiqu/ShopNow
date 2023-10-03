using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Model
{
    public class Product : IEntity<int>
    {
        public int Id { get; set;}
        public String Name { get; set;}
        public DateTime ExpiryDate { get; set;}

    }
}
