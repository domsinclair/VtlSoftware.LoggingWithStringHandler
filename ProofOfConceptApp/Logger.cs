using System.Runtime.CompilerServices;

namespace ProofOfConceptApp
{
    public class Logger
    {
        #region Public Methods

        public void LogMessage(LogLevel level, string msg)
        {
            if(EnabledLevel < level)
                return;
            Console.WriteLine(msg);
        }

        public void LogMessage(
            LogLevel level,
            [InterpolatedStringHandlerArgument("", "level")] LogInterpolatedStringHandler builder)
        {
            if(EnabledLevel < level)
                return;
            Console.WriteLine(builder.GetFormattedText());
        }

        #endregion

        #region Public Properties
        public LogLevel EnabledLevel { get; init; } = LogLevel.Error;

        #endregion
    }
}
