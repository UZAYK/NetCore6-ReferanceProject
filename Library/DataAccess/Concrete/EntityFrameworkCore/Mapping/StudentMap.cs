﻿using KUSYS_Demo.Entities;
using KUSYS_Demo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KUSYS_Demo.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.FirstName).HasMaxLength(250);
            builder.Property(I => I.LastName).HasMaxLength(250);
        }
    }
}
