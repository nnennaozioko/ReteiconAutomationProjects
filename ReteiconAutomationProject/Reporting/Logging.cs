using ReteiconAutomationProject.Params;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteiconAutomationProject.Reporting
{
    public class Logging
    {
        LoggingLevelSwitch loggingLevelSwitch;

        public Logging()
        {
            DefaultVariables defaultVariables = new DefaultVariables();
            loggingLevelSwitch = new LoggingLevelSwitch(Serilog.Events.LogEventLevel.Fatal);
            Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(loggingLevelSwitch)
               // .WriteTo.File(@"C:\\Users\\Nelly\\source\\repos\\ReteiconAutomationProjects\\AutomationRunner\\Results\log.txt"
                 .WriteTo.File(defaultVariables.Log
               , outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .Enrich.WithThreadId().CreateLogger();
        }

        public void SetLogLevel(string loglevel)
        {
            switch (loglevel.ToLower())
            {
                case "debug":
                    loggingLevelSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Debug;
                    break;
                case "error":                    
                        loggingLevelSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Error;
                    break;
                case "information":
                    loggingLevelSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Information;
                    break;
                case "fatal":
                    loggingLevelSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Fatal;
                    break;
                 default:
                     loggingLevelSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Debug;
                    break;






            }
        }

        public void Debug(string msg)
        {
            Log.Logger.Debug(msg);
        }

        public void Error(string msg)
        {
            Log.Logger.Error(msg);
        }

        public void Warning(string msg)
        {
            Log.Logger.Warning(msg);
        }

        public void Information(string msg)
        {
            Log.Logger.Information(msg);
        }







    }
}
