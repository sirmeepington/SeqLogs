namespace SeqExiledLogs
{

    /// <summary>
    /// Utility class for logging to Seq.
    /// </summary>
    public static class LogToSeq
    {
        public static void Info(string template, params object[] args)
        {
            Serilog.Log.Logger.Information(template, args);
        }

        public static void Debug(string template, params object[] args)
        {
            Serilog.Log.Logger.Debug(template, args);
        }

        public static void Verbose(string template, params object[] args)
        {
            Serilog.Log.Logger.Verbose(template, args);
        }

        public static void Error(string template, params object[] args)
        {
            Serilog.Log.Logger.Error(template, args);
        }

        public static void Warning(string template, params object[] args)
        {
            Serilog.Log.Logger.Warning(template, args);
        }

        public static void Fatal(string template, params object[] args)
        {
            Serilog.Log.Logger.Fatal(template, args);
        }
    }
}
