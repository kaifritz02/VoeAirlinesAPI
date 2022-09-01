using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoeAirlines.Entities;

public class PilotoConfiguration : IEntityTypeConfiguration<Piloto>
{
    public void Configure(EntityTypeBuilder<Piloto> builder)
    {
        builder.ToTable("Pilotos");
        builder.HasKey(p=>p.Id);
        builder.Property(p=>p.Nome)
             .IsRequired()
             .HasMaxLength(100);
        builder.Property(p=>p.Matricula)
             .IsRequired()
             .HasMaxLength(10);
        builder.HasIndex(p=>p.Matricula)
             .IsUnique();
        
    }
}

/*

public class PilotoConfiguration : IEntityTypeConfiguration<Piloto>
{
        public void Configure(EntityTypeBuilder<Piloto> builder)
    {
        builder.ToTable("Pilotos");
        //chave primária
        builder.HasKey(a => a.Id);

        //outras propriedades:
        builder.Property(a => a.Nome)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(a => a.Matricula)
            .IsRequired()
            .HasMaxLength(10);
        builder.HasIndex(p => p.Matricula)
                  .IsUnique();



    }
}

*/