using BlogWebAPI.Domain.Entities;
using BlogWebAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogWebAPI.Persistence.Contexts;

namespace BlogWebAPI.Persistence.Repositories
{
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(BlogWebAPIDbContext context) : base(context)
        {
        }
    }
}
