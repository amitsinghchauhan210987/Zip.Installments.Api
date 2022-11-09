using Microsoft.VisualBasic;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Zip.Installments.Contracts;

namespace Zip.Installments.Test
{
    public class TestData
    {
        public static IEnumerable WithInValidData()
        {
            yield return new TestCaseData(null);
        }
        public static IEnumerable WithValidData()
        {
            yield return new TestCaseData(new ZipInstallmentRequest { PurchaseAmount = 100, StartDate = DateTime.Now.Date }
            , new PaymentPlan
            {
                Id = Guid.NewGuid(),
                PurchaseAmount = 100,
                Installments = new List<Installment> { new Installment { Amount = 25, Id = Guid.NewGuid(), DueDate = DateTime.Now.Date },
                new Installment { Amount = 25, Id = Guid.NewGuid(), DueDate = DateTime.Now.AddDays(14).Date },
                new Installment { Amount = 25, Id = Guid.NewGuid(), DueDate = DateTime.Now.AddDays(14*2).Date },
                new Installment { Amount = 25, Id = Guid.NewGuid(), DueDate = DateTime.Now.AddDays(14*3).Date }}
            }
                      );
        }
    }
}
