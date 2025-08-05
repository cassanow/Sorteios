using Microsoft.EntityFrameworkCore;
using Sorteios.Models;

namespace Sorteios.DataBase;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }
    
    public DbSet<SorteioModel> Sorteios { get; set; }
    
    public DbSet<ParticipanteModel> Participantes { get; set; }
}