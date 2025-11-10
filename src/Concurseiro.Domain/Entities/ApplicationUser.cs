using System;
using Microsoft.AspNetCore.Identity;

namespace Concurseiro.Domain.Entities;

public class ApplicationUser : IdentityUser<Guid>
{
    public string? FullName { get; set; }
    public virtual UserProfile? Profile { get; set; }
}
