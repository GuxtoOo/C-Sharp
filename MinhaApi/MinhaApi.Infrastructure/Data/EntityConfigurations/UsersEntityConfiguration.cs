using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhaApi.Domain.AggregatesModel;

namespace MinhaApi.Infrastructure.Data.EntityConfigurations
{
    public class UsersEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("TB_USERS");

            builder.Property(s => s.Id)
                .ValueGeneratedOnAdd()
            .HasColumnName("USU_ID_USER");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .HasColumnName("USU_TX_NAME")
                .HasColumnType("varchar")
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(s => s.Document)
                .HasColumnName("USU_TX_DOCUMENT")
                .HasColumnType("varchar")
                .HasMaxLength(18)
                .IsRequired();

        }
    }
}
