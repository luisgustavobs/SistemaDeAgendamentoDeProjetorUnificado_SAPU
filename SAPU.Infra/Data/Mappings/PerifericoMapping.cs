using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAPU.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPU.Infra.Data.Mappings;

public class PerifericoMapping : IEntityTypeConfiguration<Periferico>
{
    public void Configure(EntityTypeBuilder<Periferico> builder)
    {
        builder.HasKey(a => a.IdPeriferico);
    }
}