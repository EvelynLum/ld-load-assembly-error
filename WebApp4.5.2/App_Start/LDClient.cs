using LaunchDarkly.Sdk.Server;
using System.Configuration;

namespace WebApp4._5._2.App_Start
{
    public static class LDClient
    {
        public static readonly LdClient _instance;

        public static LdClient Instance
        {
            get
            {
                return _instance;
            }
        }

        static LDClient()
        {
            if (_instance == null)
                _instance = new LdClient(LaunchDarkly.Sdk.Server.Configuration.Builder(ConfigurationManager.AppSettings["LDSDK"]).Build());
        }
    }
}