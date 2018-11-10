using System;
using System.Collections.Generic;
using Zapota.Common;

namespace Zapota.Entities
{
    public class Wellness : IEntity
    {
        public Wellness()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public List<WellnessFactor> WellnessFactors { get; set; }
        public List<HealthScore> HealthScores { get; set; }
        public List<MedicalCondition> MedicalConditions { get; set; }
        public List<Medication> Medications { get; set; }
        public List<Activity> Activities { get; set; }
        public List<Diet> Diets { get; set; } 
    }
}
