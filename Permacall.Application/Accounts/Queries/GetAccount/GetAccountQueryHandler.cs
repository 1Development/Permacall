using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Permacall.Persistence;

namespace Permacall.Application.Accounts.Queries.GetAccount
{
    public class GetAccountQueryHandler : IRequestHandler<GetAccountQuery, GetAccountViewModel>
    {
        private readonly PermacallDbContext _context;
        private readonly IMapper _mapper;

        public GetAccountQueryHandler(PermacallDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        

        public async Task<GetAccountViewModel> Handle(GetAccountQuery request, CancellationToken cancellationToken)
        {
            var account = _mapper.Map<GetAccountViewModel>(
                await _context.Accounts.SingleAsync(x => x.AccountId == request.AccountId));

            return account;

        }
    }
}
