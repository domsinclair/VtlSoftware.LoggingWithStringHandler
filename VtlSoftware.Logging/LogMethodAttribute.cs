using Metalama.Extensions.DependencyInjection;
using Metalama.Framework.Aspects;
using Microsoft.Extensions.Logging;
using System;

namespace VtlSoftware.Logging
{
    public class LogMethodAttribute : OverrideMethodAspect
    {
        #region Fields

        [IntroduceDependency]
        private readonly ILogger? logger;

        #endregion

        #region Public Methods

        public override dynamic? OverrideMethod()
        {
            try
            {
                var result = meta.Proceed();
                return result;
            } catch(Exception ex)
            {
                throw;
            }
        }

        #endregion
    }
}
