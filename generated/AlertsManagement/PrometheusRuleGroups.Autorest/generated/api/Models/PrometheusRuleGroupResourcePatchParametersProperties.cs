// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Runtime.Extensions;

    public partial class PrometheusRuleGroupResourcePatchParametersProperties :
        Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Models.IPrometheusRuleGroupResourcePatchParametersProperties,
        Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Models.IPrometheusRuleGroupResourcePatchParametersPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>the flag that indicates whether the Prometheus rule group is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Origin(Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>
        /// Creates an new <see cref="PrometheusRuleGroupResourcePatchParametersProperties" /> instance.
        /// </summary>
        public PrometheusRuleGroupResourcePatchParametersProperties()
        {

        }
    }
    public partial interface IPrometheusRuleGroupResourcePatchParametersProperties :
        Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Runtime.IJsonSerializable
    {
        /// <summary>the flag that indicates whether the Prometheus rule group is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the flag that indicates whether the Prometheus rule group is enabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

    }
    internal partial interface IPrometheusRuleGroupResourcePatchParametersPropertiesInternal

    {
        /// <summary>the flag that indicates whether the Prometheus rule group is enabled.</summary>
        bool? Enabled { get; set; }

    }
}