using BlogWebAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Domain.Entities
{
    public class Image : BaseEntity
    {
        public string ImageUrl { get; set; }
        public Guid BlogId { get; set; }
        public Guid AboutId { get; set; }

        public Blog Blog { get; set; }
        public About About { get; set; }
    }
}
