using System.ComponentModel.DataAnnotations;

namespace Brello.Models
{
    public class Vote
    {
        [Key]
        public int VoteId { get; set; }

        public int Value { get; set; }
        public Card Card { get; set; }
        public ApplicationUser User { get; set; }
    }
}