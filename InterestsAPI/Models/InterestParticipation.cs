using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterestsAPI.Models
{
    public class InterestParticipation
    {
        [Key]
        public int Id { get; set; }
        public IList<string>? Resources { get; set; }
        [ForeignKey("Person")]
        public int FKPersonId { get; set; }
        public Person? Person { get; set; }
        [ForeignKey("Interest")]
        public int FKInterestId { get; set; }
        public Interest? Interest { get; set; }
    }
}