using BlogAPI.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Repositories.Interface
{
   public interface IBlogPostRepository
    {
        Task<BlogPost> CreateAsync(BlogPost blogPost);
        Task<IEnumerable<BlogPost>> GetAllAsync();
        Task<BlogPost> GetByIdAsync(Guid id);
        Task<BlogPost> GetByUrlHandleAsync(string urlHandle);
        Task<BlogPost> UpdateAsync(BlogPost blogPost);
        Task<BlogPost> DeleteAsync(Guid id);
    }
}
