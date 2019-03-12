using System;
using System.Collections.Generic;
using System.Text;
using Permacall.Domain.Enumerators;

namespace Permacall.Application.Accounts.Queries.GetAccount
{
    public class GetAccountViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int OperatorCount { get; set; }
        public int NormalCount { get; set; }
        public PermissionGroups PermissionGroup { get; set; }
    }
}
