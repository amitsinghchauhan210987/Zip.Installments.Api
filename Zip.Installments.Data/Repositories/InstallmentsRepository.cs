using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zip.Installments.Contracts;
using Zip.Installments.Data.Interfaces;

namespace Zip.Installments.Data.Repositories
{
    public class InstallmentsRepository : IInstallmentsRepository
    {
        public InstallmentsRepository() 
        { }
        public PaymentPlan CreatePaymentPlan(ZipInstallmentRequest request)
        {
            var paymentPlan = new PaymentPlan();
            var installmentsAmount = request.PurchaseAmount / 4;
            var installments = new List<Installment>();
            for (int i = 0; i < 4; i++)
            {
                Installment installment = new Installment();
                installment.Amount = installmentsAmount;
                installment.DueDate = request.StartDate.AddDays(i * 14);
                installment.Id = Guid.NewGuid();
                installments.Add(installment);
            }
            paymentPlan.Id = Guid.NewGuid();
            paymentPlan.Installments = installments;
            paymentPlan.PurchaseAmount = request.PurchaseAmount;
            return paymentPlan;
        }
    }
}
