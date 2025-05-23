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

using Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Xunit;


namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Test.ScenarioTests
{
    public partial class PolicyTests : RecoveryServicesBackupTestRunner
    {
        private readonly string _IaasVmcommonModule = $"ScenarioTests/{PsBackupProviderTypes.IaasVm}/Common.ps1";
        private readonly string _IaasVmtestModule = $"ScenarioTests/{PsBackupProviderTypes.IaasVm}/PolicyTests.ps1";

        public PolicyTests(Xunit.Abstractions.ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMPolicy()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_IaasVmcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_IaasVmtestModule.AsAbsoluteLocation()}",
                "Test-AzureVMPolicy"
            );
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMEnhancedPolicy()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_IaasVmcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_IaasVmtestModule.AsAbsoluteLocation()}",
                "Test-AzureVMEnhancedPolicy"
            );
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMSmartTieringPolicy()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_IaasVmcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_IaasVmtestModule.AsAbsoluteLocation()}",
                "Test-AzureVMSmartTieringPolicy"
            );
        }
        
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMNonUTCPolicy()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_IaasVmcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_IaasVmtestModule.AsAbsoluteLocation()}",
                "Test-AzureVMNonUTCPolicy"
            );
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMCrashconsistentPolicy()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_IaasVmcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_IaasVmtestModule.AsAbsoluteLocation()}",
                "Test-AzureVMCrashconsistentPolicy"
            );
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVM)]
        public void TestAzureVMEnhancedPolicyAsDefaultPolicy()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_IaasVmcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_IaasVmtestModule.AsAbsoluteLocation()}",
                "Test-AzureVMEnhancedPolicyAsDefault"
            );
        }
    }    
}
