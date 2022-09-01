using VoeAirlines.Contexts;
using VoeAirlines.Entities;
using VoeAirlines.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class ManutencaoConfiguration : IEntityTypeConfiguration<Manutencao>
{
    public void Configure(EntityTypeBuilder<Manutencao> builder)
    {
        //Tabela?
        builder.ToTable("Manutencao");

        //Chave primária
        builder.HasKey(m=>m.Id);

        //Propriedade DataHora
        builder.Property(m=>m.DataHora)
             .IsRequired();
        //Propriedade Tipo
        builder.Property(m=>m.TipoManutencao)
              .IsRequired();
        builder.Property(m=>m.Observacao)
              .HasMaxLength(100);      

    } 
}
    
