
using Serilog;
using System.Web.Mvc;
using System;
using Serilog.Context;

namespace analyze_1.App_Start
{
    public class LoggingConfig
    {
        public static void Register()
        {
            

            Log.Logger = new LoggerConfiguration()
                            .Enrich
                            .WithProperty("Solution","Analyze")
                            .WriteTo.Console()
                .WriteTo.Seq("http://localhost:1080")
                .CreateLogger();
            LogContext.PushProperty("Solution", "Analyze");
        }


        static void LogUnhanldException(object sender, UnhandledExceptionEventArgs args)
        {

            Log.Error("Occur Exception {Exception} ", args.ExceptionObject);
        }
    }
}