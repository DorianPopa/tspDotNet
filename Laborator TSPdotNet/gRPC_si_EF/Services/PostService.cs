using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Grpc.Core;
using gRPC_si_EF.Models;
using gRPC_si_EF.Repositories;

namespace gRPC_si_EF.Services
{
    public class PostService : PostCommentService.PostCommentServiceBase
    {
        private readonly ILogger<PostService> _logger;

        private readonly PostRepository _postRepository;

        public PostService(ILogger<PostService> logger, PostRepository postRepository)
        {
            _logger = logger;

            _postRepository = postRepository;
        }

        public async Task<PostProto> CreatePost(Post post)
        {
            if (_postRepository.AddPost(post) > 0)
                return post;
            return null;
        }

        public List<Post> GetAllPosts()
        {
            return _postRepository.GetAllPosts();
        }

        public Post GetPostById(Guid id)
        {
            if(id != Guid.Empty)
                return _postRepository.GetPostById(id);
            return null;
        }

        public bool DeletePost(Guid id)
        {
            if (_postRepository.DeletePost(id) > 0)
                return true;
            return false;
        }

        public Post UpdatePost(Post newPost)
        {
            Post returnPost = _postRepository.UpdatePost(newPost);
            if (returnPost != null)
                return returnPost;
            return null;
        }
    }
}
