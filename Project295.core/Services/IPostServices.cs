using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Services
{
    public interface IPostServices
    {
        Task<List<Post>> GetAllPosts();
        Task<Post> GetPostById(int id);
        Task CreatePost(Post post);
        Task UpdatePost(Post post);
        Task DeletePost(int id);
    }
}
