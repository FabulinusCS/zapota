using System;

namespace Zapota.Entities
{
    public class Diet
    {
        public Diet()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
