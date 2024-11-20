using System.ComponentModel.DataAnnotations;

namespace RolodexApp.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        [MaxLength(2), MinLength(2)]
        public string? State { get; set; }
        public string? PostalCode { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
