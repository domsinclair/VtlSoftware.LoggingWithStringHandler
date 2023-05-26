
///---- %name%   (%type%) ----
///
// file:	VtlSoftware.Logging.Net6\LoggerExtensions.t.cs
//
// summary:	Implements the logger extensions.t class
///-------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace VtlSoftware.Logging.Net6;

///---- LoggerExtensions   (Class) ----
///
/// <summary>
/// A logger extensions.
/// </summary>
///
/// <remarks></remarks>
///-------------------------------------------------------------------------------------------------

public static partial class LoggerExtensions
{
    #region Public Methods

    ///---- LogCritical   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a critical level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogCritical(
        this ILogger logger,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingCriticalInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogCritical(template, arguments);
        }
    }

    ///---- LogCritical   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a critical level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="eventId">Identifier for the event.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogCritical(
        this ILogger logger,
        EventId eventId,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingCriticalInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogCritical(eventId, template, arguments);
        }
    }

    ///---- LogCritical   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a critical level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogCritical(
        this ILogger logger,
        Exception? exception,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingCriticalInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogCritical(exception, template, arguments);
        }
    }

    ///---- LogCritical   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a critical level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="eventId">Identifier for the event.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogCritical(
        this ILogger logger,
        EventId eventId,
        Exception? exception,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingCriticalInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogCritical(eventId, exception, template, arguments);
        }
    }

    ///---- LogDebug   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a debug level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogDebug(
        this ILogger logger,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingDebugInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogDebug(template, arguments);
        }
    }

    ///---- LogDebug   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a debug level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="eventId">Identifier for the event.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogDebug(
        this ILogger logger,
        EventId eventId,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingDebugInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogDebug(eventId, template, arguments);
        }
    }

    ///---- LogDebug   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a debug level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogDebug(
        this ILogger logger,
        Exception? exception,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingDebugInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogDebug(exception, template, arguments);
        }
    }

    ///---- LogDebug   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a debug level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="eventId">Identifier for the event.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogDebug(
        this ILogger logger,
        EventId eventId,
        Exception? exception,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingDebugInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogDebug(eventId, exception, template, arguments);
        }
    }

    ///---- LogError   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs an error level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogError(
        this ILogger logger,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingErrorInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogError(template, arguments);
        }
    }

    ///---- LogError   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs an error level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="eventId">Identifier for the event.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogError(
        this ILogger logger,
        EventId eventId,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingErrorInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogError(eventId, template, arguments);
        }
    }

    ///---- LogError   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs an error level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogError(
        this ILogger logger,
        Exception? exception,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingErrorInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogError(exception, template, arguments);
        }
    }

    ///---- LogError   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs an error level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="eventId">Identifier for the event.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogError(
        this ILogger logger,
        EventId eventId,
        Exception? exception,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingErrorInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogError(eventId, exception, template, arguments);
        }
    }

    ///---- LogInformation   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs an information level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogInformation(
        this ILogger logger,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingInformationInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogInformation(template, arguments);
        }
    }

    ///---- LogInformation   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs an information level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="eventId">Identifier for the event.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogInformation(
        this ILogger logger,
        EventId eventId,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingInformationInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogInformation(eventId, template, arguments);
        }
    }

    ///---- LogInformation   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs an information level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogInformation(
        this ILogger logger,
        Exception? exception,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingInformationInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogInformation(exception, template, arguments);
        }
    }

    ///---- LogInformation   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs an information level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="eventId">Identifier for the event.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogInformation(
        this ILogger logger,
        EventId eventId,
        Exception? exception,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingInformationInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogInformation(eventId, exception, template, arguments);
        }
    }

    ///---- LogTrace   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a trace level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogTrace(
        this ILogger logger,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingTraceInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogTrace(template, arguments);
        }
    }

    ///---- LogTrace   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a trace level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="eventId">Identifier for the event.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogTrace(
        this ILogger logger,
        EventId eventId,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingTraceInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogTrace(eventId, template, arguments);
        }
    }

    ///---- LogTrace   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a trace level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogTrace(
        this ILogger logger,
        Exception? exception,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingTraceInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogTrace(exception, template, arguments);
        }
    }

    ///---- LogTrace   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a trace level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="eventId">Identifier for the event.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogTrace(
        this ILogger logger,
        EventId eventId,
        Exception? exception,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingTraceInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogTrace(eventId, exception, template, arguments);
        }
    }

    ///---- LogWarning   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a warning level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogWarning(
        this ILogger logger,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingWarningInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogWarning(template, arguments);
        }
    }

    ///---- LogWarning   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a warning level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="eventId">Identifier for the event.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogWarning(
        this ILogger logger,
        EventId eventId,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingWarningInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogWarning(eventId, template, arguments);
        }
    }

    ///---- LogWarning   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a warning level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogWarning(
        this ILogger logger,
        Exception? exception,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingWarningInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogWarning(exception, template, arguments);
        }
    }

    ///---- LogWarning   (Method) ----
    ///
    /// <summary>
    /// An ILogger extension method that logs a warning level message.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="logger">The logger to act on.</param>
    /// <param name="eventId">Identifier for the event.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="handler">[in,out] The handler.</param>
    ///-------------------------------------------------------------------------------------------------

    public static void LogWarning(
        this ILogger logger,
        EventId eventId,
        Exception? exception,
        [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingWarningInterpolatedStringHandler handler)
    {
        if(handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogWarning(eventId, exception, template, arguments);
        }
    }

    #endregion

}
