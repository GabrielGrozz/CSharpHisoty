using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LOGIN_SYSTEM.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
       public AppDbContext(DbContextOptions option ) : base( option ) { }
    }
}
