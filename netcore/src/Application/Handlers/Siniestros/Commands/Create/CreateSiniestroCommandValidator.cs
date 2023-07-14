using FluentValidation;

namespace Application.Handlers.Siniestros.Commands.Create;

public class CreateSiniestroCommandValidator : AbstractValidator<CreateSiniestroCommand>
{
    public CreateSiniestroCommandValidator()
    {
        RuleFor(x => x.Tipo)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(x => x.Descripcion)
            .NotEmpty()
            .MaximumLength(200);

        RuleFor(x => x.Direccion)
            .NotEmpty()
            .MaximumLength(200);

        RuleFor(x => x.Localidad)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.Provincia)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.Pais)
            .NotEmpty()
            .MaximumLength(100);
    }
}