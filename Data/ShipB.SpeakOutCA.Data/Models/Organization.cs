﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipB.SpeakOutCA.Data.Models
{
    

    public class Organization : IOrganization
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<IContact> Contacts { get; set; }
    }
}
