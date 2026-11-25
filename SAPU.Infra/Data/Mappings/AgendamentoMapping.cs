using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAPU.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SAPU.Infra.Data.Mappings;

public class AgendamentoMapping:IEntityTypeConfiguration<Agendamento>
{
    public void Configure(EntityTypeBuilder<Agendamento> builder)
    {
        builder.HasKey(a => a.IdAgendamento);
        builder.HasOne(a => a.Professor)
            .WithMany(p => p.Agendamentos).HasForeignKey(a => a.IdProfessor).OnDelete(DeleteBehavior.Restrict);
    }
}
