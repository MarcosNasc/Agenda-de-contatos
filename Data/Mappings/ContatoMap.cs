using Agenda.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agenda.Data.Mappings
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("Contato");
            builder.HasKey(it => it.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(it => it.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50);

            builder.Property(it => it.Email)
               .IsRequired()
               .HasColumnName("Email")
               .HasColumnType("NVARCHAR")
               .HasMaxLength(50);

            builder.Property(it => it.Telefone)
               .IsRequired()
               .HasColumnName("Telefone")
               .HasColumnType("NVARCHAR")
               .HasMaxLength(10);

            builder.Property(it => it.Whatsapp)
               .IsRequired()
               .HasColumnName("Whatsapp")
               .HasColumnType("NVARCHAR")
               .HasMaxLength(10);

            builder.Property(it => it.Whatsapp)
              .IsRequired()
              .HasColumnName("Whatsapp")
              .HasColumnType("NVARCHAR")
              .HasMaxLength(10);

            builder.Property(it => it.Telegram)
              .IsRequired()
              .HasColumnName("Telegram")
              .HasColumnType("NVARCHAR")
              .HasMaxLength(10);

            builder.Property(it => it.Status)
                .IsRequired()
                .HasColumnName("Ativo")
                .HasColumnType("BIT");
        }
    }
}
