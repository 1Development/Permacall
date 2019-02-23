using System;
using System.Collections.Generic;
using System.Text;

namespace Permacall.Domain.Entities.LanParty
{
    public class Insomnia
    {
        public DateTime? Start { get; set; }
        public ICollection<InsomniaUser> Users { get; set; }
    }
}
