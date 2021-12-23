using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace blazorteste
{
    public partial class djangoProjectTesteDatabaseContext : DbContext
    {
        public djangoProjectTesteDatabaseContext()
        {
        }

        public djangoProjectTesteDatabaseContext(DbContextOptions<djangoProjectTesteDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pessoas> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;uid=usuario;pwd=senha;database=ProjectTesteDatabase", x => x.ServerVersion("10.5.12-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoas>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HorarioConsulta)
                    .HasColumnName("horario_consulta")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idade)
                    .HasColumnName("idade")
                    .HasColumnType("int(3)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Sobrenome)
                    .HasColumnName("sobrenome")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TipoConsulta)
                    .IsRequired()
                    .HasColumnName("tipo_consulta")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
