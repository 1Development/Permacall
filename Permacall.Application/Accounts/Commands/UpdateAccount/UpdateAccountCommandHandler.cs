using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Permacall.Domain.Enumerators;
using Permacall.Persistence;

namespace Permacall.Application.Accounts.Commands.UpdateAccount
{
    public class UpdateAccountCommandHandler : IRequestHandler<UpdateAccountCommand>
    {
        private readonly PermacallDbContext _context;

        public UpdateAccountCommandHandler(PermacallDbContext context)
        {
            _context = context;
        }


        public async Task<Unit> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
        {
            var account = await _context.Accounts
                .SingleAsync(x => x.AccountId == request.AccountId, cancellationToken);

            account.Username = request.Username;
            account.Password = request.Password;
            account.OperatorCount = request.OperatorCount;
            account.NormalCount = request.NormalCount;
            account.PermissionGroup = request.PermissionGroup;

            _context.Accounts.Update(account);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
