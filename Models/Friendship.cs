using System;

namespace simple_social_network.Models
{
    public class Friendship
    {
        public Guid FriendshipId = Guid.NewGuid();
        public Guid FirstFriendId { get; set; }
        public Guid SecondFriendId { get; set; }
        public DateTime FriendshipStartTime { get; set; }
        
        public User User { get; set; }
    }
}