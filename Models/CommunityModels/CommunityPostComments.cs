using System;
using System.ComponentModel.DataAnnotations;

namespace simple_social_network.Models.CommunityModels
{
    public class CommunityPostComments
    {
        [Key]
        public Guid PostId { get; set; }
        [Key]
        public Guid UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime PostCommentDate { get; set; }
        
        public CommunityPosts CommunityPost { get; set; }
    }
}