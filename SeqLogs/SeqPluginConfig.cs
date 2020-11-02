using Exiled.API.Interfaces;

namespace SeqExiledLogs
{
    public class SeqPluginConfig : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// The ingest URL for your Seq instance. This is where it takes data from.
        /// </summary>
        public string SeqUrl { get; set; } = "http://localhost:5341";

        public string SeqApiKey { get; set; } = "";
    }
}
