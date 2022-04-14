using CaseStudy.Business.Abstract;
using CaseStudy.Business.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Business.Concrete
{
    public class ReceiptManager : IReceiptService
    {
        public List<Receipt> ConvertJsonReceiptModel()
        {
            var path= Helper.CHelper.GetFilePath();

            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                List<Receipt> receipt = JsonConvert.DeserializeObject<List<Receipt>>(json);
                return receipt;
            }

        }

        
    }
}
