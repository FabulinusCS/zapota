using System;

namespace Zapota.Entities
{
    public class Activity
    {
        public Activity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
