using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipB.SpeakOutCA.Data.Models
{
    public class CategoryGroup
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Category> Categories { get; set; }
    }
}
