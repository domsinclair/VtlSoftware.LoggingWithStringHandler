using Metalama.Framework.Fabrics;
using VtlSoftware.Logging.Net6;

namespace VtlSoftware.LoggingConsoleApp
{
    internal class Fabric : ProjectFabric
    {
        #region Public Methods
        public override void AmendProject(IProjectAmender amender) { amender.LogEverything(); }

        #endregion
    }
}
