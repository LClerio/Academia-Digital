namespace AcademiaDigital.Infrastructure.Repositories;

using AcademiaDigital.Domain.Entities;
using AcademiaDigital.Domain.Interfaces;
using AcademiaDigital.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly AppDbContext _context;

    public CategoriaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Categoria>> GetAllAsync()
    {
        return await _context.Categorias.AsNoTracking().ToListAsync();
    }

    public async Task<Categoria?> GetAsync(int id)
    {
        return await _context.Categorias.FindAsync(id);
    }

    public async Task CreateAsync(Categoria categoria)
    {
        _context.Categorias.Add(categoria);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Categoria categoria)
    {
        _context.Entry(categoria).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var categoria = await _context.Categorias.FindAsync(id);
        if (categoria is null) return;

        _context.Categorias.Remove(categoria);
        await _context.SaveChangesAsync();

    }
}
