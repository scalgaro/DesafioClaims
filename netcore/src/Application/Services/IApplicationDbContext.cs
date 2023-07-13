using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public interface IApplicationDbContext
{
    public DbSet<Siniestro> Siniestros { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}