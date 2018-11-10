using System;

namespace Zapota.Entities
{
    public class Recommendation
    {
        public Recommendation()
        {
            Id = Guid.NewGuid();
        } 
        public Guid Id { get; set; }
        public string Value { get; set; }
        public int Priority { get; set; }
    }
}
