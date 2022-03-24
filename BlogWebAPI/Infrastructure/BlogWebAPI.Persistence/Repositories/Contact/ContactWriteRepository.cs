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
    public class ContactWriteRepository : WriteRepository<Contact>, IContactWriteRepository
    {
        public ContactWriteRepository(BlogWebAPIDbContext context) : base(context)
        {
        }
    }
}
