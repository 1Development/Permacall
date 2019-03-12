using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Permacall.Application.Accounts.Queries.GetAccount
{
    public class GetAccountQuery : IRequest<GetAccountViewModel>
    {
        public int AccountId { get; set; }
    }
}
