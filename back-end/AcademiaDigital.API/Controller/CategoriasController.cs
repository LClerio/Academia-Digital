using AcademiaDigital.Application.DTOs.CategoriaDTO;
using AcademiaDigital.Application.Interfaces;
using AcademiaDigital.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaDigital.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriasController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaDTO>>> Get()
        {
            var categoria = await _categoriaService.GetAllAsync();
            return Ok(categoria);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Categoria>> Get(int id)
        {
            var categoria = await _categoriaService.GetByIdAsync(id);

            if (categoria is null) return NotFound();

            return Ok(categoria);
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaDTO>> Post([FromBody] CategoriaCreateDTO dto)
        {
            var categoria = await _categoriaService.CreateAsync(dto);

            return CreatedAtAction(nameof(Get), new { id = categoria.CategoriaId }, categoria);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CategoriaUpdateDTO dto)
        {
            var update = await _categoriaService.UpdateAsync(id, dto);

            if (!update) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Categoria>> Delete(int id)
        {
            var delete = await _categoriaService.DeleteAsync(id);

            if (!delete) return NotFound();

            return NoContent();
        }


    }
}
