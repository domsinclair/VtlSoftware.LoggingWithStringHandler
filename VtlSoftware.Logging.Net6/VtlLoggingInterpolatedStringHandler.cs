using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Text;

namespace VtlSoftware.Logging.Net6
{
    [InterpolatedStringHandler]
    public ref struct VtlLoggingInterpolatedStringHandler
    {
        private readonly StringBuilder template = null!;
        private readonly ArgumentList arguments = null!;

        #region Constructors
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
        public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "")
        {
            if(!IsEnabled)
                return;

            arguments.Add(value);
            template.Append($"{{@{name}}}");
        }

        public void AppendLiteral(string s)
        {
            if(!IsEnabled)
                return;

            template.Append(s.Replace("{", "{{", StringComparison.Ordinal).Replace("}", "}}", StringComparison.Ordinal));
        }

        public (string, object?[]) GetTemplateAndArguments() => (template.ToString(), arguments.Arguments);

        #endregion

        #region Public Properties
        public bool IsEnabled { get; }

        #endregion

        private class ArgumentList
        {
            #region Fields

            private int _index;

            #endregion

            #region Constructors
            public ArgumentList(int formattedCount) => Arguments = new object?[formattedCount];

            #endregion

            #region Public Methods
            public void Add(object? value) => Arguments[_index++] = value;

            #endregion

            #region Public Properties
            public object?[] Arguments { get; }

            #endregion
        }
    }
}
