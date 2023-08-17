using Application.Handlers.Siniestros.Commands.Create;
using Application.Handlers.Siniestros.Queries;
using Application.Handlers.Siniestros.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SiniestrosController : ControllerBase
{
    private readonly IMediator _mediator;

    public SiniestrosController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] GetAllSiniestrosQuery query)
    {
        return Ok(await _mediator.Send(query));
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateSiniestroCommand command)
    {
        return Created("", await _mediator.Send(command));
    }
}