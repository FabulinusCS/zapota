using System;
using System.Collections.Generic;

namespace Zapota.Entities
{
    public class HealthScore
    {
        public HealthScore()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public List<Guid> WellnessFactorIds { get; set; }
        public int OverAllScore { get; set; }
        public DateTime DateScored { get; set; }
        public List<Recommendation> Recommendations { get; set; }
    }
}
