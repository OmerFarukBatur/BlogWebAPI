using BlogWebAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Domain.Entities
{
    public class About : BaseEntity
    {
        public string DetailOne { get; set; }
        public string DetailTwo { get; set; }
        public string MapLocation { get; set; }

        public Guid AdminId { get; set; }
        public Admin Admin { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
