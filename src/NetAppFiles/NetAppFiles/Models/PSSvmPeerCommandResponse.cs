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

using Microsoft.Azure.Management.NetApp.Models;

namespace Microsoft.Azure.Commands.NetAppFiles.Models
{
    public class PSSvmPeerCommandResponse
    {        
        /// <summary>
        /// Gets or sets a command that needs to be run on the external ONTAP to accept
        /// svm peering.  Will only be present if &lt;code&gt;svmPeeringStatus&lt;/code&gt; is
        /// &lt;code&gt;pending&lt;/code&gt;
        /// </summary>     
        public string SvmPeeringCommand { get; set; }
    }
}
