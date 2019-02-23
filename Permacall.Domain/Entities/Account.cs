using System;
using System.Collections.Generic;
using System.Text;
using Permacall.Domain.Enumerators;

namespace Permacall.Domain.Entities
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int OperatorCount { get; set; }
        public int NormalCount { get; set; }

        public int Strikes { get; set; }
        public DateTime LastStrike { get; set; }
        public bool toEdit { get; set; }

        public PermissionGroups PermissionGroup { get; set; }
    }
}
