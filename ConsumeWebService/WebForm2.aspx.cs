using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeWebService
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnresult_Click(object sender, EventArgs e)
        {
           
            ServiceReference2.WebService2SoapClient obj = new ServiceReference2.WebService2SoapClient();
            int result = obj.Addition(Convert.ToInt32(TxtFirst.Text), Convert.ToInt32(TxtSecond.Text));
            LblMessage.Text = result.ToString();

             Gridview1.DataSource=obj.GetCalculations();
              Gridview1.DataBind();
        }
    }
}