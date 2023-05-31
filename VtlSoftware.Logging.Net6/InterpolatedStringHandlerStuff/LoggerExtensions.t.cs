using System.Runtime.CompilerServices;
namespace VtlSoftware.Logging.Net6;

/// <summary>   A collection of logger extension methods. </summary>
///
/// <remarks>    </remarks>

public static  class LoggerExtensions
{

    /// <summary>   An ILogger extension method that logs. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="logLevel"> The log level. </param>
    /// <param name="handler">  [in,out] The handler. </param>

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


    

    /// <summary>   An ILogger extension method that logs a Trace level message. </summary> 
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="handler">  [in,out] The handler. </param>

    public static void LogTrace(this ILogger logger, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingTraceInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogTrace(template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs a Trace level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="eventId">  Identifier for the event. </param>
    /// <param name="handler">  [in,out] The handler. </param>

    public static void LogTrace(this ILogger logger, EventId eventId, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingTraceInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogTrace(eventId, template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs a Trace level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">       The logger to act on. </param>
    /// <param name="exception">    The exception. </param>
    /// <param name="handler">      [in,out] The handler. </param>

    public static void LogTrace(this ILogger logger, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingTraceInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogTrace(exception, template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs a Trace level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">       The logger to act on. </param>
    /// <param name="eventId">      Identifier for the event. </param>
    /// <param name="exception">    The exception. </param>
    /// <param name="handler">      [in,out] The handler. </param>

    public static void LogTrace(this ILogger logger, EventId eventId, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingTraceInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogTrace(eventId, exception, template, arguments);
        }
    }



    

    /// <summary>   An ILogger extension method that logs a Debug level message. </summary> 
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="handler">  [in,out] The handler. </param>

    public static void LogDebug(this ILogger logger, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingDebugInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogDebug(template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs a Debug level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="eventId">  Identifier for the event. </param>
    /// <param name="handler">  [in,out] The handler. </param>

    public static void LogDebug(this ILogger logger, EventId eventId, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingDebugInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogDebug(eventId, template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs a Debug level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">       The logger to act on. </param>
    /// <param name="exception">    The exception. </param>
    /// <param name="handler">      [in,out] The handler. </param>

    public static void LogDebug(this ILogger logger, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingDebugInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogDebug(exception, template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs a Debug level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">       The logger to act on. </param>
    /// <param name="eventId">      Identifier for the event. </param>
    /// <param name="exception">    The exception. </param>
    /// <param name="handler">      [in,out] The handler. </param>

    public static void LogDebug(this ILogger logger, EventId eventId, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingDebugInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogDebug(eventId, exception, template, arguments);
        }
    }



    
    /// <summary>   An ILogger extension method that logs an Information level message. </summary> 
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="handler">  [in,out] The handler. </param>

    public static void LogInformation(this ILogger logger, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingInformationInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogInformation(template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs an Information level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="eventId">  Identifier for the event. </param>
    /// <param name="handler">  [in,out] The handler. </param>

    public static void LogInformation(this ILogger logger, EventId eventId, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingInformationInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogInformation(eventId, template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs an Information level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">       The logger to act on. </param>
    /// <param name="exception">    The exception. </param>
    /// <param name="handler">      [in,out] The handler. </param>

    public static void LogInformation(this ILogger logger, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingInformationInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogInformation(exception, template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs an Information level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">       The logger to act on. </param>
    /// <param name="eventId">      Identifier for the event. </param>
    /// <param name="exception">    The exception. </param>
    /// <param name="handler">      [in,out] The handler. </param>

    public static void LogInformation(this ILogger logger, EventId eventId, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingInformationInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogInformation(eventId, exception, template, arguments);
        }
    }

    /// <summary>   An ILogger extension method that logs a Warning level message. </summary> 
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="handler">  [in,out] The handler. </param>

    public static void LogWarning(this ILogger logger, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingWarningInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogWarning(template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs a Warning level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="eventId">  Identifier for the event. </param>
    /// <param name="handler">  [in,out] The handler. </param>

    public static void LogWarning(this ILogger logger, EventId eventId, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingWarningInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogWarning(eventId, template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs a Warning level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">       The logger to act on. </param>
    /// <param name="exception">    The exception. </param>
    /// <param name="handler">      [in,out] The handler. </param>

    public static void LogWarning(this ILogger logger, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingWarningInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogWarning(exception, template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs a Warning level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">       The logger to act on. </param>
    /// <param name="eventId">      Identifier for the event. </param>
    /// <param name="exception">    The exception. </param>
    /// <param name="handler">      [in,out] The handler. </param>

    public static void LogWarning(this ILogger logger, EventId eventId, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingWarningInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogWarning(eventId, exception, template, arguments);
        }
    }



    
    /// <summary>   An ILogger extension method that logs an Error level message. </summary> 
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="handler">  [in,out] The handler. </param>

    public static void LogError(this ILogger logger, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingErrorInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogError(template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs an Error level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="eventId">  Identifier for the event. </param>
    /// <param name="handler">  [in,out] The handler. </param>

    public static void LogError(this ILogger logger, EventId eventId, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingErrorInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogError(eventId, template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs an Error level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">       The logger to act on. </param>
    /// <param name="exception">    The exception. </param>
    /// <param name="handler">      [in,out] The handler. </param>

    public static void LogError(this ILogger logger, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingErrorInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogError(exception, template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs an Error level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">       The logger to act on. </param>
    /// <param name="eventId">      Identifier for the event. </param>
    /// <param name="exception">    The exception. </param>
    /// <param name="handler">      [in,out] The handler. </param>

    public static void LogError(this ILogger logger, EventId eventId, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingErrorInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogError(eventId, exception, template, arguments);
        }
    }

    /// <summary>   An ILogger extension method that logs a Critical level message. </summary> 
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="handler">  [in,out] The handler. </param>

    public static void LogCritical(this ILogger logger, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingCriticalInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogCritical(template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs a Critical level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">   The logger to act on. </param>
    /// <param name="eventId">  Identifier for the event. </param>
    /// <param name="handler">  [in,out] The handler. </param>

    public static void LogCritical(this ILogger logger, EventId eventId, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingCriticalInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogCritical(eventId, template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs a Critical level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">       The logger to act on. </param>
    /// <param name="exception">    The exception. </param>
    /// <param name="handler">      [in,out] The handler. </param>

    public static void LogCritical(this ILogger logger, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingCriticalInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogCritical(exception, template, arguments);
        }
    }


    /// <summary>   An ILogger extension method that logs a Critical level message. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="logger">       The logger to act on. </param>
    /// <param name="eventId">      Identifier for the event. </param>
    /// <param name="exception">    The exception. </param>
    /// <param name="handler">      [in,out] The handler. </param>

    public static void LogCritical(this ILogger logger, EventId eventId, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref VtlLoggingCriticalInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogCritical(eventId, exception, template, arguments);
        }
    }



    }