
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Purchase `ReservationOrder` and purchase resource under the specified URI.
.Description
Purchase `ReservationOrder` and purchase resource under the specified URI.
.Example
New-AzReservation -AppliedScopeType 'Shared' -BillingPlan 'Upfront' -billingScopeId '/subscriptions/b0f278e1-1f18-4378-84d7-b44dfa708665' -DisplayName 'TestVm2222' -Location 'westus' -Quantity 1 -ReservedResourceType 'VirtualMachines' -Sku 'Standard_b1ls' -Term 'P1Y' -ReservationOrderId '846655fa-d9e7-4fb8-9512-3ab7367352f1'

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponse
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IReservationsIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [ReservationId <String>]: Id of the reservation item
  [ReservationOrderId <String>]: Order Id of the reservation
  [SubscriptionId <String>]: Id of the subscription
.Link
https://learn.microsoft.com/powershell/module/az.reservations/new-azreservation
#>
function New-AzReservation {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponse])]
[CmdletBinding(DefaultParameterSetName='PurchaseExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='PurchaseExpanded', Mandatory)]
    [Parameter(ParameterSetName='PurchaseViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='PurchaseViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Path')]
    [System.String]
    # Order Id of the reservation
    ${ReservationOrderId},

    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String[]]
    # List of the subscriptions that the benefit will be applied.
    # Do not specify if AppliedScopeType is Shared.
    # This property will be deprecated and replaced by appliedScopeProperties instead for Single AppliedScopeType.
    ${AppliedScope},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Display name
    ${AppliedScopePropertyDisplayName},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Fully-qualified identifier of the management group where the benefit must be applied.
    ${AppliedScopePropertyManagementGroupId},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Fully-qualified identifier of the resource group.
    ${AppliedScopePropertyResourceGroupId},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Fully-qualified identifier of the subscription.
    ${AppliedScopePropertySubscriptionId},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Tenant ID where the savings plan should apply benefit.
    ${AppliedScopePropertyTenantId},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.PSArgumentCompleterAttribute("Single", "Shared", "ManagementGroup")]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Type of the Applied Scope.
    ${AppliedScopeType},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.PSArgumentCompleterAttribute("Upfront", "Monthly")]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Represent the billing plans.
    ${BillingPlan},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Subscription that will be charged for purchasing reservation or savings plan
    ${BillingScopeId},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Friendly name of the reservation
    ${DisplayName},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.PSArgumentCompleterAttribute("On", "Off")]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Turning this on will apply the reservation discount to other VMs in the same VM size group.
    # Only specify for VirtualMachines reserved resource type.
    ${InstanceFlexibility},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # The Azure region where the reserved resource lives.
    ${Location},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.Int32]
    # Quantity of the skus that are part of the reservation.
    ${Quantity},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Setting this to true will automatically purchase a new reservation on the expiration date time.
    ${Renew},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.PSArgumentCompleterAttribute("VirtualMachines", "SqlDatabases", "SuseLinux", "CosmosDb", "RedHat", "SqlDataWarehouse", "VMwareCloudSimple", "RedHatOsa", "Databricks", "AppService", "ManagedDisk", "BlockBlob", "RedisCache", "AzureDataExplorer", "MySql", "MariaDb", "PostgreSql", "DedicatedHost", "SapHana", "SqlAzureHybridBenefit", "AVS", "DataFactory", "NetAppStorage", "AzureFiles", "SqlEdge", "VirtualMachineSoftware")]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # The type of the resource that is being reserved.
    ${ReservedResourceType},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.DateTime]
    # This is the date-time when the Azure hybrid benefit needs to be reviewed.
    ${ReviewDateTime},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # .
    ${Sku},

    [Parameter(ParameterSetName='PurchaseExpanded')]
    [Parameter(ParameterSetName='PurchaseViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.PSArgumentCompleterAttribute("P1Y", "P3Y", "P5Y")]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Represent the term of reservation.
    ${Term},

    [Parameter(ParameterSetName='PurchaseViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Purchase operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='PurchaseViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
    [System.String]
    # Json string supplied to the Purchase operation
    ${JsonString},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $context = Get-AzContext
        if (-not $context -and -not $testPlayback) {
            Write-Error "No Azure login detected. Please run 'Connect-AzAccount' to log in."
            exit
        }

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.Reservations.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            PurchaseExpanded = 'Az.Reservations.private\New-AzReservation_PurchaseExpanded';
            PurchaseViaIdentityExpanded = 'Az.Reservations.private\New-AzReservation_PurchaseViaIdentityExpanded';
            PurchaseViaJsonFilePath = 'Az.Reservations.private\New-AzReservation_PurchaseViaJsonFilePath';
            PurchaseViaJsonString = 'Az.Reservations.private\New-AzReservation_PurchaseViaJsonString';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.Reservations.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
