using System;
using System.Collections.Generic;
using System.Text;

namespace Zapota.Entities
{
    public class Profile
    {
        public Profile()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string RaceId { get; set; }
        public Gender Gender { get; set; }
        public string EthnicityId { get; set; }
        public MaritialStatus MaritialStatus { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Email> Emails { get; set; }
    }
}
