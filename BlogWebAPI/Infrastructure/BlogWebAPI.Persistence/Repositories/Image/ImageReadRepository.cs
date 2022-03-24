using BlogWebAPI.Application.Repositories;
using BlogWebAPI.Domain.Entities;
using BlogWebAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Persistence.Repositories
{
    public class ImageReadRepository : ReadRepository<Image>, IImageReadRepository
    {
        public ImageReadRepository(BlogWebAPIDbContext context) : base(context)
        {
        }
    }
}
