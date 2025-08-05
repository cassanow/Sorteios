using Sorteios.Models;

namespace Sorteios.Interface;

public interface IParticipanteInterface
{
    Task<List<ParticipanteModel>> GetParticipantes();
    
    Task<ParticipanteModel> GetParticipante(int id);
    
    Task AddParticipante(ParticipanteModel participante);
    
    Task <bool> ParticipanteExiste(int id);
    
    Task RemoverParticipante(ParticipanteModel participante);
}