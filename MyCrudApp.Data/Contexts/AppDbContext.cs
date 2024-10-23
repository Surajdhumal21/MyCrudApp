using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyCrudApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrudApp.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
           
        }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {
            
        }
         public DbSet<Employee> employees { get; set; } 
    }
}
