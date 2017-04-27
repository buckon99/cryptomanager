using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using SilvioSite.Service.DataConnector;

[assembly: OwinStartup(typeof(CyptoManager.Startup))]

namespace CyptoManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CoinMarketCapConnector.updateTicker();
        }
    }
}
