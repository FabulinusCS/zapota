namespace Zapota.Common
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
