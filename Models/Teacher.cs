using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace mvc.Models;

public class Teacher : IdentityUser
{


    [StringLength(20, MinimumLength = 5)]
    public string Lastname { get; set; }
    public string Firstname { get; set; }


    [Required]
    [Url]
    public string PersonalWebSite { get; set; }


}