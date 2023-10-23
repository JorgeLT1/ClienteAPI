using Microsoft.EntityFrameworkCore;
using ClienteAPI.Models;

namespace ClienteAPI.DAL{

    public class Contexto : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options) { }

    }

}