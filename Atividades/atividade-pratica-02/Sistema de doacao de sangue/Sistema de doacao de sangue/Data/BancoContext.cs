using Microsoft.EntityFrameworkCore;
using Sistema_de_doacao_de_sangue.Models;

namespace Sistema_de_doacao_de_sangue.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<DoacaoModel> Doacao { get; set; }


    }
}
