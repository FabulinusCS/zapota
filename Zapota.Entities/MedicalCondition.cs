using System;

namespace Zapota.Entities
{
    public class MedicalCondition
    {
        public MedicalCondition()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
