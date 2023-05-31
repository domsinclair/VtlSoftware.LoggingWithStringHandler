using System.Runtime.CompilerServices;
namespace VtlSoftware.Logging.Net6;

/// <summary>   A vtl logging Trace interpolated string handler. </summary>
///
/// <remarks>    </remarks>

[InterpolatedStringHandler]
public ref struct VtlLoggingTraceInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;


    /// <summary>   Constructor. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="literalLength">    Length of the literal. </param>
    /// <param name="formattedCount">   Number of formatted. </param>
    /// <param name="logger">           The logger. </param>
    /// <param name="isEnabled">        [out] True if is enabled, false if not. </param>

    public VtlLoggingTraceInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Trace, out isEnabled);
    }

    /// <summary>   Gets a value indicating whether this object is enabled. </summary>
    ///
    /// <value> True if this object is enabled, false if not. </value>

    public bool IsEnabled => handler.IsEnabled;


    /// <summary>   Appends a literal string. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="s">    The string. </param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);


    /// <summary>   Appends a formatted Types. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    /// <param name="value">    The value. </param>
    /// <param name="name">     (Optional) The name. </param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(value, name);


    /// <summary>   Gets template and arguments. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <returns>   The template and arguments. </returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();
}
/// <summary>   A vtl logging Debug interpolated string handler. </summary>
///
/// <remarks>    </remarks>

[InterpolatedStringHandler]
public ref struct VtlLoggingDebugInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;


    /// <summary>   Constructor. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="literalLength">    Length of the literal. </param>
    /// <param name="formattedCount">   Number of formatted. </param>
    /// <param name="logger">           The logger. </param>
    /// <param name="isEnabled">        [out] True if is enabled, false if not. </param>

    public VtlLoggingDebugInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Debug, out isEnabled);
    }

    /// <summary>   Gets a value indicating whether this object is enabled. </summary>
    ///
    /// <value> True if this object is enabled, false if not. </value>

    public bool IsEnabled => handler.IsEnabled;


    /// <summary>   Appends a literal string. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="s">    The string. </param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);


    /// <summary>   Appends a formatted Types. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    /// <param name="value">    The value. </param>
    /// <param name="name">     (Optional) The name. </param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(value, name);


    /// <summary>   Gets template and arguments. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <returns>   The template and arguments. </returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();
}
/// <summary>   A vtl logging Information interpolated string handler. </summary>
///
/// <remarks>    </remarks>

[InterpolatedStringHandler]
public ref struct VtlLoggingInformationInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;


    /// <summary>   Constructor. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="literalLength">    Length of the literal. </param>
    /// <param name="formattedCount">   Number of formatted. </param>
    /// <param name="logger">           The logger. </param>
    /// <param name="isEnabled">        [out] True if is enabled, false if not. </param>

    public VtlLoggingInformationInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Information, out isEnabled);
    }

    /// <summary>   Gets a value indicating whether this object is enabled. </summary>
    ///
    /// <value> True if this object is enabled, false if not. </value>

    public bool IsEnabled => handler.IsEnabled;


    /// <summary>   Appends a literal string. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="s">    The string. </param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);


    /// <summary>   Appends a formatted Types. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    /// <param name="value">    The value. </param>
    /// <param name="name">     (Optional) The name. </param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(value, name);


    /// <summary>   Gets template and arguments. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <returns>   The template and arguments. </returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();
}
/// <summary>   A vtl logging Warning interpolated string handler. </summary>
///
/// <remarks>    </remarks>

[InterpolatedStringHandler]
public ref struct VtlLoggingWarningInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;


    /// <summary>   Constructor. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="literalLength">    Length of the literal. </param>
    /// <param name="formattedCount">   Number of formatted. </param>
    /// <param name="logger">           The logger. </param>
    /// <param name="isEnabled">        [out] True if is enabled, false if not. </param>

    public VtlLoggingWarningInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Warning, out isEnabled);
    }

    /// <summary>   Gets a value indicating whether this object is enabled. </summary>
    ///
    /// <value> True if this object is enabled, false if not. </value>

    public bool IsEnabled => handler.IsEnabled;


    /// <summary>   Appends a literal string. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="s">    The string. </param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);


    /// <summary>   Appends a formatted Types. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    /// <param name="value">    The value. </param>
    /// <param name="name">     (Optional) The name. </param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(value, name);


    /// <summary>   Gets template and arguments. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <returns>   The template and arguments. </returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();
}
/// <summary>   A vtl logging Error interpolated string handler. </summary>
///
/// <remarks>    </remarks>

[InterpolatedStringHandler]
public ref struct VtlLoggingErrorInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;


    /// <summary>   Constructor. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="literalLength">    Length of the literal. </param>
    /// <param name="formattedCount">   Number of formatted. </param>
    /// <param name="logger">           The logger. </param>
    /// <param name="isEnabled">        [out] True if is enabled, false if not. </param>

    public VtlLoggingErrorInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Error, out isEnabled);
    }

    /// <summary>   Gets a value indicating whether this object is enabled. </summary>
    ///
    /// <value> True if this object is enabled, false if not. </value>

    public bool IsEnabled => handler.IsEnabled;


    /// <summary>   Appends a literal string. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="s">    The string. </param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);


    /// <summary>   Appends a formatted Types. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    /// <param name="value">    The value. </param>
    /// <param name="name">     (Optional) The name. </param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(value, name);


    /// <summary>   Gets template and arguments. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <returns>   The template and arguments. </returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();
}
/// <summary>   A vtl logging Critical interpolated string handler. </summary>
///
/// <remarks>    </remarks>

[InterpolatedStringHandler]
public ref struct VtlLoggingCriticalInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;


    /// <summary>   Constructor. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="literalLength">    Length of the literal. </param>
    /// <param name="formattedCount">   Number of formatted. </param>
    /// <param name="logger">           The logger. </param>
    /// <param name="isEnabled">        [out] True if is enabled, false if not. </param>

    public VtlLoggingCriticalInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Critical, out isEnabled);
    }

    /// <summary>   Gets a value indicating whether this object is enabled. </summary>
    ///
    /// <value> True if this object is enabled, false if not. </value>

    public bool IsEnabled => handler.IsEnabled;


    /// <summary>   Appends a literal string. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <param name="s">    The string. </param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);


    /// <summary>   Appends a formatted Types. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    /// <param name="value">    The value. </param>
    /// <param name="name">     (Optional) The name. </param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(value, name);


    /// <summary>   Gets template and arguments. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <returns>   The template and arguments. </returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();
}
