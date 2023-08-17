using Application.Services;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Handlers.Siniestros.Queries.GetAll;

public class GetAllSiniestrosQueryHandler : IRequestHandler<GetAllSiniestrosQuery, List<SiniestroDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllSiniestrosQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<SiniestroDto>> Handle(GetAllSiniestrosQuery request, CancellationToken cancellationToken)
    {
        var siniestros = await _context.Siniestros
            .Where(x =>
                x.Fecha >= request.FechaDesde || request.FechaDesde == null
                && x.Fecha <= request.FechaHasta || request.FechaHasta == null
            )
            .OrderBy(x => x.Numero)
            .ToListAsync(cancellationToken);

        return _mapper.Map<List<SiniestroDto>>(siniestros);
    }
}