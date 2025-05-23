// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Configuration for defining the transfer of data.</summary>
    public partial class TransferConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferConfigurationInternal
    {

        /// <summary>Backing field for <see cref="TransferAllDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferConfigurationTransferAllDetails _transferAllDetail;

        /// <summary>
        /// Map of filter type and the details to transfer all data. This field is required only if the TransferConfigurationType
        /// is given as TransferAll
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferConfigurationTransferAllDetails TransferAllDetail { get => (this._transferAllDetail = this._transferAllDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.TransferConfigurationTransferAllDetails()); set => this._transferAllDetail = value; }

        /// <summary>Backing field for <see cref="TransferFilterDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferConfigurationTransferFilterDetails _transferFilterDetail;

        /// <summary>
        /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
        /// TransferUsingFilter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferConfigurationTransferFilterDetails TransferFilterDetail { get => (this._transferFilterDetail = this._transferFilterDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.TransferConfigurationTransferFilterDetails()); set => this._transferFilterDetail = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferConfigurationType _type;

        /// <summary>Type of the configuration for transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferConfigurationType Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="TransferConfiguration" /> instance.</summary>
        public TransferConfiguration()
        {

        }
    }
    /// Configuration for defining the transfer of data.
    public partial interface ITransferConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Map of filter type and the details to transfer all data. This field is required only if the TransferConfigurationType
        /// is given as TransferAll
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Map of filter type and the details to transfer all data. This field is required only if the TransferConfigurationType is given as TransferAll",
        SerializedName = @"transferAllDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferConfigurationTransferAllDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferConfigurationTransferAllDetails TransferAllDetail { get; set; }
        /// <summary>
        /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
        /// TransferUsingFilter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as TransferUsingFilter.",
        SerializedName = @"transferFilterDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferConfigurationTransferFilterDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferConfigurationTransferFilterDetails TransferFilterDetail { get; set; }
        /// <summary>Type of the configuration for transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of the configuration for transfer.",
        SerializedName = @"transferConfigurationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferConfigurationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferConfigurationType Type { get; set; }

    }
    /// Configuration for defining the transfer of data.
    internal partial interface ITransferConfigurationInternal

    {
        /// <summary>
        /// Map of filter type and the details to transfer all data. This field is required only if the TransferConfigurationType
        /// is given as TransferAll
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferConfigurationTransferAllDetails TransferAllDetail { get; set; }
        /// <summary>
        /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
        /// TransferUsingFilter.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferConfigurationTransferFilterDetails TransferFilterDetail { get; set; }
        /// <summary>Type of the configuration for transfer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferConfigurationType Type { get; set; }

    }
}