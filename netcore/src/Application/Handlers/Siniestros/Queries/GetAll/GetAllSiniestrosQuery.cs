using MediatR;

namespace Application.Handlers.Siniestros.Queries.GetAll;

public class GetAllSiniestrosQuery : IRequest<List<SiniestroDto>>
{
    public DateTime? FechaDesde { get; set; }
    public DateTime? FechaHasta { get; set; }
}