using Metalama.Framework.Aspects;
using Metalama.Framework.Code;

namespace VtlSoftware.Logging.Net6
{
    [CompileTime]
    internal static class SensitiveDataFilter
    {
        #region Public Methods

        public static bool IsSensitive(IParameter parameter)
        {
            bool result = false;
            if(parameter.Attributes.OfAttributeType(typeof(RedactAttribute)).Any())
            {
                result = true;
            }

            return result;
        }

        #endregion
    }
}
