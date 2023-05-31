// <copyright file="FabricExtensions.cs" company="View To Learn / Vtl Software Ltd">
// Copyright (c) 2023 View To Learn / Vtl Software Ltd. All rights reserved.
// </copyright>
// <author> Dom Sinclair </author>
// <date> 31 May 2023 </date>
// <summary> Implements the fabric extensions class </summary>

using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using Metalama.Framework.Fabrics;

namespace VtlSoftware.Logging.Net6
{
    /// <summary>
    /// A fabric extensions.
    /// </summary>
    ///
    /// <remarks></remarks>

    [CompileTime]
    public static class FabricExtensions
    {
        #region Public Methods

        /// <summary>
        /// An IProjectAmender extension method that logs all methods.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void LogAllMethods(this IProjectAmender amender)
        {
            amender.Outbound
            .SelectMany(compilation => compilation.AllTypes)
            .Where(type => !type.IsStatic)
            .SelectMany(type => type.Methods)
            .Where(method => method.Name != "ToString")
            .AddAspectIfEligible<LogMethodAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that logs all public and private methods.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void LogAllPublicAndPrivateMethods(this IProjectAmender amender)
        {
            amender.Outbound
            .SelectMany(compilation => compilation.AllTypes)
            .Where(type => type.Accessibility is Accessibility.Public or Accessibility.Internal && !type.IsStatic)
            .SelectMany(type => type.Methods)
            .Where(
                method => method.Accessibility is Accessibility.Public or Accessibility.Private &&
                    method.Name != "ToString")
            .AddAspectIfEligible<LogMethodAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that logs all public methods.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void LogAllPublicMethods(this IProjectAmender amender)
        {
            amender.Outbound
            .SelectMany(compilation => compilation.AllTypes)
            .Where(
                type => type.Accessibility is Accessibility.Public or Accessibility.Internal &&
                    !type.IsStatic ||
                    type.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any())
            .SelectMany(type => type.Methods)
            .Where(method => method.Accessibility is Accessibility.Public && method.Name != "ToString")
            .AddAspectIfEligible<LogMethodAttribute>();
        }

        /// <summary>
        /// An IProjectAmender extension method that logs an everything.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="amender">The amender to act on.</param>

        public static void LogEverything(this IProjectAmender amender)
        {
            var types = amender.Outbound
            .SelectMany(compilation => compilation.AllTypes)
            .Where(type => !type.IsStatic);
            types.SelectMany(type => type.Methods)
                .Where(method => method.Name != "ToString")
                .AddAspectIfEligible<LogMethodAttribute>();
            types.SelectMany(type => type.Properties)
                .AddAspectIfEligible<LogPropertyAttribute>();
        }

        #endregion
    }
}
