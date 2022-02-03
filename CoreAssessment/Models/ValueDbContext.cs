using Microsoft.EntityFrameworkCore;

namespace CoreAssessment.Models
{
    public class ValueDbContext:DbContext
    {
        
public ValueDbContext(DbContextOptions<ValueDbContext> options) : base(options)
        {

        }
        public DbSet<UserInfo> userinfo { get; set; }
        public DbSet<Token> token { get; set; }


    }
}
