using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zip.Installments.Contracts;
using Zip.Installments.Data.Interfaces;

namespace Ecom.Manage.Handler.Query
{
    public class GetInstallmentsHandler : IRequestHandler<ZipInstallmentRequest, PaymentPlan>
    {
        private IInstallmentsRepository _repo;
        public GetInstallmentsHandler(IInstallmentsRepository repo)
        {
            _repo = repo;
        }
        public async Task<PaymentPlan> Handle(ZipInstallmentRequest request, CancellationToken canceltoken)
        {
            var _content =  _repo.CreatePaymentPlan(request);
            return _content;
        }
    }
}
