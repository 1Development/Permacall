using System;
using Permacall.Common;

namespace Permacall.Infrastructure
{
    public class MachineDateTime : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
