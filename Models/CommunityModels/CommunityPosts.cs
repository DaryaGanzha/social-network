using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace simple_social_network.Models.CommunityModels
{
    public class CommunityPosts
    {
        [Key]
        public Guid PostId
        {
            get { return PostId; }
            set { PostId = Guid.NewGuid(); }
        }
        public Guid CommunityId { get; set; }
        public string PhotoLink { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        
        public Communities Community { get; set; }
        public ICollection<CommunityPostLikes> CommunityPostLikes { get; set; }
        public ICollection<CommunitySubscriptions> CommunitySubscriptions { get; set; }
    }
}