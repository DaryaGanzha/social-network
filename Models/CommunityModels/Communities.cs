using System;
using System.Collections;
using System.Collections.Generic;

namespace simple_social_network.Models.CommunityModels
{
    public class Communities
    {
        public Guid CommunityId { get; set; }
        public string CommunityName { get; set; }
        public string Description { get; set; }
        public DateTime DateOfCreation { get; set; }
        // скорее всего здесь еще нужно хранить список подписок на сообщество (а в юзере тогда список сообществ) done
        
        public ICollection<CommunitySubscriptions> CommunitySubscriptions { get; set; } 
        public ICollection<CommunityPosts> CommunityPosts { get; set; }
    }
}