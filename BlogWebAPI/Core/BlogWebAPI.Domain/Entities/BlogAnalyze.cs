using BlogWebAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Domain.Entities
{
    public class BlogAnalyze : BaseEntity
    {
        public int TotaleScore { get; set; }
        public int RaytingCount { get; set; }
        public Guid BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
