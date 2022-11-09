using Ecom.Manage.Handler.Query;
using NUnit.Framework;
using System;
using System.Threading;
using Zip.Installments.Contracts;
using Zip.Installments.Data.Interfaces;

namespace Zip.Installments.Test
{
    public class Tests
    {
        public  GetInstallmentsHandler _getInstallmentsHandler;
        private IInstallmentsRepository _repo;
        [SetUp]
        public void Setup()
        {
            _getInstallmentsHandler = new GetInstallmentsHandler(_repo);
        }

        [Test,TestCaseSource(typeof(TestData),nameof(TestData.WithInValidData))]
        public void Handle_Should_Not_GetData(ZipInstallmentRequest request, ZipInstallmentRequest requestinstallment)
        {
            CancellationToken canceltoken = new CancellationToken();
            _getInstallmentsHandler.Handle(request, canceltoken);
            Assert.Fail();
        }
        [Test, TestCaseSource(typeof(TestData), nameof(TestData.WithValidData))]
        public void Handle_Should_GetData(ZipInstallmentRequest request, ZipInstallmentRequest requestinstallment, PaymentPlan Expectedresponse)
        {
            CancellationToken canceltoken = new CancellationToken();
            _getInstallmentsHandler.Handle(request, canceltoken);
            Assert.Pass();
        }
    }
}