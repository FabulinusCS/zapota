using System;

namespace Zapota.Entities
{
    public class Address
    {
        public Address()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public States State { get; set; }
        public string Zip { get; set; }
        public AddressType AddressType { get; set; }
    }

    public enum AddressType {
        Home,
        Work
    }

    public enum States
    {
            CO,
            CT
    }
}
