using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using simple_social_network.Models.CommunityModels;

namespace simple_social_network.Models
{
    public class User
    {
        [Key]
        public Guid UserId
        {
            get { return UserId; }
            set { UserId = Guid.NewGuid(); }
        }
        public string FirstName { get; set; } = null!;
        public string SecondName { get; set; } = null!;
        public string Description { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CurrentCity { get; set; }
        public DateTime DateOfCreation { get; set; }
        
        public ICollection<Friendship> Friendships { get; set; }
        public ICollection<UserPosts> UserPosts { get; set; }
        public ICollection<CommunitySubscriptions> CommunitySubscriptions { get; set; }
    }
}