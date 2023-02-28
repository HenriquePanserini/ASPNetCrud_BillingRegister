using CRUDRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDRegister.Data
{
    public class tasksData : DbContext
    {

        public tasksData(DbContextOptions<tasksData> options) :base(options) 
        { 
            
        }

        public DbSet<userModels> Users { get; set; }
    }
}
