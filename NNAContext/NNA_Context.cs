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
        public DbSet<Fiscalias> Fiscalias { get; set; }
        public DbSet<MP> MP { get; set; }
        public DbSet<Unidades> Unidades { get; set; }
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

            modelBuilder.Entity<Fiscalias>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<MP>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Unidades>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            // ROLES
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("73e08b06-a8c8-4960-9708-d77d4f938f0c"), Nombre = "ADMINISTRADOR", Descripcion = "ADMINISTRADOR DEL SISTEMA, TIENE ACCESO A TODO", Estatus = true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("49ecfee1-61f3-4e38-a28a-fe74c1bcb02c"), Nombre = "FISCALIA ESPECIALIZADA", Descripcion = "ENCARGADO DE VER Y ASIGNAR LAS DENUNCIAS RECIBIDAS", Estatus = true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("aec4592c-fe97-47d0-97d2-1933fd2da4b9"), Nombre = "TITULAR DE UNIDAD", Descripcion = "PUEDE VER TODAS LAS DENUNCIAS DE SUS AGENTES DEL MINISTERIO PUBLICO", Estatus = true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("6f1be536-c224-4f31-914e-c9d00cce1eb9"), Nombre = "AGENTE DEL MINISTERIO PUBLICO", Descripcion = "AGENTE DEL MINISTERIO PUBLICO", Estatus = true });

            //USUARIOS
            modelBuilder.Entity<Usuario>().HasData(new Usuario { Id = new Guid("1e28ad5c-8897-4f35-846e-beaede16b3b0"),Nombre="Administrador", Correo = "root@fiscalia.puebla.gob.mx", Contraseña = "123qwe", IdRol = new Guid("73e08b06-a8c8-4960-9708-d77d4f938f0c"), IdFiscalia = new Guid("f54fd0d9-be76-4c38-b7ed-edeb6f4c9939"),IdUnidad = new Guid("1d02eda0-a6b8-4c08-9888-e61db604ecf0"), Estatus = true });

            //CASO
            modelBuilder.Entity<Caso>().HasData(new Caso { Id = 1, Nombre = "Niños y Niñas" });
            modelBuilder.Entity<Caso>().HasData(new Caso { Id = 2, Nombre = "Adolescentes" });

            //FISCALIA
            modelBuilder.Entity<Fiscalias>().HasData(new Fiscalias { Id = new Guid("f54fd0d9-be76-4c38-b7ed-edeb6f4c9939"), Nombre = " NONE", Acronimo = "NONE",Estatus = true });
            modelBuilder.Entity<Fiscalias>().HasData(new Fiscalias { Id = new Guid("30df8b24-2f67-49c1-922d-0b1fb219aef9"), Nombre = "Fiscalía Especializada en Investigación de Delitos de Violencia de Género Contra las Mujeres", Acronimo = "FEIDVGM", Estatus = true });

            //UNIDADES
            modelBuilder.Entity<Unidades>().HasData(new Unidades { Id = new Guid("1d02eda0-a6b8-4c08-9888-e61db604ecf0"), Nombre = " NONE",  Estatus = true, IdFiscalia = new Guid("f54fd0d9-be76-4c38-b7ed-edeb6f4c9939") });
            modelBuilder.Entity<Unidades>().HasData(new Unidades { Id = new Guid("e13f9fdb-f883-4a0f-b1d5-66ce02249944"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS SEXUALES Y CIBERACOSO",  Estatus = true, IdFiscalia = new Guid("30df8b24-2f67-49c1-922d-0b1fb219aef9") });


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
