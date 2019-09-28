using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;

namespace StringWebService
{
    /// <summary>
    /// Summary description for StringWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StringWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int VowelsCount(String str)
        {

            int vowelsCount = 0;
            for (int  i= 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'A' || str[i] == 'e' || str[i] == 'E' || str[i] == 'i' || str[i] == 'I' || str[i] == 'o' || str[i] == 'O' || str[i] == 'u' || str[i] == 'U')
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }

        [WebMethod]
        public String ExtractString(String str1,int start,int len)
        {

            String str2 = str1.Substring(start, len);
            return str2;
        }

        [WebMethod]
        public bool CheckSubString(String str, String substr)
        {

            if (str.Contains(substr))
                return true;
            else
                return false;

           
        }

    }
}
