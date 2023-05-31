// <copyright file="VtlLoggingInterpolatedStringHandler.cs" company="View To Learn / Vtl Software Ltd">
// Copyright (c) 2023 View To Learn / Vtl Software Ltd. All rights reserved.
// </copyright>
// <author> Dom Sinclair </author>
// <date>30 May 2023</date>
// <summary>Implements the vtl logging interpolated string handler class</summary>

using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Text;

namespace VtlSoftware.Logging.Net6
{
    /// <summary>
    /// A vtl logging interpolated string handler.
    /// </summary>
    ///
    /// <remarks></remarks>

    [InterpolatedStringHandler]
    public readonly ref struct VtlLoggingInterpolatedStringHandler
    {
        /// <summary>
        /// (Immutable) The template.
        /// </summary>
        private readonly StringBuilder template = null!;

        /// <summary>
        /// (Immutable) The arguments.
        /// </summary>
        private readonly ArgumentList arguments = null!;

        #region Constructors
        /// <summary>
        /// Constructor.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="literalLength">Length of the literal.</param>
        /// <param name="formattedCount">Number of formatted.</param>
        /// <param name="logger">The logger.</param>
        /// <param name="logLevel">The log level.</param>
        /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>

        public VtlLoggingInterpolatedStringHandler(
            int literalLength,
            int formattedCount,
            ILogger logger,
            LogLevel logLevel,
            out bool isEnabled)
        {
            IsEnabled = isEnabled = logger.IsEnabled(logLevel);
            if(isEnabled)
            {
                template = new(literalLength + 20 * formattedCount);
                arguments = new(formattedCount);
            }
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Appends a formatted.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="name">(Optional) The name.</param>

        public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "")
        {
            if(!IsEnabled)
                return;

            arguments.Add(value);
            template.Append($"{{@{name}}}");
        }

        /// <summary>
        /// Appends a literal.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="s">The string.</param>

        public void AppendLiteral(string s)
        {
            if(!IsEnabled)
                return;

            template.Append(s.Replace("{", "{{", StringComparison.Ordinal).Replace("}", "}}", StringComparison.Ordinal));
        }

        /// <summary>
        /// Gets template and arguments.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <returns>The template and arguments.</returns>

        public (string, object?[]) GetTemplateAndArguments() => (template.ToString(), arguments.Arguments);

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets a value indicating whether this object is enabled.
        /// </summary>
        ///
        /// <value>True if this object is enabled, false if not.</value>

        public bool IsEnabled { get; }

        #endregion

        /// <summary>
        /// List of arguments.
        /// </summary>
        ///
        /// <remarks></remarks>

        private class ArgumentList
        {
            #region Fields

            /// <summary>
            /// Zero-based index of the.
            /// </summary>
            private int _index;

            #endregion

            #region Constructors
            /// <summary>
            /// Constructor.
            /// </summary>
            ///
            /// <remarks></remarks>
            ///
            /// <param name="formattedCount">Number of formatted.</param>

            public ArgumentList(int formattedCount) => Arguments = new object?[formattedCount];

            #endregion

            #region Public Methods
            /// <summary>
            /// Adds value.
            /// </summary>
            ///
            /// <remarks></remarks>
            ///
            /// <param name="value">The value to add.</param>

            public void Add(object? value) => Arguments[_index++] = value;

            #endregion

            #region Public Properties
            /// <summary>
            /// Gets the arguments.
            /// </summary>
            ///
            /// <value>The arguments.</value>

            public object?[] Arguments { get; }

            #endregion
        }
    }
}
