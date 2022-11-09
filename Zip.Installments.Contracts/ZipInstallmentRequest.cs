using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zip.Installments.Contracts
{
    public class ZipInstallmentRequest : IRequest<PaymentPlan>
    {
        public decimal PurchaseAmount { get; set; }
        public DateTime StartDate { get; set; }
    }
}
