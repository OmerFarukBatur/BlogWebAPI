using BlogWebAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Domain.Entities
{
    public class Admin : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string imageUrl { get; set; }

        public ICollection<Blog> Blogs { get; set; }
        public ICollection<About> Abouts { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
