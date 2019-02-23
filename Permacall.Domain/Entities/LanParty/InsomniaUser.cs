using System;
using System.Collections.Generic;
using System.Text;

namespace Permacall.Domain.Entities.LanParty
{
    public class InsomniaUser
    {
        public string Name { get; set; }
        public DateTime? DropOutTime { get; set; }
        public DateTime? WakeUpTime { get; set; }
    }
}
