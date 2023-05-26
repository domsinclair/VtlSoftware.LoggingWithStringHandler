
///---- unknown   (unknown) ----
///
/// <summary>
/// ame% (%type%) ----   // file: VtlSoftware.Logging.Net6\Handlers.t.cs // // summary: Implements the handlers.t class.
/// </summary>
///-------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace VtlSoftware.Logging.Net6;

/// <summary>
/// A vtl logging trace interpolated string handler.
/// </summary>

[InterpolatedStringHandler]
public ref struct VtlLoggingTraceInterpolatedStringHandler
{
    /// <summary>
    /// (Immutable) The handler.
    /// </summary>
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    ///---- VtlLoggingTraceInterpolatedStringHandler   (Constructor) ----
    ///
    /// <summary>
    /// Constructor.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="literalLength">Length of the literal.</param>
    /// <param name="formattedCount">Number of formatted.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>
    ///-------------------------------------------------------------------------------------------------

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
    ///---- AppendFormatted<T>   (Method) ----
    ///
    /// <summary>   Appends a formatted. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    /// <param name="value">    The value. </param>
    /// <param name="name">     (Optional) The name. </param>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    ///---- AppendLiteral   (Method) ----
    ///
    /// <summary>
    /// Appends a literal.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="s">The string.</param>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    ///---- GetTemplateAndArguments   (Method) ----
    ///
    /// <summary>
    /// Gets template and arguments.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <returns>The template and arguments.</returns>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    ///---- IsEnabled   (Property) ----
    ///
    /// <summary>
    /// Gets a value indicating whether this object is enabled.
    /// </summary>
    ///
    /// <value>True if this object is enabled, false if not.</value>
    ///-------------------------------------------------------------------------------------------------

    public bool IsEnabled => handler.IsEnabled;

    #endregion

}

///---- VtlLoggingDebugInterpolatedStringHandler   (Struct) ----
///
/// <summary>
/// A vtl logging debug interpolated string handler.
/// </summary>
///
/// <remarks></remarks>
///-------------------------------------------------------------------------------------------------

[InterpolatedStringHandler]
public ref struct VtlLoggingDebugInterpolatedStringHandler
{
    /// <summary>
    /// (Immutable) The handler.
    /// </summary>
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    ///---- VtlLoggingDebugInterpolatedStringHandler   (Constructor) ----
    ///
    /// <summary>
    /// Constructor.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="literalLength">Length of the literal.</param>
    /// <param name="formattedCount">Number of formatted.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>
    ///-------------------------------------------------------------------------------------------------

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
    ///---- AppendFormatted<T>   (Method) ----
    ///
    /// <summary>   Appends a formatted. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    /// <param name="value">    The value. </param>
    /// <param name="name">     (Optional) The name. </param>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    ///---- AppendLiteral   (Method) ----
    ///
    /// <summary>
    /// Appends a literal.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="s">The string.</param>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    ///---- GetTemplateAndArguments   (Method) ----
    ///
    /// <summary>
    /// Gets template and arguments.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <returns>The template and arguments.</returns>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    ///---- IsEnabled   (Property) ----
    ///
    /// <summary>
    /// Gets a value indicating whether this object is enabled.
    /// </summary>
    ///
    /// <value>True if this object is enabled, false if not.</value>
    ///-------------------------------------------------------------------------------------------------

    public bool IsEnabled => handler.IsEnabled;

    #endregion

}

///---- VtlLoggingInformationInterpolatedStringHandler   (Struct) ----
///
/// <summary>
/// A vtl logging information interpolated string handler.
/// </summary>
///
/// <remarks></remarks>
///-------------------------------------------------------------------------------------------------

[InterpolatedStringHandler]
public ref struct VtlLoggingInformationInterpolatedStringHandler
{
    /// <summary>
    /// (Immutable) The handler.
    /// </summary>
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    ///---- VtlLoggingInformationInterpolatedStringHandler   (Constructor) ----
    ///
    /// <summary>
    /// Constructor.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="literalLength">Length of the literal.</param>
    /// <param name="formattedCount">Number of formatted.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>
    ///-------------------------------------------------------------------------------------------------

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
    ///---- AppendFormatted<T>   (Method) ----
    ///
    /// <summary>   Appends a formatted. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    /// <param name="value">    The value. </param>
    /// <param name="name">     (Optional) The name. </param>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    ///---- AppendLiteral   (Method) ----
    ///
    /// <summary>
    /// Appends a literal.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="s">The string.</param>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    ///---- GetTemplateAndArguments   (Method) ----
    ///
    /// <summary>
    /// Gets template and arguments.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <returns>The template and arguments.</returns>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    ///---- IsEnabled   (Property) ----
    ///
    /// <summary>
    /// Gets a value indicating whether this object is enabled.
    /// </summary>
    ///
    /// <value>True if this object is enabled, false if not.</value>
    ///-------------------------------------------------------------------------------------------------

    public bool IsEnabled => handler.IsEnabled;

    #endregion

}

