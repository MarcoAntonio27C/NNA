using Microsoft.EntityFrameworkCore;
using Modelos;
using Modelos.Acceso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNAContext
{
    public class NNA_Context :DbContext
    {
        public NNA_Context(DbContextOptions options) : base(options) { }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Actions> Action { get; set; }
        public DbSet<Caso> Caso { get; set; }
        public DbSet<Denuncia> Denuncia { get; set; }
        public DbSet<Emotion> Emotion { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Actions>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Caso>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Denuncia>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Folio).Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            });

            modelBuilder.Entity<Emotion>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            // ROLES
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("49ecfee1-61f3-4e38-a28a-fe74c1bcb02c"), Nombre = "ASESOR", Descripcion = "ENCARGADO DE ASIGNAR LAS DENUNCIAS RECIBIDAS", Estatus = true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("6f1be536-c224-4f31-914e-c9d00cce1eb9"), Nombre = "MP", Descripcion = "AGENTE DEL MINISTERIO PUBLICO", Estatus = true });

            //USUARIOS
            modelBuilder.Entity<Usuario>().HasData(new Usuario { Id = new Guid("542ac5f1-da0f-4454-9700-defa2d131b9d"), Correo = "marco_antonio.cantero@fiscalia.puebla.gob.mx", Contraseña = "123qwe", IdRol = new Guid("49ecfee1-61f3-4e38-a28a-fe74c1bcb02c"), Estatus = true });

            //CASO
            modelBuilder.Entity<Caso>().HasData(new Caso { Id = 1, Nombre = "Niños y Niñas" });
            modelBuilder.Entity<Caso>().HasData(new Caso { Id = 2, Nombre = "Adolescentes" });

            //EMOCIONES 
            modelBuilder.Entity<Emotion>().HasData(new Emotion { Id = 1, Nombre = "BIEN" });
            modelBuilder.Entity<Emotion>().HasData(new Emotion { Id = 2, Nombre = "MAL" });
            modelBuilder.Entity<Emotion>().HasData(new Emotion { Id = 3, Nombre = "ENOJADO" });
            modelBuilder.Entity<Emotion>().HasData(new Emotion { Id = 4, Nombre = "TRISTE" });
            modelBuilder.Entity<Emotion>().HasData(new Emotion { Id = 5, Nombre = "PREOCUPADO" });

            //ACTIONS
            modelBuilder.Entity<Actions>().HasData(new Actions { Id = 1, Descripcion = "Alguien me pegó y me lastimó" });
            modelBuilder.Entity<Actions>().HasData(new Actions { Id = 2, Descripcion = "Alguien me tocó o me hizo tocar su cuerpo" });
            modelBuilder.Entity<Actions>().HasData(new Actions { Id = 3, Descripcion = "Alguien me grita o me dice cosas malas" });
            modelBuilder.Entity<Actions>().HasData(new Actions { Id = 4, Descripcion = "Alguien me manda a trabajar" });
        }
    }
}
