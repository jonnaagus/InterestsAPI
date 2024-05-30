using System.ComponentModel.DataAnnotations;

namespace InterestsAPI.Models
{
    public class Interest
    {
        [Key]
        public int InterestId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<InterestParticipation>? InterestParticipations { get; set; }
    }
}
