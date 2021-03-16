using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contextos
{
    public class ProEventosContext : DbContext
    {
        public ProEventosContext(DbContextOptions<ProEventosContext> options) 
            : base(options) { }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<PalestranteEvento> PalestrantesEventos { get; set; }
        public DbSet<RedeSocial> RedesSociais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PalestranteEvento>()
                .HasKey(PE => new {PE.EventoId, PE.PalestranteId});

            modelBuilder.Entity<Evento>()
                .HasMany(e => e.RedesSociais)
                .WithOne(rs => rs.Evento)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Palestrante>()
                .HasMany(e => e.RedesSociais)
                .WithOne(rs => rs.Palestrante)
                .OnDelete(DeleteBehavior.Cascade);

                 modelBuilder.Entity<Palestrante>()
                .HasData(new List<Palestrante>(){
                    new Palestrante(1, "Lauro", "minicurriculoUrl","www.localhost.com","33231316","lauro@hotmail.com" ),
                    new Palestrante(2, "Ana", "minicurriculoUrl","www.localhost.com","33231316","lauro@hotmail.com" ),
                    new Palestrante(3, "Maria", "minicurriculoUrl","www.localhost.com","33231316","lauro@hotmail.com" ),
                    new Palestrante(4, "Bianca", "minicurriculoUrl","www.localhost.com","33231316","lauro@hotmail.com" ),
                    
                });

                modelBuilder.Entity<RedeSocial>()
                .HasData(new List<RedeSocial>(){
                    new RedeSocial(1, "Instagram", "instagram.com")
                });

                 modelBuilder.Entity<Lote>()
                .HasData(new List<Lote>(){
                    new Lote(1, "LOTE WEG3", 73.39M, 100, 1 ),
                    new Lote(2, "LOTE 2", 73.39M, 100, 2 ),
                    new Lote(3, "LOTE 3", 73.39M, 100, 3 )
                });

                 modelBuilder.Entity<Evento>()
                .HasData(new List<Evento>(){
                    new Evento(1,"Evento WEG3", "Ações", 1000, "foto.png", "99999", "teste@123.com.br"),
                    new Evento(2,"Evento CSNA3", "Ações", 1000, "foto2.png", "33333", "teste@123.com.br"),
                    new Evento(3,"Evento VALE3", "Ações", 1000, "foto3.png", "22222", "teste@123.com.br")
                    
                });

        }



    }
}