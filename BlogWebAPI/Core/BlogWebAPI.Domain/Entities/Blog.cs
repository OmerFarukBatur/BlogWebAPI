using BlogWebAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Domain.Entities
{
    public class Blog :BaseEntity
    {
        public string BlogName { get; set; }
        public string Content { get; set; }

        public Guid CategoryId { get; set; }
        public Guid AdminId { get; set; }
        public Category Category { get; set; }
        public Admin Admin { get; set; }
        public ICollection<BlogAnalyze> BlogAnalyzes { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
