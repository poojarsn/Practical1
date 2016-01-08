using Glass.Mapper.Sc;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class CategoryController : ApiController
    {
        public CategoryList categoryList { get; set; }
        public const string CATEGORY_ROOT_GUID = "{A547EA1E-D414-4521-80E0-A7C794BA3E8C}";
        
        // GET api/values
        [Route("root/api/category")]
        public List<CategoryItem> GetCategories()
        {
            //return new List<Category>();
            var context = new SitecoreContext();
            List<CategoryItem> categories = new List<CategoryItem>();
            categoryList = context.GetItem<CategoryList>(CATEGORY_ROOT_GUID);
            var categoryBucket = categoryList.Children.Select(a => new Category() 
            { 
                CategoryId = a.CategoryId,
                Title = a.Title, 
                Description = a.Description, 
                SmallImage = a.SmallImage 
            }).ToList<Category>().Where(x => x.Title != null);
            foreach (var v in categoryBucket)
            {
                categories.Add(new CategoryItem() { 
                CategoryId=v.CategoryId,
                Title=v.Title,
                Description=v.Description,
                SmallImage=v.SmallImage
                });
            }
            return categories;
        } 
    }
}