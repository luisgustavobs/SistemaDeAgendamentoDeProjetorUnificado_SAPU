

using Microsoft.EntityFrameworkCore;
using SAPU.Domain;

namespace SAPU.Infra.Data;

public class SAPUDbContext: DbContext
{
    public DbSet<Agendamento> Agendamentos { get; set; }
    public DbSet<DiaAgendado> DiaAgendados { get; set; }
    public DbSet<Periferico> Perifericos { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public DbSet<Projetor> Projetores { get; set; }
    public DbSet<Registro> Registros { get; set; }
    public DbSet<RegistroPeriferico> RegistrosPerifericos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBilder)
    {
        base.OnModelCreating(modelBilder);
        modelBilder.ApplyConfigurationsFromAssembly(typeof(SAPUDbContext).Assembly);
    }

    private SAPUDbContext(DbContextOptions<SAPUDbContext> options): base(options)
    {

    }

}
