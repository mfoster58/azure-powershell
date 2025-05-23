// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Copy Log Details for customer disk</summary>
    public partial class DataBoxCustomerDiskCopyLogDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxCustomerDiskCopyLogDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxCustomerDiskCopyLogDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICopyLogDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICopyLogDetails __copyLogDetails = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.CopyLogDetails();

        /// <summary>Backing field for <see cref="ErrorLogLink" /> property.</summary>
        private string _errorLogLink;

        /// <summary>Link for copy error logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ErrorLogLink { get => this._errorLogLink; }

        /// <summary>Internal Acessors for ErrorLogLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxCustomerDiskCopyLogDetailsInternal.ErrorLogLink { get => this._errorLogLink; set { {_errorLogLink = value;} } }

        /// <summary>Internal Acessors for SerialNumber</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxCustomerDiskCopyLogDetailsInternal.SerialNumber { get => this._serialNumber; set { {_serialNumber = value;} } }

        /// <summary>Internal Acessors for VerboseLogLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxCustomerDiskCopyLogDetailsInternal.VerboseLogLink { get => this._verboseLogLink; set { {_verboseLogLink = value;} } }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>Disk Serial Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; }

        /// <summary>Indicates the type of job details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICopyLogDetailsInternal)__copyLogDetails).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICopyLogDetailsInternal)__copyLogDetails).Type = value ; }

        /// <summary>Backing field for <see cref="VerboseLogLink" /> property.</summary>
        private string _verboseLogLink;

        /// <summary>Link for copy verbose logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string VerboseLogLink { get => this._verboseLogLink; }

        /// <summary>Creates an new <see cref="DataBoxCustomerDiskCopyLogDetails" /> instance.</summary>
        public DataBoxCustomerDiskCopyLogDetails()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__copyLogDetails), __copyLogDetails);
            await eventListener.AssertObjectIsValid(nameof(__copyLogDetails), __copyLogDetails);
        }
    }
    /// Copy Log Details for customer disk
    public partial interface IDataBoxCustomerDiskCopyLogDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICopyLogDetails
    {
        /// <summary>Link for copy error logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Link for copy error logs.",
        SerializedName = @"errorLogLink",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorLogLink { get;  }
        /// <summary>Disk Serial Number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Disk Serial Number.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get;  }
        /// <summary>Link for copy verbose logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Link for copy verbose logs.",
        SerializedName = @"verboseLogLink",
        PossibleTypes = new [] { typeof(string) })]
        string VerboseLogLink { get;  }

    }
    /// Copy Log Details for customer disk
    internal partial interface IDataBoxCustomerDiskCopyLogDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICopyLogDetailsInternal
    {
        /// <summary>Link for copy error logs.</summary>
        string ErrorLogLink { get; set; }
        /// <summary>Disk Serial Number.</summary>
        string SerialNumber { get; set; }
        /// <summary>Link for copy verbose logs.</summary>
        string VerboseLogLink { get; set; }

    }
}