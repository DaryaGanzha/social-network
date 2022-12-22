using System;
using System.ComponentModel.DataAnnotations;

namespace simple_social_network.Models
{
    public class UserPostComments
    {
        [Key]
        public Guid PostId { get; set; }
        [Key]
        public Guid UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDateTime { get; set; }
        
        public UserPosts UserPost { get; set; }
    }
}