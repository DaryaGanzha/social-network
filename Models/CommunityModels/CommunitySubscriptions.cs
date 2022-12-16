using System;

namespace simple_social_network.Models.CommunityModels
{
    public class CommunitySubscriptions
    {
        public Guid CommunityId { get; set; }
        public Guid UserId { get; set; }
        public DateTime SubscribeDate { get; set; }
        
        public Communities Community { get; set; }
        public User User { get; set; }
    }
}