using System;

namespace Zapota.Common
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
    public interface IEntity : IEntity<Guid>
    {
    } 
}
