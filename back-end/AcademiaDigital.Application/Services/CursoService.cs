using AcademiaDigital.Application.DTOs.CursoDTO;
using AcademiaDigital.Application.Interfaces;
using AcademiaDigital.Application.Mappings;
using AcademiaDigital.Domain.Interfaces;

namespace AcademiaDigital.Application.Services;

public class CursoService : ICursoService
{
    private readonly ICursoRepository _cursoRepository;
    private readonly ICategoriaRepository _categoriaRepository;

    public CursoService(ICursoRepository cursoRepository, ICategoriaRepository categoriaRepository)
    {
        _cursoRepository = cursoRepository;
        _categoriaRepository = categoriaRepository;
    }

    public async Task<IEnumerable<CursoDTO>> GetAllAsync()
    {
        var cursos = await _cursoRepository.GetAllAsync();

        return cursos.ToCursoDTOList();
    }

    public async Task<CursoDTO?> GetByIdAsync(int id)
    {
        var curso = await _cursoRepository.GetAsync(id);

        if (curso is null) return null;

        return curso.ToCursoDTO();
    }

    public async Task<CursoDTO> CreateAsync(CursoCreateDTO dto)
    {
        var categoria = await _categoriaRepository.GetAsync(dto.CategoriaId);

        if (categoria is null)
            throw new Exception($"Categoria with id {dto.CategoriaId} not found.");

        var curso = dto.ToCurso();

        await _cursoRepository.CreateAsync(curso);

        return curso.ToCursoDTO();
    }

    public async Task<bool> UpdateAsync(int id, CursoUpdateDTO dto)
    {
        var curso = await _cursoRepository.GetAsync(id);
        if (curso is null) return false;

        var categoria = await _categoriaRepository.GetAsync(dto.CategoriaId);

        if (categoria is null)
            throw new Exception($"Categoria with id {dto.CategoriaId} not found.");

        curso.UpdateCurso(dto);

        await _cursoRepository.UpdateAsync(curso);

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var curso = await _cursoRepository.GetAsync(id);

        if (curso is null) return false;

        await _cursoRepository.DeleteAsync(curso.CursoId);

        return true;
    }
}
