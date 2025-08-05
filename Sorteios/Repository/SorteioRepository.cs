using Microsoft.EntityFrameworkCore;
using Sorteios.DataBase;
using Sorteios.Interface;
using Sorteios.Models;

namespace Sorteios.Repository;

public class SorteioRepository : ISorteioInterface
{
    private readonly Context _context;

    public SorteioRepository(Context context)
    {
        _context = context;
    }

    public async Task CriarSorteio(SorteioModel sorteio)
    {
        _context.Sorteios.Add(sorteio);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> SorteioExiste(int id)
    {
        return await _context.Sorteios.AnyAsync(s => s.Id == id);
    }

    public async Task FinalizarSorteio(SorteioModel sorteio)
    {
        _context.Sorteios.Remove(sorteio);
        await _context.SaveChangesAsync();
    }
}