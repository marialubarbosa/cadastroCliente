using Microsoft.EntityFrameworkCore;
using cadastroCliente.Models;

namespace cadastroCliente.Data
{
    public class cadastroClienteContext : DbContext
    {
        public cadastroClienteContext (DbContextOptions<cadastroClienteContext> options)
            : base(options)
        {
        }

        public DbSet<cliente> cliente { get; set; }
    }
}