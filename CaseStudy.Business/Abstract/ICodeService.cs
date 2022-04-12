using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Business.Abstract
{
  public interface ICodeService
    {
        List<string> GenerateCodes(int count);
        string GenerateCode();
        bool CheckCode(string code);
    }
}
