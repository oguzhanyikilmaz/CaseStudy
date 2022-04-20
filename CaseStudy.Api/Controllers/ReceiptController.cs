using CaseStudy.Business.Abstract;
using CaseStudy.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptController : ControllerBase
    {
        private IReceiptService _receiptService;

        public ReceiptController(IReceiptService receiptService)
        {
            _receiptService = receiptService;
        }
        [HttpGet]
        public List<string> GetReceipt()
        {
            return _receiptService.ConvertJsonReceiptModel().ToList();
        }
    }
}
