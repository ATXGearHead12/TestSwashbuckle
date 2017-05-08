using System;
using System.Configuration;

namespace StarterApi.ConfigurationUtilities
{
    /// <summary>
    /// A set of helper functions to talk to Identity server
    /// </summary>
    public static class IdentityHelp
    {
        private static string BaseURL = null;
        /// <summary>
        /// Get the configuration information for IdentityServer and Client base Uri's
        /// </summary>
        /// <returns></returns>
        public static string GetBaseUri()
        {
            if (BaseURL == null)
            {
                //Read configuration setting from web.config
                if (ConfigurationManager.AppSettings["BaseAddress"] == null)
                    throw new Exception("Missing web.config entry for BaseAddress");
                BaseURL = ConfigurationManager.AppSettings["BaseAddress"];

            }

            return BaseURL;
        }
    }
}