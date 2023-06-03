using Domain.Entities;
using Domain.Enums;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            //Mapping Columns/Properties

            builder.HasKey(p => p.Id);

            builder.Property<int>("Id")
                .HasColumnType("INT")
                .ValueGeneratedOnAdd();

            builder.Property<string>("Name")
                .HasColumnType("VARCHAR(150)")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property<string>("Email")
                .HasColumnType("VARCHAR(80)")
                .HasMaxLength(80)
                .IsRequired();

            builder.Property<string>("EnrollNumber")
                .HasColumnType("CHAR(10)")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property<string>("CardId")
                .HasColumnType("VARCHAR(50)")
                .HasMaxLength(50);

            builder.Property<string>("Password")
                .HasColumnType("VARCHAR(8)")
                .HasMaxLength(8)
                .IsRequired();

            builder.Property<string>("Phone")
                .HasColumnType("CHAR(11)")
                .HasMaxLength(11)
                .IsRequired();

            builder.Property<string>("IsActive")
                .HasColumnType("BOOL")
                .IsRequired();

            builder.Property<string>("IsFump")
                .HasColumnType("BOOL")
                .IsRequired();

            builder.Property<Fump>("Fump")
                .HasConversion<int>();


            // Table Name
            builder.ToTable("User");
        }
    }
}
