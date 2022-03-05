using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster.Model
{
    public class TaskMasterDbContext:DbContext
    {    
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-G98N2GM\\SQLEXPRESS ; Initial Catalog=TaskMasterDB ; Integrated Security=true");
        }       
    }
}
