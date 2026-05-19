using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sensores.Domain.Entities;
using Sensores.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Sensores.Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<AppIdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<LecturaAire>().HasKey(c => c.Id);
            builder.Entity<LecturaAire>()
                .HasOne(d => d.Sensor)
                  .WithMany(p => p.Lecturas)
                  .HasForeignKey(d => d.SensorId)
                  .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<AlertaAire>().HasKey(e => e.Id);
            builder.Entity<AlertaAire>()
                .HasOne(d => d.Sensor)
                .WithMany(p => p.Alertas)
                .HasForeignKey(d => d.SensorId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<SensorCalidadAire> SensoresCalidadAire { get; set; }

        public DbSet<LecturaAire> LecturasAire { get; set; }

        public DbSet<AlertaAire> AlertasAire { get; set; }
    }
}
