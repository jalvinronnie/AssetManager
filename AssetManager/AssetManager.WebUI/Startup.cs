﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssetManager.WebUI.Startup))]
namespace AssetManager.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
