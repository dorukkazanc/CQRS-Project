﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");

            builder.Property(b => b.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(b => b.Name)
                .HasColumnName("Name")
                .IsRequired();

            builder.Property(b => b.CreatedDate)
                .HasColumnName("CreatedAt")
                .IsRequired();

            builder.Property(b => b.UpdatedDate)
                .HasColumnName("UpdatedAt");

            builder.Property(b => b.DeletedDate)
                .HasColumnName("DeletedAt");

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
