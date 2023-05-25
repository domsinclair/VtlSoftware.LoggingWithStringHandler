using System.Runtime.CompilerServices;
using System.Text;

namespace ProofOfConceptApp
{
    [InterpolatedStringHandler]
    public ref struct LogInterpolatedStringHandler
    {
        // Storage for the built-up string
        StringBuilder builder;

        #region Constructors
        //   private readonly bool enabled;

        //NB This required Language level to be set to 11.0  This may cause an issue with metalama.
        public LogInterpolatedStringHandler(
            int literalLength,
            int formattedCount,
            Logger logger,
            LogLevel level,
            out bool isEnabled)
        {
            isEnabled = logger.EnabledLevel >= level;
            Console.WriteLine($"\tliteral length: {literalLength}, formattedCount: {formattedCount}");
            builder = isEnabled ? new StringBuilder(literalLength) : default!;
        }

        #endregion

        internal string GetFormattedText() => builder.ToString();

        #region Public Methods
        public void AppendFormatted<T>(T t)
        {
            Console.WriteLine($"\tAppendFormatted called: {{{t}}} is of type {typeof(T)}");
            //if(!enabled)
            //    return;

            builder.Append(t?.ToString());
            Console.WriteLine($"\tAppended the formatted object");
        }

        public void AppendFormatted<T>(T t, string format) where T : IFormattable
        {
            Console.WriteLine(
                $"\tAppendFormatted (IFormattable version) called: {t} with format {{{format}}} is of type {typeof(T)},");

            builder.Append(t?.ToString(format, null));
            Console.WriteLine($"\tAppended the formatted object");
        }

        public void AppendLiteral(string s)
        {
            Console.WriteLine($"\tAppendLiteral called: {{{s}}}");
            //if(!enabled)
            //    return;

            builder.Append(s);
            Console.WriteLine($"\tAppended the literal string");
        }

        #endregion
    }
}
