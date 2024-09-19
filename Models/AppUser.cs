using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AppUser : IdentityUser<int>
    {
        public DateOnly DateOfBirth { get; set; }
        public required string KnownAs { get; set; }
        public DateTime LastActive { get; set; } = DateTime.UtcNow;
        public required string Gender { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public List<Photos> Photos { get; set; } = [];
        public ICollection<AppUserRole> UserRoles { get; set; } = [];
    }
}
