using System;

namespace Zapota.Entities
{
    public class Email
    {
        public Email()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string EmailId { get; set; }
        public EmailIdType EmailIdType { get; set; }
    }
    public enum EmailIdType
    {

    }
}
