using Microsoft.EntityFrameworkCore;
using Sorteios.DataBase;
using Sorteios.Interface;
using Sorteios.Models;

namespace Sorteios.Repository;

public class ParticipanteRepository : IParticipanteInterface
{
    private readonly Context _context;

    public ParticipanteRepository(Context context)
    {
        _context = context;
    }

    public async Task<List<ParticipanteModel>> GetParticipantes()
    {
        return await _context.Participantes.ToListAsync();
    }

    public async Task<ParticipanteModel> GetParticipante(int id)
    {
        return await _context.Participantes.FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task AddParticipante(ParticipanteModel participante)
    {
        await _context.Participantes.AddAsync(participante);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ParticipanteExiste(int id)
    {
        return await _context.Participantes.AnyAsync(p => p.Id == id);
    }

    public async Task RemoverParticipante(ParticipanteModel participante)
    {
        _context.Participantes.Remove(participante);
        await _context.SaveChangesAsync();
    }
}