using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAPU.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPU.Infra.Data.Mappings;

public class RegistroMapping : IEntityTypeConfiguration<Registro>
{
    public void Configure(EntityTypeBuilder<Registro> builder)
    {
        builder.HasKey(a => a.IdRegistro);
        builder.HasOne(a => a.Professor)
            .WithMany(p => p.Registros).HasForeignKey(a => a.IdProfessor).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(a => a.Projetor)
            .WithMany(p => p.Registros).HasForeignKey(a => a.IdProjetor).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(a => a.Agendamento)
            .WithMany(p => p.Registros).HasForeignKey(a => a.IdAgendamento).OnDelete(DeleteBehavior.Restrict);
    }
}