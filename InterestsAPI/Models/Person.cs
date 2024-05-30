using System.ComponentModel.DataAnnotations;

namespace InterestsAPI.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string Contact { get; set; }
        public IList<InterestParticipation>? InterestParticipations { get; set; }
    }
}