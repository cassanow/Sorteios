using System.ComponentModel.DataAnnotations;

namespace Sorteios.Models;

public class ParticipanteModel
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Nome { get; set; }
    
    public int SorteioId { get; set; }
    
    public SorteioModel Sorteio { get; set; }
}