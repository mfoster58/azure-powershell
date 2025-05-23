// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Soft delete related settings</summary>
    public partial class SoftDeleteSettings :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISoftDeleteSettings,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISoftDeleteSettingsInternal
    {

        /// <summary>Backing field for <see cref="RetentionDurationInDay" /> property.</summary>
        private double? _retentionDurationInDay;

        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public double? RetentionDurationInDay { get => this._retentionDurationInDay; set => this._retentionDurationInDay = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? _state;

        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="SoftDeleteSettings" /> instance.</summary>
        public SoftDeleteSettings()
        {

        }
    }
    /// Soft delete related settings
    public partial interface ISoftDeleteSettings :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Soft delete retention duration",
        SerializedName = @"retentionDurationInDays",
        PossibleTypes = new [] { typeof(double) })]
        double? RetentionDurationInDay { get; set; }
        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of soft delete",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? State { get; set; }

    }
    /// Soft delete related settings
    internal partial interface ISoftDeleteSettingsInternal

    {
        /// <summary>Soft delete retention duration</summary>
        double? RetentionDurationInDay { get; set; }
        /// <summary>State of soft delete</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? State { get; set; }

    }
}