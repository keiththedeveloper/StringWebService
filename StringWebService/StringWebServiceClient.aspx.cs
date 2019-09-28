using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StringWebService.WebStringWebService;

namespace StringWebService
{
    public partial class StringWebServiceClient : System.Web.UI.Page
    {
        StringWebService serviceObj = new StringWebService();
        String str, substr;
        int start, len;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void VowelCheck_Click(object sender, EventArgs e)
        {
            str = TextBox1.Text;
            Label5.Text= Convert.ToString(serviceObj.VowelsCount(str));
        }

        protected void SubstringGen_Click(object sender, EventArgs e)
        {
            str = TextBox1.Text;
            start=Convert.ToInt32(TextBox3.Text);
            len=Convert.ToInt32(TextBox4.Text);
            Label3.Text = serviceObj.ExtractString(str, start, len);
        }

        protected void Strcheck_Click(object sender, EventArgs e)
        {
            str = TextBox1.Text;
            substr = TextBox2.Text;
            if (serviceObj.CheckSubString(str, substr))
                chklabel.Text = "Given string contains within it the given substring.";
            else
                chklabel.Text = "Given string does not contains within it the given substring.";

        }

      
    }
}