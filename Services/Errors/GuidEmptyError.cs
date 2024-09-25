namespace ParaisoDosAnimais.Services.Errors
{
    public record GuidEmptyError() :AppErrors("Id is invalid or empty", ErrorTypes.BadRequest);
}
