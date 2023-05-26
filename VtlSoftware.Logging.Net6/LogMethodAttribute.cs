using Metalama.Extensions.DependencyInjection;
using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using Microsoft.Extensions.Logging;

namespace VtlSoftware.Logging.Net6
{
    public class LogMethodAttribute : OverrideMethodAspect
    {
        #region Fields

        [IntroduceDependency]
        private readonly ILogger logger;

        #endregion

        #region Public Methods
        public override dynamic? OverrideMethod()
        {
            var methodName = meta.Target.Method.Name;
            //add a check to see if we do actually want to do any logging at all
            var isTracingEnabled = this.logger.IsEnabled(LogLevel.Trace);

            //now we want to add an entry message.

            if(isTracingEnabled)
            {
                if(meta.Target.Parameters.Count == 0)
                {
                    logger.LogInformation($"Entering {methodName}");
                } else
                {
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    foreach(var p in meta.Target.Parameters)
                    {
                        if(p.RefKind != RefKind.Out)
                        {
                            parameters.Add($"{p.Type} {p.Name}", p.Value);
                        } else
                        {
                            //Metalame can't serialise an out parameter but it would help if we know it's there.
                            parameters.Add(p.Name, " = <out>");
                        }
                    }
                    logger.LogInformation($"Entering {methodName} with these parameters: {parameters}");
                }
            }
            try
            {
                var result = meta.Proceed();
                if(isTracingEnabled)
                {
                    // Display the success message. The message is different when the method is void.

                    if(meta.Target.Method.ReturnType.Is(typeof(void)))
                    {
                        logger.LogInformation($"Leaving {methodName}.");
                    } else
                    {
                        logger.LogInformation($"Leaving {methodName} with {result}");
                    }
                }
                return result;
            } catch(Exception e)
            {
                logger.LogError($"An error has occured in {methodName} with the following message {e.StackTrace}");
                throw;
            }
        }

        #endregion
    }
}
