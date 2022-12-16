using System;

namespace simple_social_network.Models.CommunityModels
{
    public class CommunityPostLikes
    {
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        
        public CommunityPosts CommunityPost { get; set; }
    }
}