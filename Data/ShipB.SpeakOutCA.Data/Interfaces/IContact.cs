using System.Collections.Generic;

namespace ShipB.SpeakOutCA.Data.Models
{
    public interface IContact
    {
        string Name { get; set; }
        string Title { get; set; }
        string Email { get; set; }
        string SecondaryEmail { get; set; }
        string Phone { get; set; }
        string SecondaryPhone { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string PostalCode { get; set; }

        IEnumerable<IContact> GetContacts();

    }
}