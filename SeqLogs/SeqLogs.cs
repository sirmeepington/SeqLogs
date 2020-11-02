using Exiled.API.Enums;
using Exiled.API.Features;
using Serilog;

namespace SeqExiledLogs
{
    /// <summary>
    /// A plugin that ties Seq event logging into SCP:SL.
    /// 
    /// For usage with EXILED and SCP: Secret Laboratory.
    /// 
    /// </summary>
    public class SeqLogs : Plugin<SeqPluginConfig>
    {

        public override string Author => "SirMeepington";

        public override string Name => "Seq Logger for EXILED";

        public override PluginPriority Priority => PluginPriority.First;

        public override void OnEnabled()
        {
            base.OnEnabled();
            Serilog.Log.Logger = new LoggerConfiguration().WriteTo.Seq(Config.SeqUrl, apiKey: Config.SeqApiKey).CreateLogger();
            if (Config.SeqApiKey == null)
            {
                Exiled.API.Features.Log.Warn("No Seq API Key set. " +
                    "It will used the Unauthenticated ingest portal instead of your application's. " +
                    "If this is not intended; set the API key before using the logging features.");
            }
        }
    }
}
