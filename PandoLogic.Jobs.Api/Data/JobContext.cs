using Microsoft.EntityFrameworkCore;
using PandoLogic.Jobs.Api.Models;

namespace PandoLogic.Jobs.Api.Data
{
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext> options) : base(options) 
        { 

        }

        public DbSet<JobData>? Jobs { get; set; }
    }
}
