﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace simple_social_network.Models
{
    public class UserPosts
    {
        [Key]
        public Guid PostId
        {
            get { return PostId; }
            set { PostId = Guid.NewGuid(); }
        }
        public Guid UserId { get; set; }
        public string PhotoLink { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        
        public User User { get; set; }
        public ICollection<UserPostLikes> UserPostLikes { get; set; }
        public ICollection<UserPostComments> UserPostComments { get; set; }
    }
}