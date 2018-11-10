using System;
using System.Collections.Generic;

namespace Zapota.Entities
{
    public class WellnessFactor
    {

        public WellnessFactor()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public WellnessFactorType WellnessFactorType { get; set; }
        public int WellnessScore { get; set; }
        public List<WellnessFactor> WellnessFactors { get; set; }
        public List<Metric> Metrics { get; set; }
    }
}
    