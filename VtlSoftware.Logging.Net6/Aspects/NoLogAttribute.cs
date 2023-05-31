// <copyright file="NoLogAttribute.cs" company="View To Learn / Vtl Software Ltd">
// Copyright (c) 2023 View To Learn / Vtl Software Ltd. All rights reserved.
// </copyright>
// <author> Dom Sinclair </author>
// <date> 31 May 2023 </date>
// <summary> Implements the no log attribute class </summary>

namespace VtlSoftware.Logging.Net6
{
    /// <summary>
    /// Attribute for no log. This class cannot be inherited.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <seealso cref="T:Attribute"/>

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public sealed class NoLogAttribute : Attribute
    {
    }
}
