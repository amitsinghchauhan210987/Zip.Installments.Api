using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Zip.Installments.Contracts;

namespace Zip.Installments.Api.Controllers
{
    [ApiController]
    [Route("api/zipinstallments")]
    public class ZipInstallmentsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ZipInstallmentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("v1")]
        [ProducesResponseType(
        typeof(PaymentPlan), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<PaymentPlan>> Get(decimal purchaseamount)
        {
            ZipInstallmentRequest _request = new ZipInstallmentRequest();
            _request.PurchaseAmount = purchaseamount;
             _request.StartDate = DateTime.Today;
            var response = await _mediator.Send(_request);
            return Ok(response);
        }
    }
}
