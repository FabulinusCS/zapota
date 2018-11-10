using System;

namespace Zapota.Entities
{
    public class Medication
    {
        public Medication()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
