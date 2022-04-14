using CaseStudy.Business.Abstract;
using CaseStudy.Business.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Business.Concrete
{
    public class CodeManager : ICodeService
    {
        public bool CheckCode(string code)
        {
            var charCode = code.ToCharArray();
            bool retVal = true;
            if (code.Length!=8)
            {
               return retVal = false;
            }
            for (int i = 0; i < charCode.Length; i++)
            {

                if (i == 0)
                {
                    if (!CHelper.CheckChar(charCode[i], null, null) || !char.IsLower(charCode[i]))
                    {
                        return false;
                    }

                }

                else if (i == 1)
                {
                    if (!CHelper.CheckChar(charCode[i], null, null))
                    {
                        return false;
                    }
 
                }

                else if (i == 2)
                {
                    if (!CHelper.CheckChar(charCode[i], true, true))
                    {
                        return false;
                    }

                }
                else if (i == 3)
                {
                    if (!CHelper.CheckChar(charCode[i], null, null))
                    {
                        return false;
                    }
                }

                else if (i == 4)
                {
                    if (!CHelper.CheckChar(charCode[i], null, null))
                    {
                        return false;
                    }
                }

                else if (i == 5)
                {
                    if (!CHelper.CheckChar(charCode[i], null, null))
                    {
                        return false;
                    }
                }

                else if (i == 6)
                {
                    if (!CHelper.CheckChar(charCode[i], true, false))
                    {
                        return false;
                    }
                }

                else if (i == 7)
                {
                    if (!CHelper.CheckChar(charCode[i], null, null) || !char.IsLower(charCode[i]))
                    {
                        return false;
                    }
                }

            }
            return retVal;
        }

        public string GenerateCode()
        {
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        stringChars[i] = char.ToLower(CHelper.GetChar(false, false));
                        break;
                    case 1:
                        stringChars[i] = CHelper.GetChar(null, null);
                        break;
                    case 2:
                        stringChars[i] = CHelper.GetChar(true, true);
                        break;
                    case 3:
                        stringChars[i] = CHelper.GetChar(null, null);
                        break;
                    case 4:
                        stringChars[i] = CHelper.GetChar(null, null);
                        break;
                    case 5:
                        stringChars[i] = CHelper.GetChar(null, null);
                        break;
                    case 6:
                        stringChars[i] = CHelper.GetChar(true, false);
                        break;
                    case 7:
                        stringChars[i] = char.ToLower(CHelper.GetChar(false, false));
                        break;
                }
            }

            var finalString = new String(stringChars);

            return finalString;
        }
        /// <summary>
        /// Belirlenen kurala göre kod oluşturulur. 
        /// Kural: Baştan 3. hane tek sayı sondan ikinci hane çift sayı ilk hane ve son hane harf ve küçük olmalı. (Tamamı verilen karakter kümesinden olmalı.)
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<string> GenerateCodes(int count)
        {
            List<string> codes = new List<string>();

            for (int i = 0; i < count; i++)
            {
                var finalString = GenerateCode();
                if (!codes.Any(x => x == finalString))
                {
                    codes.Add(finalString);
                }
            }

            return codes;
        }
    }
}
