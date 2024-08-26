﻿using Hiffy_Entidades.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiffy_Datos.Mapping
{
    public class LogActividadMap : IEntityTypeConfiguration<LogActividad>
    {
        public void Configure(EntityTypeBuilder<LogActividad> builder)
        {
            builder.ToTable("LogActividad")
                .HasKey(x => x.IdLogActividad);
        }
    }
}
