namespace ParaisoDosAnimais.Services.Errors
{
    public record AlreadyExistsError(string Entity) :AppErrors($"{Entity} already exists", ErrorTypes.Conflict);
}
