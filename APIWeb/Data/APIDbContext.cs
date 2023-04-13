using APIWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace APIWeb.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
