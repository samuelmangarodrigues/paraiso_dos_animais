namespace ParaisoDosAnimais.Services.Errors

{
    public record NotFoundError(string Entity) :AppErrors($"{Entity} not found", ErrorTypes.NotFound);
}
