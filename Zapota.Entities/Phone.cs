using System;

namespace Zapota.Entities
{
    public class Phone
    {
        public Phone()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneType PhoneType { get; set; }

    }

    public enum PhoneType
    {

    }
}
