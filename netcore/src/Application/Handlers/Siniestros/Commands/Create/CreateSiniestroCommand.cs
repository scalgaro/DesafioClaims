using MediatR;

namespace Application.Handlers.Siniestros.Commands.Create;

public class CreateSiniestroCommand : IRequest<Guid>
{
    public CreateSiniestroCommand(string descripcion, DateTime fecha, string tipo, string direccion, string localidad,
        string provincia, string pais)
    {
        Descripcion = descripcion;
        Fecha = fecha;
        Tipo = tipo;
        Direccion = direccion;
        Localidad = localidad;
        Provincia = provincia;
        Pais = pais;
    }

    public string Descripcion { get; set; }
    public DateTime Fecha { get; set; }
    public string Tipo { get; set; }
    public string Direccion { get; set; }
    public string Localidad { get; set; }
    public string Provincia { get; set; }
    public string Pais { get; set; }
}