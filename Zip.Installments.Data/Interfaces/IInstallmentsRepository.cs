using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zip.Installments.Contracts;

namespace Zip.Installments.Data.Interfaces
{
    public interface IInstallmentsRepository
    {
         PaymentPlan CreatePaymentPlan(ZipInstallmentRequest request);
    }
}
