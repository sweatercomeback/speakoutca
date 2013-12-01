using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipB.SpeakOutCA.Data.Models
{
    public class Contact : IContact
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string SecondaryEmail { get; set; }
        public string Phone { get; set; }
        public string SecondaryPhone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        
        public IEnumerable<IContact> GetContacts()
        {
            var contacts = new List<Contact>();



            return contacts;
        }
    }
}
