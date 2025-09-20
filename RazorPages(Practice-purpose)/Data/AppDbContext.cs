
using Microsoft.EntityFrameworkCore;
using RazorPages_Practice_purpose_.Data;

namespace RazorPages_Practice_purpose_.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Employee> Employees { get; set; }
}
