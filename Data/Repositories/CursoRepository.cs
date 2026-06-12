using Microsoft.EntityFrameworkCore;
using LP3.BlazorServer.Domain.Entities;

namespace LP3.BlazorServer.Data.Repositories;

public class CursoRepository(ApplicationDbContext context) : Repository<Curso>(context), ICursoRepository
{
    public async Task<Curso?> GetByCodigoAsync(string codigo)
    {
        return await context.Cursos
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Codigo == codigo);
    }
}