using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
      public required string FullName { get; set; }
}
