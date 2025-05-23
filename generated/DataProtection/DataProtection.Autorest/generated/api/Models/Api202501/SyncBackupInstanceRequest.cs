// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Sync BackupInstance Request</summary>
    public partial class SyncBackupInstanceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISyncBackupInstanceRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISyncBackupInstanceRequestInternal
    {

        /// <summary>Backing field for <see cref="SyncType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SyncType? _syncType;

        /// <summary>Field indicating sync type e.g. to sync only in case of failure or in all cases</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SyncType? SyncType { get => this._syncType; set => this._syncType = value; }

        /// <summary>Creates an new <see cref="SyncBackupInstanceRequest" /> instance.</summary>
        public SyncBackupInstanceRequest()
        {

        }
    }
    /// Sync BackupInstance Request
    public partial interface ISyncBackupInstanceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>Field indicating sync type e.g. to sync only in case of failure or in all cases</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Field indicating sync type e.g. to sync only in case of failure or in all cases",
        SerializedName = @"syncType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SyncType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SyncType? SyncType { get; set; }

    }
    /// Sync BackupInstance Request
    internal partial interface ISyncBackupInstanceRequestInternal

    {
        /// <summary>Field indicating sync type e.g. to sync only in case of failure or in all cases</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SyncType? SyncType { get; set; }

    }
}