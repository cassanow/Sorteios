using Sorteios.Models;

namespace Sorteios.Interface;

public interface ISorteioInterface
{
    Task CriarSorteio(SorteioModel sorteio);
    
    Task <bool> SorteioExiste(int id);
    
    Task FinalizarSorteio(SorteioModel sorteio);
}