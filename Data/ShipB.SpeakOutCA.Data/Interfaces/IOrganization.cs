using System.Collections.Generic;

namespace ShipB.SpeakOutCA.Data.Models
{
    public interface IOrganization
    {
        int ID { get; set; }
        string Name { get; set; }
        List<IContact> Contacts { get; set; }
    }
}
