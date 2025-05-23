﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Azure.Commands.CosmosDB.Helpers;
using Microsoft.Azure.Commands.CosmosDB.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.CosmosDB.Models;
using SDKModel = Microsoft.Azure.Management.CosmosDB.Models;

namespace Microsoft.Azure.Commands.CosmosDB
{
    public class NewOrUpdateAzCosmosDBAccount : AzureCosmosDBCmdletBase
    {
        [Parameter(Mandatory = true, ParameterSetName = NameParameterSet, HelpMessage = Constants.ResourceGroupNameHelpMessage)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = NameParameterSet, HelpMessage = Constants.AccountNameHelpMessage)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.DefaultConsistencyLevelHelpMessage)]
        [PSArgumentCompleter("BoundedStaleness", "ConsistentPrefix", "Eventual", "Session", "Strong")]
        public string DefaultConsistencyLevel { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.IpRulesHelpMessage)]
        [ValidateNotNull]
        public string[] IpRule { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.MaxStalenessIntervalInSecondsHelpMessage)]
        public int? MaxStalenessIntervalInSeconds { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.MaxStalenessPrefixHelpMessage)]
        public int? MaxStalenessPrefix { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.TagHelpMessage)]
        [ValidateNotNull]
        public Hashtable Tag { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.VirtualNetworkRuleHelpMessage)]
        [ValidateNotNullOrEmpty]
        public string[] VirtualNetworkRule { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.VirtualNetworkRuleObjectHelpMessage)]
        [ValidateNotNullOrEmpty]
        public PSVirtualNetworkRule[] VirtualNetworkRuleObject { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.PublicNetworkAccessHelpMessage)]
        [PSArgumentCompleter(SDKModel.PublicNetworkAccess.Disabled, SDKModel.PublicNetworkAccess.Enabled)]
        public string PublicNetworkAccess { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.KeyVaultUriHelpMessage)]
        public string KeyVaultKeyUri { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.EnableAnalyticalStorageHelpMessage)]
        public bool? EnableAnalyticalStorage { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.EnablePartitionMergeHelpMessage)]
        public bool? EnablePartitionMerge { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.EnableBurstCapacityHelpMessage)]
        public bool? EnableBurstCapacity { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.AsJobHelpMessage)]
        public SwitchParameter AsJob { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.NetworkAclBypassHelpMessage)]
        [PSArgumentCompleter("None", "AzureServices")]
        public string NetworkAclBypass { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.NetworkAclBypassResourceIdHelpMessage)]
        [ValidateNotNullOrEmpty]
        public string[] NetworkAclBypassResourceId { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.ServerVersionHelpMessage)]
        [PSArgumentCompleter(SDKModel.ServerVersion.Three2, SDKModel.ServerVersion.Three6, SDKModel.ServerVersion.Four0)]
        public string ServerVersion { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.BackupIntervalInMinHelpMessage)]
        public int? BackupIntervalInMinutes { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.BackupRetentionInHoursHelpMessage)]
        public int? BackupRetentionIntervalInHours { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.BackupStorageRedundancyHelpMessage)]
        [PSArgumentCompleter("Geo", "Local", "Zone")]
        public string BackupStorageRedundancy { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.BackupTypeHelpMessage)]
        [PSArgumentCompleter("Periodic", "Continuous")]
        public string BackupPolicyType { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.ContinuousTierHelpMessage)]
        [PSArgumentCompleter("Continuous7Days", "Continuous30Days")]
        public string ContinuousTier { get; set; }
        
        [Parameter(Mandatory = false, HelpMessage = Constants.AnalyticalStorageSchemaTypeHelpMessage)]
        [PSArgumentCompleter(SDKModel.AnalyticalStorageSchemaType.WellDefined, SDKModel.AnalyticalStorageSchemaType.FullFidelity)]
        public string AnalyticalStorageSchemaType { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.MinimalTlsVersionHelpMessage)]
        [PSArgumentCompleter(SDKModel.MinimalTlsVersion.Tls, SDKModel.MinimalTlsVersion.Tls11, SDKModel.MinimalTlsVersion.Tls12)]
        public string MinimalTlsVersion { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.EnablePerRegionPerPartitionAutoscaleHelpMessage)]
        public bool? EnablePerRegionPerPartitionAutoscale { get; set; }

        public ConsistencyPolicy PopoulateConsistencyPolicy(string DefaultConsistencyLevel, int? MaxStalenessIntervalInSeconds, int? MaxStalenessPrefix)
        {
            ConsistencyPolicy consistencyPolicy = new ConsistencyPolicy();
            {
                switch (DefaultConsistencyLevel)
                {
                    case "Strong":
                        consistencyPolicy.DefaultConsistencyLevel = SDKModel.DefaultConsistencyLevel.Strong;
                        break;

                    case "Session":
                        consistencyPolicy.DefaultConsistencyLevel = SDKModel.DefaultConsistencyLevel.Session;
                        break;

                    case "Eventual":
                        consistencyPolicy.DefaultConsistencyLevel = SDKModel.DefaultConsistencyLevel.Eventual;
                        break;

                    case "ConsistentPrefix":
                        consistencyPolicy.DefaultConsistencyLevel = SDKModel.DefaultConsistencyLevel.ConsistentPrefix;
                        break;

                    case "BoundedStaleness":
                        consistencyPolicy.DefaultConsistencyLevel = SDKModel.DefaultConsistencyLevel.BoundedStaleness;
                        consistencyPolicy.MaxIntervalInSeconds = MaxStalenessIntervalInSeconds;
                        consistencyPolicy.MaxStalenessPrefix = MaxStalenessPrefix;
                        break;

                    default:
                        consistencyPolicy.DefaultConsistencyLevel = SDKModel.DefaultConsistencyLevel.Session;
                        break;
                }
            }
            return consistencyPolicy;
        }

        public Dictionary<string, string> PopulateTags(Hashtable Tag)
        {
            Dictionary<string, string> tags = new Dictionary<string, string>();
            foreach (string key in Tag.Keys)
            {
                tags.Add(key, Tag[key].ToString());
            }
            return tags;
        }

        public IList<IpAddressOrRange> PopulateIpRules(string[] IpRule)
        {
            IList<IpAddressOrRange> iprules = new List<IpAddressOrRange>();
            foreach (string ipAddressOrRange in IpRule)
            {
                iprules.Add(new IpAddressOrRange(ipAddressOrRange));
            }
            return iprules;
        }

        protected AnalyticalStorageConfiguration CreateAnalyticalStorageConfiguration(string param)
        {
            AnalyticalStorageConfiguration retval = null;
            switch (param)
            {
                case SDKModel.AnalyticalStorageSchemaType.WellDefined:
                case SDKModel.AnalyticalStorageSchemaType.FullFidelity:
                    retval = new AnalyticalStorageConfiguration(param);
                    break;

                default:
                    if (!string.IsNullOrWhiteSpace(param))
                    {
                        string message = $"Invalid value for AnalyticalStorageSchemaType.  Valid values are '{SDKModel.AnalyticalStorageSchemaType.WellDefined}' and '{SDKModel.AnalyticalStorageSchemaType.FullFidelity}'.";
                        WriteWarning(message);
                    }
                    break;
            }
            return retval;
        }
    }
}
