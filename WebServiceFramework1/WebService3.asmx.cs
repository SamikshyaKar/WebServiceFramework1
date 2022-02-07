using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceFramework1
{
    /// <summary>
    /// Summary description for WebService3
    /// </summary>
    [WebService(Namespace = "http://abc.com/webservices")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService3 : System.Web.Services.WebService
    {

        [WebMethod]
        public int Addition(int firstnum, int secondnum)
        {
            return firstnum + secondnum;
        }

        [WebMethod (MessageName ="AddThreeNumbers")]
        public int Addition(int firstnum, int secondnum, int thirdnum)
        {
            return firstnum + secondnum+thirdnum;
        }
    }
}
