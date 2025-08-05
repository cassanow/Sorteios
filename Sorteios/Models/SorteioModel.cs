using System.ComponentModel.DataAnnotations;
using Sorteios.Enum;

namespace Sorteios.Models;

public class SorteioModel
{
    [Key]
    public int Id { get; set; }
    
    public string Nome { get; set; }
    
    public Tipo Tipo { get; set; }
    
    public DateTime Data { get; set; } = DateTime.Now;
    
    public string Resultado { get; set; }
    
    public List<ParticipanteModel> Participantes { get; set; }
}