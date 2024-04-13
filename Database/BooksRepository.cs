using GerenciadorLivro.API.Models;

namespace GerenciadorLivro.API.Database
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BooksDbContext _dbContext;

        public BooksRepository(BooksDbContext booksDbContext)
        {
            _dbContext = booksDbContext;
        }

        public bool Delete(int id)
        {
            _dbContext.Remove(_dbContext.Book.Single(x => x.Id == id));
            _dbContext.SaveChanges();
            return true;
        }

        public IList<BookEntity> GetAll()
        {
            return _dbContext.Book.ToList();
        }

        public string Insert(BookEntity book)
        {
            _dbContext.Add(book);
            _dbContext.SaveChanges();
            return book.Title;
        }

        public bool Update(BookEntity book)
        {
            _dbContext.Update(book);
            _dbContext.SaveChanges();
            return true;
        }
    }
}