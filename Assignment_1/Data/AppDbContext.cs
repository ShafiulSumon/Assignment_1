using System;
using Assignment_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<SignupEntity> Signups { get; set; }
}

