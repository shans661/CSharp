using DBAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBAccess.Configuration
{
    public class ToDoListEntityConfiguration : IEntityTypeConfiguration<ToDoListEntity>
    {
        public void Configure(EntityTypeBuilder<ToDoListEntity> builder)
        {
            builder.ToTable("ToDoListTable");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("ID").
                ValueGeneratedOnAdd();

            builder.Property(x => x.UserName)
                .IsRequired()
                .HasColumnName("UserName");

            builder.Property(x => x.CreationTime)
                .IsRequired()
                .HasColumnName("CreationTime");          

            builder.Property(x => x.Item)
                .IsRequired()
                .HasColumnName("Item");

        }
    }
}
