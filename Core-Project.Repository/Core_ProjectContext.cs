using System;
using Microsoft.EntityFrameworkCore;

namespace Core_Project.Repository
{
    public class Core_ProjectContext : DbContext
    {
        public Core_ProjectContext(DbContextOptions<Core_ProjectContext> options) : base (options) {}        

    }
}
