using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class TasksContext : DbContext
    {
        public TasksContext(DbContextOptions options) : base(options){}
        public DbSet<Tasks> tasks{ get; set; }
    }
}