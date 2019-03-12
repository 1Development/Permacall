using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Permacall.Domain.Enumerators;

namespace Permacall.Application.Accounts.Commands.UpdateAccount
{
    public class UpdateAccountCommand : IRequest
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int OperatorCount { get; set; }
        public int NormalCount { get; set; }
        public PermissionGroups PermissionGroup { get; set; }
    }
}
