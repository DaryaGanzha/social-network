using System;

namespace simple_social_network.Models
{
    public class UserPostComments
    {
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDateTime { get; set; }
        
        public UserPosts UserPost { get; set; }
    }
}