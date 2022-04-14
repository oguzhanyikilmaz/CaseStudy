using CaseStudy.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CodeController : ControllerBase
    {
        private ICodeService _codeService;

        public CodeController(ICodeService codeService)
        {
            _codeService = codeService;
        }
        [HttpGet("GenerateCodes/{count}")]
        public List<string> GenerateCodes(int? count)
        {
            if (count!=null && count!=0)
            {
                return _codeService.GenerateCodes(count.Value);
            }
            else
            {
                return _codeService.GenerateCodes(1000);
            }
                       
        }
        [HttpGet("CheckCode/{code}")]
        public bool CheckCode(string code)
        {
            return _codeService.CheckCode(code);

        }
    }
}
