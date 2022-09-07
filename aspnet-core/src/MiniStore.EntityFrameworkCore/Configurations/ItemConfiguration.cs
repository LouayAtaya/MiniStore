using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniStore.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.Configurations
{
    public  class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable(MiniStoreConsts.DbTablePrefix + "Items");

            builder.Property(i => i.Code)
                .IsRequired()
                .HasMaxLength(5);

            builder.HasIndex(i => i.Code).IsUnique();

            builder.Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(i => i.Name).IsUnique();

            builder.Property(i => i.Description)
                .HasMaxLength(500);


            builder.Property(i => i.TotalQuantity)
                .HasDefaultValue(0);

            

            builder.Property(i => i.Price)
                .HasDefaultValue(0);

            builder.Property(i => i.Type)
                .IsRequired();

         
        }
    }
}
