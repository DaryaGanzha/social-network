using System;
using System.ComponentModel.DataAnnotations;

namespace simple_social_network.Models
{
    public class UserPostLikes
    {
        [Key]
        public Guid PostId { get; set; }
        [Key]
        public Guid UserId { get; set; }
        
        public UserPosts UserPost { get; set; }
    }
}