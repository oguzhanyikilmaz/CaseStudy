using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Business.Helper
{
   public class CHelper
    {
        public static char GetChar(bool? isDigit,bool? evenNumber)
        {
            var chars = "ACDEFGHKLMNPRTXYZ";
            var numericChars = "24";
            var numericEvenChars = "3579";
            var fullChars = chars + numericChars + numericEvenChars;
            var random = new Random();

            var character = chars[random.Next(chars.Length)];

            if (isDigit!=null && isDigit.Value && evenNumber!=null &&  evenNumber.Value)
            {
              return  character= numericEvenChars[random.Next(numericEvenChars.Length)];
            }
            else if (isDigit != null && isDigit.Value && evenNumber != null && !evenNumber.Value)
            {
                return character = numericChars[random.Next(numericChars.Length)];
            }
            else if (isDigit==null && evenNumber==null)
            {
                return character = fullChars[random.Next(fullChars.Length)];
            }
            else
            {
                return character;
            }
        }

        public static bool CheckChar(char character,bool? isDigit, bool? evenNumber)
        {
            var chars = "ACDEFGHKLMNPRTXYZ";
            var numericChars = "24";
            var numericEvenChars = "3579";
            var fullChars = chars + numericChars + numericEvenChars;

            bool retVal = false;
            if (isDigit != null && isDigit.Value && evenNumber != null && evenNumber.Value)
            {
                if (char.IsDigit(character) && (int)character % 2 !=0 && numericEvenChars.Contains(character))
                {
                    retVal= true;
                }
            }
            else if (isDigit != null && isDigit.Value && evenNumber != null && !evenNumber.Value)
            {
                if (char.IsDigit(character) && (int)character % 2 == 0 && numericChars.Contains(character))
                {
                    retVal= true;
                }
            }
            else if (isDigit == null && evenNumber == null)
            {
                if (fullChars.Contains(char.ToUpper(character)))
                {
                    retVal= true;
                }
            }

            return retVal;
        }

        public static string GetFilePath()
        {
            var file = Directory.GetParent("~\response.json");
            var path = file.Parent+ @"\CaseStudy.Web\wwwroot\response.json";
            return path;
        }
    }
}
