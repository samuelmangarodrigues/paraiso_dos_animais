namespace ParaisoDosAnimais.Models
{
    public abstract class BaseModel
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
    }
}