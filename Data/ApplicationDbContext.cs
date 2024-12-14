
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvc.Models;

namespace mvc.Data;



public class ApplicationDbContext : IdentityDbContext<Teacher>
{


    public DbSet<Student> Students { get; set; }

    public DbSet<Event> Events { get; set; }



    // Constructeur de la classe
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}