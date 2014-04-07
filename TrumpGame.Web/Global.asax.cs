using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using TrumpGame.Core.Infrastructure;

namespace TrumpGame.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //Cria o Database se não existir
            var databaseManagerService = new DatabaseManagerService();
            databaseManagerService.CreateDatabase();
        }
    }
}