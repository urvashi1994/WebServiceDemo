using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDemo
{
    /// <summary>
    /// Summary description for CalculatorService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Addition(int No1, int No2)
        {
            return No1 + No2;
        }

        [WebMethod]
        public int Subtraction(int No1, int No2)
        {
            return No1 - No2;
        }
        [WebMethod]
        public int Multiplication(int No1, int No2)
        {
            return No1 * No2;
        }

        [WebMethod]
        public int Division(int No1, int No2)
        {
            return No1 / No2;
        }
    }
}
