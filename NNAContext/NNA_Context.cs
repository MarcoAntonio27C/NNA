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
        public DbSet<Estatus> Estatus { get; set; }
        public DbSet<Fiscalias> Fiscalias { get; set; }
        public DbSet<MP> MP { get; set; }
        public DbSet<Unidades> Unidades { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
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

            modelBuilder.Entity<Estatus>(entity =>
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
            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            // ROLES
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("73e08b06-a8c8-4960-9708-d77d4f938f0c"), Nombre = "ADMINISTRADOR", Descripcion = "ADMINISTRADOR DEL SISTEMA, TIENE ACCESO A TODO", Estatus = true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("49ecfee1-61f3-4e38-a28a-fe74c1bcb02c"), Nombre = "FISCALIA ESPECIALIZADA", Descripcion = "ENCARGADO DE VER Y ASIGNAR LAS DENUNCIAS RECIBIDAS", Estatus = true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("aec4592c-fe97-47d0-97d2-1933fd2da4b9"), Nombre = "TITULAR DE UNIDAD", Descripcion = "PUEDE VER TODAS LAS DENUNCIAS DE SUS AGENTES DEL MINISTERIO PUBLICO", Estatus = true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("6f1be536-c224-4f31-914e-c9d00cce1eb9"), Nombre = "AGENTE DEL MINISTERIO PUBLICO", Descripcion = "AGENTE DEL MINISTERIO PUBLICO", Estatus = true });

            //USUARIOS
            //usuario root -- root@fiscalia.puebla.gob.mx --------- pass:123456
            modelBuilder.Entity<Usuario>().HasData(new Usuario { Id = new Guid("1e28ad5c-8897-4f35-846e-beaede16b3b0"),Nombre="Administrador", Correo = "root@fiscalia.puebla.gob.mx", Contraseña = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", IdRol = new Guid("73e08b06-a8c8-4960-9708-d77d4f938f0c"), IdFiscalia = new Guid("f54fd0d9-be76-4c38-b7ed-edeb6f4c9939"),IdUnidad = new Guid("1d02eda0-a6b8-4c08-9888-e61db604ecf0"), Estatus = true });

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

            ////ESTATUS 
            modelBuilder.Entity<Estatus>().HasData(new Estatus { Id = 1, Nombre = "SIN ATENDER", Status = true });
            modelBuilder.Entity<Estatus>().HasData(new Estatus { Id = 2, Nombre = "ARCHIVO", Status = true });
            modelBuilder.Entity<Estatus>().HasData(new Estatus { Id = 3, Nombre = "EAT", Status = true });
            modelBuilder.Entity<Estatus>().HasData(new Estatus { Id = 4, Nombre = "CDI", Status = true });

            //// Municipios 
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 1, Nombre = "Acajete" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 2, Nombre = "Acateno" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 3, Nombre = "Acatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 4, Nombre = "Acatzingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 5, Nombre = "Acteopan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 6, Nombre = "Ahuacatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 7, Nombre = "Ahuatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 8, Nombre = "Ahuazotepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 9, Nombre = "Ahuehuetitla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 10, Nombre = "Ajalpan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 11, Nombre = "Albino Zertuche" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 12, Nombre = "Aljojuca" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 13, Nombre = "Altepexi" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 14, Nombre = "Amixtlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 15, Nombre = "Amozoc" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 16, Nombre = "Aquixtla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 17, Nombre = "Atempan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 18, Nombre = "Atexcal" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 19, Nombre = "Atlixco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 20, Nombre = "Atoyatempan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 21, Nombre = "Atzala" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 22, Nombre = "Atzitzihuacán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 23, Nombre = "Atzitzintla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 24, Nombre = "Axutla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 25, Nombre = "Ayotoxco de Guerrero" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 26, Nombre = "Calpan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 27, Nombre = "Caltepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 28, Nombre = "Camocuautla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 29, Nombre = "Caxhuacan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 30, Nombre = "Coatepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 31, Nombre = "Coatzingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 32, Nombre = "Cohetzala" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 33, Nombre = "Cohuecan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 34, Nombre = "Coronango" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 35, Nombre = "Coxcatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 36, Nombre = "Coyomeapan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 37, Nombre = "Coyotepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 38, Nombre = "Cuapiaxtla de Madero" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 39, Nombre = "Cuautempan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 40, Nombre = "Cuautinchán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 41, Nombre = "Cuautlancingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 42, Nombre = "Cuayuca de Andrade" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 43, Nombre = "Cuetzalan del Progreso" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 44, Nombre = "Cuyoaco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 45, Nombre = "Chalchicomula de Sesma" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 46, Nombre = "Chapulco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 47, Nombre = "Chiautla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 48, Nombre = "Chiautzingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 49, Nombre = "Chiconcuautla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 50, Nombre = "Chichiquila" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 51, Nombre = "Chietla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 52, Nombre = "Chigmecatitlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 53, Nombre = "Chignahuapan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 54, Nombre = "Chignautla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 55, Nombre = "Chila" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 56, Nombre = "Chila de la Sal" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 57, Nombre = "Honey" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 58, Nombre = "Chilchotla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 59, Nombre = "Chinantla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 60, Nombre = "Domingo Arenas" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 61, Nombre = "Eloxochitlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 62, Nombre = "Epatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 63, Nombre = "Esperanza" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 64, Nombre = "Francisco Z. Mena" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 65, Nombre = "General Felipe Ángeles" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 66, Nombre = "Guadalupe" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 67, Nombre = "Guadalupe Victoria" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 68, Nombre = "Hermenegildo Galeana" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 69, Nombre = "Huaquechula" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 70, Nombre = "Huatlatlauca" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 71, Nombre = "Huauchinango" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 72, Nombre = "Huehuetla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 73, Nombre = "Huehuetlán el Chico" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 74, Nombre = "Huejotzingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 75, Nombre = "Hueyapan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 76, Nombre = "Hueytamalco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 77, Nombre = "Hueytlalpan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 78, Nombre = "Huitzilan de Serdán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 79, Nombre = "Huitziltepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 80, Nombre = "Atlequizayan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 81, Nombre = "Ixcamilpa de Guerrero" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 82, Nombre = "Ixcaquixtla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 83, Nombre = "Ixtacamaxtitlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 84, Nombre = "Ixtepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 85, Nombre = "Izúcar de Matamoros" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 86, Nombre = "Jalpan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 87, Nombre = "Jolalpan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 88, Nombre = "Jonotla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 89, Nombre = "Jopala" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 90, Nombre = "Juan C. Bonilla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 91, Nombre = "Juan Galindo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 92, Nombre = "Juan N. Méndez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 93, Nombre = "Lafragua" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 94, Nombre = "Libres" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 95, Nombre = "La Magdalena Tlatlauquitepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 96, Nombre = "Mazapiltepec de Juárez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 97, Nombre = "Mixtla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 98, Nombre = "Molcaxac" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 99, Nombre = "Cañada Morelos" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 100, Nombre = "Naupan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 101, Nombre = "Nauzontla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 102, Nombre = "Nealtican" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 103, Nombre = "Nicolás Bravo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 104, Nombre = "Nopalucan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 105, Nombre = "Ocotepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 106, Nombre = "Ocoyucan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 107, Nombre = "Olintla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 108, Nombre = "Oriental" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 109, Nombre = "Pahuatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 110, Nombre = "Palmar de Bravo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 111, Nombre = "Pantepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 112, Nombre = "Petlalcingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 113, Nombre = "Piaxtla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 114, Nombre = "Puebla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 115, Nombre = "Quecholac" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 116, Nombre = "Quimixtlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 117, Nombre = "Rafael Lara Grajales" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 118, Nombre = "Los Reyes de Juárez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 119, Nombre = "San Andrés Cholula" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 120, Nombre = "San Antonio Cañada" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 121, Nombre = "San Diego la Mesa Tochimiltzingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 122, Nombre = "San Felipe Teotlalcingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 123, Nombre = "San Felipe Tepatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 124, Nombre = "San Gabriel Chilac" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 125, Nombre = "San Gregorio Atzompa" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 126, Nombre = "San Jerónimo Tecuanipan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 127, Nombre = "San Jerónimo Xayacatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 128, Nombre = "San José Chiapa" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 129, Nombre = "San José Miahuatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 130, Nombre = "San Juan Atenco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 131, Nombre = "San Juan Atzompa" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 132, Nombre = "San Martín Texmelucan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 133, Nombre = "San Martín Totoltepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 134, Nombre = "San Matías Tlalancaleca" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 135, Nombre = "San Miguel Ixitlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 136, Nombre = "San Miguel Xoxtla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 137, Nombre = "San Nicolás Buenos Aires" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 138, Nombre = "San Nicolás de los Ranchos" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 139, Nombre = "San Pablo Anicano" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 140, Nombre = "San Pedro Cholula" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 141, Nombre = "San Pedro Yeloixtlahuaca" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 142, Nombre = "San Salvador el Seco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 143, Nombre = "San Salvador el Verde" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 144, Nombre = "San Salvador Huixcolotla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 145, Nombre = "San Sebastián Tlacotepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 146, Nombre = "Santa Catarina Tlaltempan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 147, Nombre = "Santa Inés Ahuatempan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 148, Nombre = "Santa Isabel Cholula" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 149, Nombre = "Santiago Miahuatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 150, Nombre = "Huehuetlán el Grande" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 151, Nombre = "Santo Tomás Hueyotlipan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 152, Nombre = "Soltepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 153, Nombre = "Tecali de Herrera" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 154, Nombre = "Tecamachalco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 155, Nombre = "Tecomatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 156, Nombre = "Tehuacán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 157, Nombre = "Tehuitzingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 158, Nombre = "Tenampulco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 159, Nombre = "Teopantlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 160, Nombre = "Teotlalco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 161, Nombre = "Tepanco de López" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 162, Nombre = "Tepango de Rodríguez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 163, Nombre = "Tepatlaxco de Hidalgo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 164, Nombre = "Tepeaca" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 165, Nombre = "Tepemaxalco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 166, Nombre = "Tepeojuma" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 167, Nombre = "Tepetzintla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 168, Nombre = "Tepexco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 169, Nombre = "Tepexi de Rodríguez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 170, Nombre = "Tepeyahualco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 171, Nombre = "Tepeyahualco de Cuauhtémoc" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 172, Nombre = "Tetela de Ocampo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 173, Nombre = "Teteles de Ávila Castillo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 174, Nombre = "Teziutlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 175, Nombre = "Tianguismanalco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 176, Nombre = "Tilapa" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 177, Nombre = "Tlacotepec de Benito Juárez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 178, Nombre = "Tlacuilotepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 179, Nombre = "Tlachichuca" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 180, Nombre = "Tlahuapan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 181, Nombre = "Tlaltenango" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 182, Nombre = "Tlanepantla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 183, Nombre = "Tlaola" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 184, Nombre = "Tlapacoya" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 185, Nombre = "Tlapanalá" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 186, Nombre = "Tlatlauquitepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 187, Nombre = "Tlaxco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 188, Nombre = "Tochimilco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 189, Nombre = "Tochtepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 190, Nombre = "Totoltepec de Guerrero" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 191, Nombre = "Tulcingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 192, Nombre = "Tuzamapan de Galeana" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 193, Nombre = "Tzicatlacoyan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 194, Nombre = "Venustiano Carranza" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 195, Nombre = "Vicente Guerrero" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 196, Nombre = "Xayacatlán de Bravo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 197, Nombre = "Xicotepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 198, Nombre = "Xicotlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 199, Nombre = "Xiutetelco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 200, Nombre = "Xochiapulco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 201, Nombre = "Xochiltepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 202, Nombre = "Xochitlán de Vicente Suárez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 203, Nombre = "Xochitlán Todos Santos" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 204, Nombre = "Yaonáhuac" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 205, Nombre = "Yehualtepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 206, Nombre = "Zacapala" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 207, Nombre = "Zacapoaxtla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 208, Nombre = "Zacatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 209, Nombre = "Zapotitlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 210, Nombre = "Zapotitlán de Méndez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 211, Nombre = "Zaragoza" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 212, Nombre = "Zautla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 213, Nombre = "Zihuateutla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 214, Nombre = "Zinacatepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 215, Nombre = "Zongozotla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 216, Nombre = "Zoquiapan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = 217, Nombre = "Zoquitlán" });

        }
    }
}
