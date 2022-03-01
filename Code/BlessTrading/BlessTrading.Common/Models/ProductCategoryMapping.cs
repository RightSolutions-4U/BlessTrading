using System;
using System.Collections.Generic;

#nullable disable

namespace BlessTrading.Common.Models
{
    public partial class ProductCategoryMapping
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public bool IsFeaturedProduct { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<Category> Category { get; set; }
        /*public ICollection<Category> Categories { get; set; }*/
        //public virtual Product Product { get; set; }
    }
}
