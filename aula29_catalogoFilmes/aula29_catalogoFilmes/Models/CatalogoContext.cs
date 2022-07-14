using Microsoft.EntityFrameworkCore;


namespace aula29_catalogoFilmes.Models
{
    public class CatalogoContext : DbContext
    {
       
            public CatalogoContext(DbContextOptions<CatalogoContext> options) : base(options)
            { }

            public DbSet<FilmeModel> Filmes { get; set; }
            public DbSet<AtorModel> Atores { get; set; }
        

    }
}
