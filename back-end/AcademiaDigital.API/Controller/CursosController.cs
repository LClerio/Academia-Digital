using AcademiaDigital.Application.DTOs.CursoDTO;
using AcademiaDigital.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaDigital.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursosController : ControllerBase
    {
        private readonly ICursoService _cursoService;

        public CursosController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursoDTO>>> Get()
        {
            var curso = await _cursoService.GetAllAsync();
            return Ok(curso);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CursoDTO>> Get(int id)
        {
            var curso = await _cursoService.GetByIdAsync(id);

            if (curso is null) return NotFound();

            return Ok(curso);
        }

        [HttpPost]
        public async Task<ActionResult<CursoDTO>> Post([FromBody] CursoCreateDTO dto)
        {
            var curso = await _cursoService.CreateAsync(dto);

            return CreatedAtAction(nameof(Get), new { id = curso.CursoId }, curso);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CursoUpdateDTO dto)
        {
            var update = await _cursoService.UpdateAsync(id, dto);

            if (!update) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var delete = await _cursoService.DeleteAsync(id);

            if (!delete) return NotFound();

            return NoContent();
        }
    }
}
