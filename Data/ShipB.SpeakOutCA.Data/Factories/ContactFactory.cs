using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipB.SpeakOutCA.Data.Models;

namespace ShipB.SpeakOutCA.Data.Factories
{
    public class ContactFactory
    {
        private readonly IContact _contactEntity;

        public ContactFactory(IContact contact)
        {
            _contactEntity = contact;
        }

        public List<IContact> GetContacts()
        {
            return _contactEntity.GetContacts().ToList();
        }
    }
}
