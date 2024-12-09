using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Services
{
    public interface IPostStatusServices
    {
        Task<List<PostStatus>> GetAllPostStatus();
        Task<PostStatus> GetPostStatusById(int id);
        Task CreatePostStatus(PostStatus postStatus);
        Task UpdatePostStatus(PostStatus postStatus);
        Task DeletePostStatus(int id);
    }
}

