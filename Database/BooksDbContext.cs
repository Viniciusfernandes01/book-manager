using GerenciadorLivro.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorLivro.API.Database
{
    public class BooksDbContext : DbContext
    {
        public BooksDbContext(DbContextOptions<BooksDbContext> options): base(options)
        {
        }

        public DbSet<BookEntity> Book {get; set;}
    }
}