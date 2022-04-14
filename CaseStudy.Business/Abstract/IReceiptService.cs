using CaseStudy.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Business.Abstract
{
  public  interface IReceiptService
    {
        List<Receipt> ConvertJsonReceiptModel();
    }
}
