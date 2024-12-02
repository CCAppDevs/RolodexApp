using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RolodexApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the RolodexUser class
public class RolodexUser : IdentityUser
{
    public string? FavoriteColor { get; set; }
}

