using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class CategoryList
    {
        public virtual IEnumerable<Category> Children { get; set; }
    }
}