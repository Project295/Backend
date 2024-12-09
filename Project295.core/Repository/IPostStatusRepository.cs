using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Repository
{
    public interface IPostStatusRepository
    {
         List<PostStatus> GetAllPostStatus();
         PostStatus GetPostStatusById(int id);
         void CreatePostStatus(PostStatus postStatus);
         void UpdatePostStatus(PostStatus postStatus);
         void DeletePostStatus(int id);
    }
}
