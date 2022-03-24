using BlogWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Application.Repositories
{
    public interface ICommentWriteRepository : IWriteRepository<Comment>
    {
    }
}
