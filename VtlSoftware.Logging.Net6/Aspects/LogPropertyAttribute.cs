using Metalama.Extensions.DependencyInjection;
using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using Microsoft.Extensions.Logging;

namespace VtlSoftware.Logging.Net6
{
    public class LogPropertyAttribute : OverrideFieldOrPropertyAspect
    {
        #region Fields

        [IntroduceDependency]
        private readonly ILogger logger;

        #endregion

        #region Public Methods
        public override void BuildAspect(IAspectBuilder<IFieldOrProperty> builder)
        {
            if(!(builder.Target.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any() ||
                builder.Target.DeclaringType.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any()))
            {
                builder.Advice.Override(builder.Target, nameof(this.OverrideProperty));
            }
        }

        #endregion

        #region Public Properties
        public override dynamic? OverrideProperty
        {
            get => meta.Proceed();
            set
            {
                var propertyName = $"{meta.Target.Type.ToDisplayString(CodeDisplayFormat.MinimallyQualified)}.{meta.Target.Property.Name}";
                meta.Proceed();
                logger.LogInformation($"The value of {propertyName} was set to: {meta.Target.Property.Value}");
            }
        }

        #endregion
    }
}
