namespace eGame.Domain.Models;

public sealed class UserStorage : Entity
{
    private readonly List<StorageItem> _storageItems = new();
    public UserStorage(Guid id, Guid userGuid, int capacity) : base(id)
    {
        UserGuid = userGuid;
        Capacity = capacity;
    }

    public Guid UserGuid { get; private set; }
    public int Capacity { get; private set; }
    public IReadOnlyCollection<StorageItem> StorageItems => _storageItems;

    public static int AddCapacity(int currentCapacity, int addCapacity)
    {
        return currentCapacity + addCapacity;
    }


}