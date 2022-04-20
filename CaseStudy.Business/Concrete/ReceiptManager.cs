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
        public string[] ConvertJsonReceiptModel()
        {
            var path = Helper.CHelper.GetFilePath();

            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                List<Receipt> receipt = JsonConvert.DeserializeObject<List<Receipt>>(json);

                receipt.Remove(receipt.First());

                string[] keys = new string[receipt.Count()];
                for (int i = 0; i < receipt.Count; i++)
                {

                    if (i == 0)
                    {
                        keys[i] = receipt[i].Description;
                    }
                    else
                    {
                        var currentX = receipt[i].BoundingPoly.Vertices.First().X;
                        var backX = receipt[i - 1].BoundingPoly.Vertices.First().X;
                        var lastIndex = keys.LastOrDefault(x => !string.IsNullOrEmpty(x));

                        if (currentX <= backX)
                        {
                            keys[Array.LastIndexOf(keys, lastIndex) + 1] = receipt[i].Description;
                        }
                        else
                        {
                            if (lastIndex.Contains(receipt[i - 1].Description))
                            {
                                keys[Array.LastIndexOf(keys, lastIndex)] += " " + receipt[i].Description;
                            }
                            else
                            {
                                keys[Array.LastIndexOf(keys, lastIndex) + 1] += receipt[i].Description;
                            }

                        }
                    }
                }

                return keys.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            }

        }


    }
}
