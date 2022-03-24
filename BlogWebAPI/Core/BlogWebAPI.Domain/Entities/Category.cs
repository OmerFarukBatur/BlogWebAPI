using BlogWebAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Domain.Entities
{
    public class Category : BaseEntity 
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
