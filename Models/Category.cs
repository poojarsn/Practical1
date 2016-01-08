using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Category
    {
        [SitecoreId]
        public virtual Guid CategoryId      { get; set; }
        public virtual string Title         { get; set; }
        public virtual string Description   { get; set; }
        public virtual Image SmallImage     { get; set; }
    }
    public class CategoryItem
    {
        public  Guid CategoryId { get; set; }
        public  string Title { get; set; }
        public  string Description { get; set; }
        public  Image SmallImage { get; set; }
    }
}