using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace api.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public DateTime CreateTime{ get; set; } 
        public Author? Author { get; set; }
        public List<Like>? Likes { get; set; } = new List<Like>();
        public List<CommunityUser>? CommunityUsers { get; set; } = new List<CommunityUser>();

        public User()
        {
            CreateTime = DateTime.UtcNow; 
        }
    }
}