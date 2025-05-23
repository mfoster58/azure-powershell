// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    /// <summary>Result of the request to list operations.</summary>
    public partial class ResourceProviderOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IResourceProviderOperationList,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IResourceProviderOperationListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IResourceProviderOperationListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to the next set of results, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IResourceProviderOperation> _value;

        /// <summary>List of operations supported by this resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IResourceProviderOperation> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ResourceProviderOperationList" /> instance.</summary>
        public ResourceProviderOperationList()
        {

        }
    }
    /// Result of the request to list operations.
    public partial interface IResourceProviderOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>URL to the next set of results, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"URL to the next set of results, if any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>List of operations supported by this resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of operations supported by this resource provider.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IResourceProviderOperation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IResourceProviderOperation> Value { get; set; }

    }
    /// Result of the request to list operations.
    internal partial interface IResourceProviderOperationListInternal

    {
        /// <summary>URL to the next set of results, if any.</summary>
        string NextLink { get; set; }
        /// <summary>List of operations supported by this resource provider.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IResourceProviderOperation> Value { get; set; }

    }
}