using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;

public partial class LoginForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn1_Click(object sender, EventArgs e)
    {      
        string user_agent = HttpUtility.UrlEncode(txt1.Text);

        // Put your api key in this variable:
        api_key = "";

        // -- Create the constructor with post type and few data
        MyWebRequest myRequest = new MyWebRequest("https://api.whatismybrowser.com/api/v1/user_agent_parse", "POST", "user_key=" + api_key + "&user_agent=" + user_agent);

        // -- Show the response string on the console screen
        Response.Write(myRequest.GetResponse());
    }
}
