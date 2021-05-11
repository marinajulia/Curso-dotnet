using API.Domain.Entities; //os dois configurados no IEntityTypeConfiguration<UserEntity>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Mapping
{//fazer mapeamento antes dela ser criada o banco de dados
    public class UserMap : IEntityTypeConfiguration<UserEntity>//implementar interface
    {
        //interface
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            //para configurar o nome da tabela
            builder.ToTable("User");
            //para defininir uma chave primária
            builder.HasKey(p => p.Id);
            //para criar um index--unique = é único
            builder.HasIndex(p => p.Email).IsUnique();
            //passando obrigatoriedades para algum campo -- IsRequired= é obrigatório
            builder.Property(u => u.Name).IsRequired().HasMaxLength(60);
            builder.Property(u => u.Email).HasMaxLength(100);
        }
    }

}
