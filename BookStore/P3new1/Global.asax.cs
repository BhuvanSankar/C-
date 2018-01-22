using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace P3new1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {    
    
        // Code that runs on application startup
        ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
        myScriptResDef.Path = "~/scripts/jquery-1.8.1.js";
        myScriptResDef.DebugPath = "~/scripts/jquery-1.8.1.js";
        myScriptResDef.CdnPath = "http://code.jquery.com/jquery-1.8.1.js";
        myScriptResDef.CdnDebugPath = "http://code.jquery.com/jquery-1.8.1.js";
        ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
 
    
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

    }
}