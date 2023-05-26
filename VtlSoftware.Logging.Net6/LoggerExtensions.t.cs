using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace VtlSoftware.Logging.Net6;

public static partial class LoggerExtensions
{
    #region Public Methods

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
