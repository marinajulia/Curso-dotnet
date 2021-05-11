using API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Context
{//vai receber as tabelas relacionadas a entidade e faz um conjunto com o EntityFramework
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }//recebe a referrência da tabela entidade

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }//construtor** Passo a clase MyContext para ele devolver o options, para injetar essa options na base

        protected override void OnModelCreating(ModelBuilder modelBuilder)//aplicar dados iniciais ao banco de dados como parte de sua migração
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
