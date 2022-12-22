using System;
using System.ComponentModel.DataAnnotations;

namespace simple_social_network.Models.CommunityModels
{
    public class CommunityPostLikes
    {
        [Key]
        public Guid PostId { get; set; }
        [Key]
        public Guid UserId { get; set; }
        
        public CommunityPosts CommunityPost { get; set; }
    }
}