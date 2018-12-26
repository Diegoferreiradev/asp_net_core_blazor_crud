using Core_Crud_Blazor.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_Crud_Blazor.Server.DataAcess
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Cliente> Clientes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
    }
}
