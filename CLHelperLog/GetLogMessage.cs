﻿namespace CLHelperLog
{
    public static class GetLogMessage
    {
        public static string LogVerbose(string utenteLoggato, string nameSpace, string message)
        {
            return string.Format("{0} - {1} ==> {2}", utenteLoggato, nameSpace, message);
        }

        public static string LogDebug(string utenteLoggato, string nameSpace, string message)
        {
            return string.Format("{0} - {1} ==> {2}", utenteLoggato, nameSpace, message);
        }

        public static string LogInformation(string utenteLoggato, string nameSpace, string message)
        {
            return string.Format("{0} - {1} ==> {2}", utenteLoggato, nameSpace, message);
        }

        public static string LogWarning(string utenteLoggato, string nameSpace, string message)
        {
            return string.Format("{0} - {1} ==> {2}", utenteLoggato, nameSpace, message);
        }

        public static string LogError(string utenteLoggato, string nameSpace, string message)
        {
            return string.Format("{0} - {1} ==> {2}", utenteLoggato, nameSpace, message);
        }

        public static string LogError(string utenteLoggato, string nameSpace, Exception ex)
        {

            string sErr = string.Empty;
            if (ex.InnerException != null)
            {
                sErr = string.Format("Source: {0}{4}Message: {1}{4}StackTrace: {2}{4}InnerException: {3}{4}", ex.Source, ex.Message, ex.StackTrace, ex.InnerException.Message, System.Environment.NewLine);
            }
            else
            {
                sErr = string.Format("Source: {0}{3}Message: {1}{3}StackTrace: {2}{3}", ex.Source, ex.Message, ex.StackTrace, System.Environment.NewLine);
            }
            return string.Format("{0} - {1} ==> {2}", utenteLoggato, nameSpace, sErr);
        }

        public static string LogFatal(string utenteLoggato, string nameSpace, string message)
        {
            return string.Format("{0} - {1} ==> {2}", utenteLoggato, nameSpace, message);
        }

        public static string LogFatal(string utenteLoggato, string nameSpace, Exception ex)
        {

            string sErr = string.Empty;
            if (ex.InnerException != null)
            {
                sErr = string.Format("Source: {0}{4}Message: {1}{4}StackTrace: {2}{4}InnerException: {3}{4}", ex.Source, ex.Message, ex.StackTrace, ex.InnerException.Message, System.Environment.NewLine);
            }
            else
            {
                sErr = string.Format("Source: {0}{3}Message: {1}{3}StackTrace: {2}{3}", ex.Source, ex.Message, ex.StackTrace, System.Environment.NewLine);
            }
            return string.Format("{0} - {1} ==> {2}", utenteLoggato, nameSpace, sErr);
        }
    }
}
