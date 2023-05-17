namespace eGame.Domain.Models;

public sealed class StorageItem : Entity
{
    public StorageItem(Guid id, string name, string quantity) : base(id)
    {
        Name = name;
        Quantity = quantity;
    }
    public string Name { get; private set; }
    public string Quantity {get; private set; }
    public Guid UserStorageGuid { get; private set; }
}