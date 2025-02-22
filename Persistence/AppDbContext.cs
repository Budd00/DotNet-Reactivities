using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

// A DbContext usually corresponds to your database and DbSet corresponds to a table
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Activity> Activities { get; set; }
}
