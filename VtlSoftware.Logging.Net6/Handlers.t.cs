using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace VtlSoftware.Logging.Net6;

[InterpolatedStringHandler]
public ref struct VtlLoggingTraceInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    public VtlLoggingTraceInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        ILogger logger,
        out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(
            literalLength,
            formattedCount,
            logger,
            LogLevel.Trace,
            out isEnabled);
    }

    #endregion

    #region Public Methods
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    public bool IsEnabled => handler.IsEnabled;

    #endregion
}

[InterpolatedStringHandler]
public ref struct VtlLoggingDebugInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    public VtlLoggingDebugInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        ILogger logger,
        out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(
            literalLength,
            formattedCount,
            logger,
            LogLevel.Debug,
            out isEnabled);
    }

    #endregion

    #region Public Methods
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    public bool IsEnabled => handler.IsEnabled;

    #endregion
}

[InterpolatedStringHandler]
public ref struct VtlLoggingInformationInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    public VtlLoggingInformationInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        ILogger logger,
        out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(
            literalLength,
            formattedCount,
            logger,
            LogLevel.Information,
            out isEnabled);
    }

    #endregion

    #region Public Methods
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    public bool IsEnabled => handler.IsEnabled;

    #endregion
}

[InterpolatedStringHandler]
public ref struct VtlLoggingWarningInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    public VtlLoggingWarningInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        ILogger logger,
        out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(
            literalLength,
            formattedCount,
            logger,
            LogLevel.Warning,
            out isEnabled);
    }

    #endregion

    #region Public Methods
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    public bool IsEnabled => handler.IsEnabled;

    #endregion
}

[InterpolatedStringHandler]
public ref struct VtlLoggingErrorInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    public VtlLoggingErrorInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        ILogger logger,
        out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(
            literalLength,
            formattedCount,
            logger,
            LogLevel.Error,
            out isEnabled);
    }

    #endregion

    #region Public Methods
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    public bool IsEnabled => handler.IsEnabled;

    #endregion
}

[InterpolatedStringHandler]
public ref struct VtlLoggingCriticalInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    public VtlLoggingCriticalInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        ILogger logger,
        out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(
            literalLength,
            formattedCount,
            logger,
            LogLevel.Critical,
            out isEnabled);
    }

    #endregion

    #region Public Methods
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    public bool IsEnabled => handler.IsEnabled;

    #endregion
}
