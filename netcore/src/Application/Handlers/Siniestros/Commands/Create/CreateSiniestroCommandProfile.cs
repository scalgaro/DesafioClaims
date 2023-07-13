using AutoMapper;
using Domain;

namespace Application.Handlers.Siniestros.Commands.Create;

public class CreateSiniestroCommandProfile : Profile
{
    public CreateSiniestroCommandProfile()
    {
        CreateMap<CreateSiniestroCommand, Siniestro>()
            .ConstructUsing(c => new Siniestro(
                c.Descripcion,
                c.Fecha,
                c.Tipo,
                c.Direccion,
                c.Localidad,
                c.Provincia,
                c.Pais
            ));
    }
}