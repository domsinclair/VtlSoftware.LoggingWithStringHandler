using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace VtlSoftware.Logging.Net6
{
    public static partial class LoggerExtensions
    {
        #region Public Methods

        public static void Log(
            this ILogger logger,
            LogLevel logLevel,
            [InterpolatedStringHandlerArgument("logger", "logLevel")] ref VtlLoggingInterpolatedStringHandler handler)
        {
            if(handler.IsEnabled)
            {
                var (template, arguments) = handler.GetTemplateAndArguments();
                logger.Log(logLevel, template, arguments);
            }
        }

        #endregion
    }
}
