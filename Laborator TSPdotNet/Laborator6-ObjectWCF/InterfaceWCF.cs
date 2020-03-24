using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Laborator6_PostComment;

namespace Laborator6_ObjectWCF
{
    [ServiceContract]
    interface InterfacePost
    {
        [OperationContract]
        bool AddPost(Post post);
        [OperationContract]
        Post UpdatePost(Post post);
        [OperationContract]
        int DeletePost(int id);
        [OperationContract]
        Post GetPostById(int id);
        [OperationContract]
        List<Post> GetPosts();
    }
    [ServiceContract]
    interface InterfaceComment
    {
        [OperationContract]
        bool AddComment(Comment comment);
        [OperationContract]
        Comment UpdateComment(Comment newComment);
        [OperationContract]
        Comment GetCommentById(int id);
    }
    [ServiceContract]
    interface IPostComment : InterfacePost, InterfaceComment
    {
    }
}

