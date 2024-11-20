using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RolodexApp.Models
{
    public enum ResponseType
    {
        NoAnswer = 0,
        Answer = 1,
        Machine = 2,
        WrongNumber = 3
    }

    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }
        
        public string Reason { get; set; }
        public DateTime ContactedOn { get; set; }
        public int LengthOfCall { get; set; } // sec
        public ResponseType Response { get; set; }

        [NotMapped]
        public int NumMinutes => (int) Math.Ceiling((double) LengthOfCall / 60);
    }
}
