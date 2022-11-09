using System;
using System.Collections.Generic;
using System.Text;

namespace Zip.Installments.Contracts
{
    public class PaymentPlan
    {
        public Guid Id { get; set; }

        public decimal PurchaseAmount { get; set; }

        public List<Installment> Installments { get; set; }
    }
}
