using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace E_MovieTicket.Models;

public class ApplicationUser:IdentityUser
{
    [Display(Name = "Full name")]
    public string FullName { get; set; }
}