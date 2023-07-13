# Desafío claims

## Cómo ejecutar la API:

1. Clonar el repositorio.
2. Asegurarse de tener instalado SQL Express para tener una base a la que conectarse. [Click me.](https://www.microsoft.com/es-ar/download/details.aspx?id=101064)
3. Asegurarse de tener Visual Studio o algún IDE para .NET Core. [Click me.](https://visualstudio.microsoft.com/es/vs/)
4. En caso de que no lo haya instalado el IDE, asegurarse de tener instalado el SDK de .NET Core 7. [Click me.](https://dotnet.microsoft.com/download)
5. Abrir el proyecto en el IDE.
6. En el archivo `appsettings.json` cambiar la cadena de conexión a la base de datos por la que corresponda. En caso de que se haya instalado SQL Express, podés dejar la cadena de conexión que viene por defecto.
7. Instalar el CLI de Entity Framework Core. [Click me.](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)
8. Abrir una consola de comandos en la carpeta 'scr/Infrastructure' y ejecutar el comando `dotnet ef database update`. Esto creará la base de datos y las tablas necesarias.
9. Ejecutar la aplicación.
10. La API estará corriendo en `https://localhost:5001/` y `http://localhost:5000/`.
11. Para probar la API, se puede entrar al Swagger de la API en `https://localhost:5001/swagger/index.html`, o usar Postman.

## Términos clave para entender el proyecto:

Si estás medio perdido en la estructura del proyecto, te recomiendo buscar estos términos.

- **Clean Architecture**: Es una arquitectura de software que separa las responsabilidades de cada capa de la aplicación. [Click me.](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures#clean-architecture)
- **CQRS**: Es un patrón de diseño que separa las responsabilidades de lectura y escritura de la aplicación. [Click me.](https://docs.microsoft.com/en-us/azure/architecture/patterns/cqrs)
- **MediatR**: Es una librería que implementa el patrón Mediator muy relacionado con CQRS.
- **Entity Framework Core**: Es un ORM que permite mapear las tablas de una base de datos a clases de C#.
- **Swagger**: Es una herramienta que permite documentar una API y probarla. [Click me.](https://swagger.io/)
- **AutoMapper**: Es una librería que permite mapear clases de C# a otras clases de C#. [Click me.](https://automapper.org/)
- **FluentValidation**: Es una librería que permite validar objetos de C#. [Click me.](https://fluentvalidation.net/)

## Tareas:

Marca con una `x` las tareas que hayas completado:

### Nivel 1

- [ ] Agregar un filtro en el GET de siniestros para filtrar por número de siniestro.
- [ ] 