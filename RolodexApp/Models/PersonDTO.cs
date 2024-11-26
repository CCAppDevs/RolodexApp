using System.ComponentModel.DataAnnotations;

namespace RolodexApp.Models
{
    public class PersonDTO
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }

        public string FullName { get => FirstName + " " + LastName; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
