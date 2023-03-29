using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

public class RoleEditModel
{
  public IdentityRole Role { get; set; }
  public IEnumerable<AppUser> Members { get; set; }
  public IEnumerable<AppUser> NonMembers { get; set; }
}
