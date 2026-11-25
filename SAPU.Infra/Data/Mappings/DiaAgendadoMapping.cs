using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAPU.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPU.Infra.Data.Mappings;

public class DiaAgendadoMapping : IEntityTypeConfiguration<DiaAgendado>
{
    public void Configure(EntityTypeBuilder<DiaAgendado> builder)
    {
        builder.HasKey(a => a.IdDiaAgendado);
        builder.HasOne(a => a.Agendamento)
            .WithMany(p => p.DiaAgendados).HasForeignKey(a => a.IdAgendamento).OnDelete(DeleteBehavior.Restrict);
    }
}
