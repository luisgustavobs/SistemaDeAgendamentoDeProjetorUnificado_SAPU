using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAPU.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPU.Infra.Data.Mappings;

public class ProjetorMapping : IEntityTypeConfiguration<Projetor>
{
    public void Configure(EntityTypeBuilder<Projetor> builder)
    {
        builder.HasKey(a => a.IdProjetor);
   
    }
}
