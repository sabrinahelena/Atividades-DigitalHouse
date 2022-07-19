using Microsoft.EntityFrameworkCore;

namespace aula30_EntityRelacionamento.Models
{
    public class EscolaContext : DbContext
    {
        //Criação banco de dados
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        { }

        //Definição das tabelas que quero adiiconar o banco
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Aluno> Alunos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instituicao>()
                .ToTable("Instituições")
                .HasKey(t => t.Id);
                 

            modelBuilder.Entity<Aluno>()
               .ToTable("Alunos")
               .HasKey(t => t.Id);

            modelBuilder.Entity<Instituicao>()
                .HasMany(t => t.Alunos);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder Config)
        {
            String Credencial = @"";
            Config.UseSqlServer(Credencial);
        }
        public DbSet<aula30_EntityRelacionamento.Models.Aluno>? Aluno { get; set; }

    }
}
