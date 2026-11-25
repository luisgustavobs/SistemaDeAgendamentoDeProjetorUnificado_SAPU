using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAPU.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPU.Infra.Data.Mappings;

public class RegistroPerifericoMapping : IEntityTypeConfiguration<RegistroPeriferico>
{
    public void Configure(EntityTypeBuilder<RegistroPeriferico> builder)
    {
        builder.HasKey(a => a.IdRegistroPeriferico);
        builder.HasOne(a => a.Periferico)
            .WithMany(p => p.RegistroPerifericos).HasForeignKey(a => a.IdPeriferico);
        builder.HasOne(a => a.Registro)
            .WithMany(p => p.RegistroPerifericos).HasForeignKey(a => a.IdRegistro);
    }
}
