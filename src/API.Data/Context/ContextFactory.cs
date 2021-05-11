using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design; //pacote que instalou no nugget de design se usa aqui

namespace API.Data.Context
{//serve parra criar banco de dados, tabelas
 //prover uma conexão com o banco de dados para que possamos criar em tempo de idesign as tabelas necessárias
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>//cliquei para usar interface
    {
        public MyContext CreateDbContext(string[] args)//interface criada automaticamente
        {
            //colocar as configurações
            //usado para criar migrações
            var connectionString = "Server=localhost;Port3306;Database=dbAPI;Uid=root;Pwd=julia24MAISA";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();//use entity framework core
            optionBuilder.UseMySql(connectionString);
            return new MyContext(optionBuilder.Options);

        }
    }

}
