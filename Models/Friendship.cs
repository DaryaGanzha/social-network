using System;
using System.ComponentModel.DataAnnotations;

namespace simple_social_network.Models
{
    public class Friendship
    {
        [Key]
        public Guid FriendshipId
        {
            get { return FriendshipId; }
            set { FriendshipId = Guid.NewGuid(); }
        }
        public Guid FirstFriendId { get; set; }
        public Guid SecondFriendId { get; set; }
        public DateTime FriendshipStartTime { get; set; }
        
        public User User { get; set; }
    }
}