using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy.Web.Refit.Interfaces
{
    [Headers("Content-Type: application/json; charset=UTF-8")]

    public interface IReceiptApi
    {
        [Get("/GetReceipt")]
        Task<List<string>> GetReceipt();
    }
}
