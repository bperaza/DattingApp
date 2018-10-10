using Microsoft.EntityFrameworkCore;
using DatingApp_API.Models;
using JetBrains.Annotations;

namespace DatingApp_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}

        public DbSet<Value> Values { get; set; }      
    }
}