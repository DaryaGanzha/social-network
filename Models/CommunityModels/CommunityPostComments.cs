using System;

namespace simple_social_network.Models.CommunityModels
{
    public class CommunityPostComments
    {
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime PostCommentDate { get; set; }
        
        public CommunityPosts CommunityPost { get; set; }
    }
}