///---- VtlLoggingWarningInterpolatedStringHandler   (Struct) ----
///
/// <summary>
/// A vtl logging warning interpolated string handler.
/// </summary>
///
/// <remarks></remarks>
///-------------------------------------------------------------------------------------------------

[InterpolatedStringHandler]
public ref struct VtlLoggingWarningInterpolatedStringHandler
{
    /// <summary>
    /// (Immutable) The handler.
    /// </summary>
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    ///---- VtlLoggingWarningInterpolatedStringHandler   (Constructor) ----
    ///
    /// <summary>
    /// Constructor.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="literalLength">Length of the literal.</param>
    /// <param name="formattedCount">Number of formatted.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>
    ///-------------------------------------------------------------------------------------------------

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
    ///---- AppendFormatted<T>   (Method) ----
    ///
    /// <summary>   Appends a formatted. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    /// <param name="value">    The value. </param>
    /// <param name="name">     (Optional) The name. </param>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    ///---- AppendLiteral   (Method) ----
    ///
    /// <summary>
    /// Appends a literal.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="s">The string.</param>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    ///---- GetTemplateAndArguments   (Method) ----
    ///
    /// <summary>
    /// Gets template and arguments.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <returns>The template and arguments.</returns>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    ///---- IsEnabled   (Property) ----
    ///
    /// <summary>
    /// Gets a value indicating whether this object is enabled.
    /// </summary>
    ///
    /// <value>True if this object is enabled, false if not.</value>
    ///-------------------------------------------------------------------------------------------------

    public bool IsEnabled => handler.IsEnabled;

    #endregion

}

///---- VtlLoggingErrorInterpolatedStringHandler   (Struct) ----
///
/// <summary>
/// A vtl logging error interpolated string handler.
/// </summary>
///
/// <remarks></remarks>
///-------------------------------------------------------------------------------------------------

[InterpolatedStringHandler]
public ref struct VtlLoggingErrorInterpolatedStringHandler
{
    /// <summary>
    /// (Immutable) The handler.
    /// </summary>
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    ///---- VtlLoggingErrorInterpolatedStringHandler   (Constructor) ----
    ///
    /// <summary>
    /// Constructor.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="literalLength">Length of the literal.</param>
    /// <param name="formattedCount">Number of formatted.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>
    ///-------------------------------------------------------------------------------------------------

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
    ///---- AppendFormatted<T>   (Method) ----
    ///
    /// <summary>   Appends a formatted. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    /// <param name="value">    The value. </param>
    /// <param name="name">     (Optional) The name. </param>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    ///---- AppendLiteral   (Method) ----
    ///
    /// <summary>
    /// Appends a literal.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="s">The string.</param>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    ///---- GetTemplateAndArguments   (Method) ----
    ///
    /// <summary>
    /// Gets template and arguments.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <returns>The template and arguments.</returns>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    ///---- IsEnabled   (Property) ----
    ///
    /// <summary>
    /// Gets a value indicating whether this object is enabled.
    /// </summary>
    ///
    /// <value>True if this object is enabled, false if not.</value>
    ///-------------------------------------------------------------------------------------------------

    public bool IsEnabled => handler.IsEnabled;

    #endregion

}

///---- VtlLoggingCriticalInterpolatedStringHandler   (Struct) ----
///
/// <summary>
/// A vtl logging critical interpolated string handler.
/// </summary>
///
/// <remarks></remarks>
///-------------------------------------------------------------------------------------------------

[InterpolatedStringHandler]
public ref struct VtlLoggingCriticalInterpolatedStringHandler
{
    /// <summary>
    /// (Immutable) The handler.
    /// </summary>
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    ///---- VtlLoggingCriticalInterpolatedStringHandler   (Constructor) ----
    ///
    /// <summary>
    /// Constructor.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="literalLength">Length of the literal.</param>
    /// <param name="formattedCount">Number of formatted.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>
    ///-------------------------------------------------------------------------------------------------

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
    ///---- AppendFormatted<T>   (Method) ----
    ///
    /// <summary>   Appends a formatted. </summary>
    ///
    /// <remarks>    </remarks>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    /// <param name="value">    The value. </param>
    /// <param name="name">     (Optional) The name. </param>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    ///---- AppendLiteral   (Method) ----
    ///
    /// <summary>
    /// Appends a literal.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="s">The string.</param>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    ///---- GetTemplateAndArguments   (Method) ----
    ///
    /// <summary>
    /// Gets template and arguments.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <returns>The template and arguments.</returns>
    ///-------------------------------------------------------------------------------------------------

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    ///---- IsEnabled   (Property) ----
    ///
    /// <summary>
    /// Gets a value indicating whether this object is enabled.
    /// </summary>
    ///
    /// <value>True if this object is enabled, false if not.</value>
    ///-------------------------------------------------------------------------------------------------

    public bool IsEnabled => handler.IsEnabled;

    #endregion

}
