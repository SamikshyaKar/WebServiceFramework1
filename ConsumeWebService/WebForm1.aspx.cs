using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeWebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService2SoapClient obj = new ServiceReference1.WebService2SoapClient();
           int result= obj.Addition(Convert.ToInt32(TxtFirstNum.Text), Convert.ToInt32(TxtSecondNum.Text));
            lblresult.Text = result.ToString();

        }
    }
}