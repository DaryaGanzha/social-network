using System;
using System.ComponentModel.DataAnnotations;

namespace simple_social_network.Models.CommunityModels
{
    public class CommunitySubscriptions
    {
        [Key]
        public Guid CommunityId { get; set; }
        [Key]
        public Guid UserId { get; set; }
        public DateTime SubscribeDate { get; set; }
        
        public Communities Community { get; set; }
        public User User { get; set; }
    }
}