using GerenciadorLivro.API.Database;
using GerenciadorLivro.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorLivro.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository _bookRepository;

        public BooksController(IBooksRepository repository)
        {
            _bookRepository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_bookRepository.GetAll());
        }

        [HttpPost]
        public IActionResult Post(BookEntity book)
        {
            _bookRepository.Insert(book);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookRepository.Delete(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult Put(BookEntity book)
        {
            return Ok(_bookRepository.Update(book));
             
        }
    }
}