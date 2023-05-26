
///---- %name%   (%type%) ----
///
// file:	VtlSoftware.Logging.Net6\LoggerExtensions.cs
//
// summary:	Implements the logger extensions class
///-------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace VtlSoftware.Logging.Net6
{
    ///---- LoggerExtensions   (Class) ----
    ///
    /// <summary>
    /// Logger extensions.
    /// </summary>
    ///
    /// <remarks>
    /// A collection of extension methods that expand on the Log levels that come with the ILogger from Microsoft
    /// Extensions Logging.
    /// </remarks>
    ///-------------------------------------------------------------------------------------------------

    public static partial class LoggerExtensions
    {
        #region Public Methods
        ///---- Log   (Method) ----
        ///
        /// <summary>
        /// An ILogger extension method that logs.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="logger">The logger to act on.</param>
        /// <param name="logLevel">The log level.</param>
        /// <param name="handler">[in,out] The handler.</param>
        ///-------------------------------------------------------------------------------------------------

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
