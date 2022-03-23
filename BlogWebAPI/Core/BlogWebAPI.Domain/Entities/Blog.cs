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
        
    }
}
