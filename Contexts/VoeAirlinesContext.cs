using Microsoft.EntityFrameworkCore;
using VoeAirlines.Entities;
using VoeAirlines.EntityConfigurations;

namespace VoeAirlines.Contexts;

public class VoeAirlinesContext:DbContext{

    private readonly IConfiguration _configuration;

    public VoeAirlinesContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Aeronave> Aeronaves =>Set<Aeronave>();   
    public DbSet<Piloto> Pilotos =>Set<Piloto>();
    public DbSet<Voo> Voos =>Set<Voo>();
    public DbSet<Cancelamento> Cancelamentos =>Set<Cancelamento>();
    public DbSet<Manutencao> Manutencoes =>Set<Manutencao>();

    //Encapsulamento
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
          optionsBuilder.UseSqlServer(_configuration.GetConnectionString("VoeAirlines"));
    } 

   protected override void OnModelCreating(ModelBuilder modelBuilder){
         
         modelBuilder.ApplyConfiguration(new AeronaveConfiguration());
         modelBuilder.ApplyConfiguration(new PilotoConfiguration());
         modelBuilder.ApplyConfiguration(new VooConfiguration());
         modelBuilder.ApplyConfiguration(new CancelamentoConfiguration());
         modelBuilder.ApplyConfiguration(new ManutencaoConfiguration());

    }



/*
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder ){
        //nesse método definimos a string de conexão
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("VoeAirlines"));

     }
*/
}