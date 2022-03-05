using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BlessTrading.Common.Models
{
    public partial class ProductProductAttributeMapping
    {
        public ProductProductAttributeMapping()
        {
            ProductAttributeValues = new HashSet<ProductAttributeValue>();
           /* ProductAttributes = new HashSet<ProductAttribute>();*/
        }

        public int Id { get; set; }
        public int ProductAttributeId { get; set; }
        public int ProductId { get; set; }
        public string TextPrompt { get; set; }
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int DisplayOrder { get; set; }
        public int? ValidationMinLength { get; set; }
        public int? ValidationMaxLength { get; set; }
        public string ValidationFileAllowedExtensions { get; set; }
        public int? ValidationFileMaximumSize { get; set; }
        public string DefaultValue { get; set; }
        public string ConditionAttributeXml { get; set; }

        /*public virtual Product Product { get; set; }*/
        /*public virtual ProductAttribute ProductAttribute { get; set; }*/
        [ForeignKey("ProductAttributeMappingId")]
        public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }
        ///[ForeignKey("ProductAttributeId")]
/*        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }*/
    }
}
