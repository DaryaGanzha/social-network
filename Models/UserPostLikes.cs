using System;

namespace simple_social_network.Models
{
    public class UserPostLikes
    {
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        
        public UserPosts UserPost { get; set; }
    }
}