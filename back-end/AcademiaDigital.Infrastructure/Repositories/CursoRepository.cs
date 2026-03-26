using AcademiaDigital.Domain.Entities;
using AcademiaDigital.Domain.Interfaces;
using AcademiaDigital.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace AcademiaDigital.Infrastructure.Repositories;

public class CursoRepository : ICursoRepository
{
    private readonly AppDbContext _context;

    public CursoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Curso>> GetAllAsync()
    {
        return await _context.Cursos.AsNoTracking().ToListAsync();
    }

    public async Task<Curso?> GetAsync(int id)
    {
        return await _context.Cursos.FindAsync(id);

    }
    public async Task CreateAsync(Curso curso)
    {
        _context.Cursos.Add(curso);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(Curso curso)
    {
        _context.Entry(curso).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var curso = await _context.Cursos.FindAsync(id);
        if (curso is null) return;

        _context.Cursos.Remove(curso);
        await _context.SaveChangesAsync();
    }
}
