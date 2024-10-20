using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RommsManagement.DB.Context
{
    public class RoomsManagementDbContext : IdentityDbContext
    {
        public RoomsManagementDbContext(DbContextOptions<RoomsManagementDbContext> options) : base(options)
        {
        }
    }
}
