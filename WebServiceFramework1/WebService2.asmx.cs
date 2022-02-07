using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceFramework1
{
    /// <summary>
    /// Summary description for WebService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService2 : System.Web.Services.WebService
    {

        [WebMethod(EnableSession =true)]
        public int Addition(int firstnum, int secondnum)
        {
            List<string> Values;
            if (Session["Calculations"] == null)
            {
                Values = new List<string>();
            }
            else
            {
                Values = (List<string>)Session["Calculations"];
            }

            string RecentCalculations = firstnum.ToString() + "+ "+ secondnum.ToString() + " " + "=" + (firstnum + secondnum).ToString();
            Values.Add(RecentCalculations);
            Session["Calculations"] = Values;
            return firstnum + secondnum;
        }
        [WebMethod(EnableSession =true)]
        public List<string> GetCalculations()
        {

            if (Session["Calculations"]==null)
            {
                List<string> Calculations = new List<string>();
                Calculations.Add("No Calculations Performed");
                return Calculations;
            }
            else
            {
                return  (List<string>) Session["Calculations"];
            }
        }
    }
}
