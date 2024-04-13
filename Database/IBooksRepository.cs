using GerenciadorLivro.API.Models;

namespace GerenciadorLivro.API.Database
{
    public interface IBooksRepository
    {
        public string Insert(BookEntity book);
        public bool Update(BookEntity book);
        public IList<BookEntity> GetAll();

        public bool Delete(int id);

    }
}