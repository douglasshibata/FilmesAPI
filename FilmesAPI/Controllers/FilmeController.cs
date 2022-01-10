using FilmesAPI.Data;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private FilmeContext _context;

        public FilmeController(FilmeContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult adicionarFilme([FromBody] Filme filme)
        {
            _context.filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetFilmeById), new { Id = filme.Id }, filme);
        }

        [HttpGet]
        public IEnumerable<Filme> getFilmes()
        {
            return _context.filmes;
        }

        [HttpGet("{id}")]
        public IActionResult GetFilmeById(int id)
        {
            Filme filme = _context.filmes.FirstOrDefault(filmes => filmes.Id == id);
            if(filme != null)
            {
                return Ok(filme);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFilme(int id,[FromBody] Filme filmeNovo)
        {
            Filme filme = _context.filmes.FirstOrDefault(filmes => filmes.Id == id);
            if (filme == null)
            {
                return NotFound();
            }


            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult DeletaFilme(int id)
        {
            Filme filme = _context.filmes.FirstOrDefault(filmes => filmes.Id == id);
            if (filme == null)
            {
                return NotFound();
            }
            _context.Remove(filme);
            _context.SaveChanges();

            return NoContent();

        }
    }
}
