// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties required to create an edgenode.</summary>
    public partial class EdgeNodeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IEdgeNodeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IEdgeNodePropertiesInternal
    {

        /// <summary>Backing field for <see cref="IPAddressGroup" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IIPAddressGroup> _iPAddressGroup;

        /// <summary>List of ip address groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IIPAddressGroup> IPAddressGroup { get => this._iPAddressGroup; set => this._iPAddressGroup = value; }

        /// <summary>Creates an new <see cref="EdgeNodeProperties" /> instance.</summary>
        public EdgeNodeProperties()
        {

        }
    }
    /// The JSON object that contains the properties required to create an edgenode.
    public partial interface IEdgeNodeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>List of ip address groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of ip address groups.",
        SerializedName = @"ipAddressGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IIPAddressGroup) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IIPAddressGroup> IPAddressGroup { get; set; }

    }
    /// The JSON object that contains the properties required to create an edgenode.
    internal partial interface IEdgeNodePropertiesInternal

    {
        /// <summary>List of ip address groups.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IIPAddressGroup> IPAddressGroup { get; set; }

    }
}