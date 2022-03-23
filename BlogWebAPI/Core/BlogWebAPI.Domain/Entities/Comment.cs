using BlogWebAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogScore { get; set; }

        public User User { get; set; }

        //public Guid AdminId { get; set; }  yorumun yorumu olayı var
    }
}
