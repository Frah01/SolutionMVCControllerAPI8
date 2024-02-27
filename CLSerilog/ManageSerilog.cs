using Serilog;
namespace CLSerilog
{
    public static class ManageSerilog
    {
        private static string sMsg = string.Empty;
        private static readonly ILogger _log = Log.ForContext(typeof(ManageSerilog));

        public static void LogVerbose(string utenteLoggato, string nameSpace, string message)
        {
            sMsg = string.Format("{0} {1} - {2}", utenteLoggato, nameSpace, message);
            _log.Verbose(sMsg);
        }

        public static void LogDebug(string utenteLoggato, string nameSpace, string message)
        {
            sMsg = string.Format("{0} {1} - {2}", utenteLoggato, nameSpace, message);
            _log.Error(sMsg);
        }

        public static void LogInformation(string utenteLoggato, string nameSpace, string message)
        {
            sMsg = string.Format("{0} {1} - {2}", utenteLoggato, nameSpace, message);
            _log.Information(sMsg);
        }

        public static void LogWarning(string utenteLoggato, string nameSpace, string message)
        {
            sMsg = string.Format("{0} {1} - {2}", utenteLoggato, nameSpace, message);
            _log.Warning(sMsg);
        }

        public static void LogError(string utenteLoggato, string nameSpace, string message)
        {
            sMsg = string.Format("{0} {1} - {2}", utenteLoggato, nameSpace, message);
            _log.Error(sMsg);
        }
        public static void LogError(string utenteLoggato, string nameSpace, Exception ex)
        {
            string sErr = string.Empty;
            if (ex.InnerException != null)
            {
                sErr = string.Format("Source : {0}{4}Message : {1}{4}StackTrace: {2}{4}InnerException: {3}{4}", ex.Source, ex.Message, ex.StackTrace, ex.InnerException.Message, System.Environment.NewLine);
            }
            else
            {
                sErr = string.Format("Source : {0}{3}Message : {1}{3}StackTrace: {2}{3}", ex.Source, ex.Message, ex.StackTrace, System.Environment.NewLine);

            }
            sMsg = string.Format("{0} {1} - {2}", utenteLoggato, nameSpace, sErr);
            _log.Error(sErr);
        }

        public static void LogFatal(string utenteLoggato, string nameSpace, string message)
        {
            sMsg = string.Format("{0} {1} - {2}", utenteLoggato, nameSpace, message);
            _log.Fatal(sMsg);
        }
        public static void LogFatal(string utenteLoggato, string nameSpace, Exception ex)
        {
            string sErr = string.Empty;
            if (ex.InnerException != null)
            {
                sErr = string.Format("Source : {0}{4}Message : {1}{4}StackTrace: {2}{4}InnerException: {3}{4}", ex.Source, ex.Message, ex.StackTrace, ex.InnerException.Message, System.Environment.NewLine);
            }
            else
            {
                sErr = string.Format("Source : {0}{3}Message : {1}{3}StackTrace: {2}{3}", ex.Source, ex.Message, ex.StackTrace, System.Environment.NewLine);

            }
            sMsg = string.Format("{0} {1} - {2}", utenteLoggato, nameSpace, sErr);
            _log.Fatal(sErr);
        }
    }
}