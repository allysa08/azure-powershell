
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
Create an in-memory object for PowerBIDelegatedScan.
.Description
Create an in-memory object for PowerBIDelegatedScan.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.PowerBIDelegatedScan
.Link
https://learn.microsoft.com/powershell/module/Az.Purview/new-azpurviewpowerbidelegatedscanobject
#>
function New-AzPurviewPowerBIDelegatedScanObject {
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.ModelCmdletAttribute()]
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.PowerBIDelegatedScan')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter()]
        [string]
        $AuthenticationType,
        [Parameter()]
        [string]
        $ClientId,
        [Parameter()]
        [string]
        $CollectionReferenceName,
        [Parameter()]
        [string]
        $CollectionType,
        [Parameter()]
        [string]
        $ConnectedViaReferenceName,
        [Parameter()]
        [bool]
        $IncludePersonalWorkspace,
        [Parameter()]
        [string]
        $Password,
        [Parameter()]
        [string]
        $ScanRulesetName,
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PSArgumentCompleterAttribute("Custom", "System")]
        [string]
        $ScanRulesetType,
        [Parameter()]
        [string]
        $Tenant,
        [Parameter()]
        [string]
        $UserName,
        [Parameter()]
        [int]
        $Worker
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.PowerBIDelegatedScan]::New()

        if ($PSBoundParameters.ContainsKey('AuthenticationType')) {
            $Object.AuthenticationType = $AuthenticationType
        }
        if ($PSBoundParameters.ContainsKey('ClientId')) {
            $Object.ClientId = $ClientId
        }
        if ($PSBoundParameters.ContainsKey('CollectionReferenceName')) {
            $Object.CollectionReferenceName = $CollectionReferenceName
        }
        if ($PSBoundParameters.ContainsKey('CollectionType')) {
            $Object.CollectionType = $CollectionType
        }
        if ($PSBoundParameters.ContainsKey('ConnectedViaReferenceName')) {
            $Object.ConnectedViaReferenceName = $ConnectedViaReferenceName
        }
        if ($PSBoundParameters.ContainsKey('IncludePersonalWorkspace')) {
            $Object.IncludePersonalWorkspace = $IncludePersonalWorkspace
        }
        if ($PSBoundParameters.ContainsKey('Password')) {
            $Object.Password = $Password
        }
        if ($PSBoundParameters.ContainsKey('ScanRulesetName')) {
            $Object.ScanRulesetName = $ScanRulesetName
        }
        if ($PSBoundParameters.ContainsKey('ScanRulesetType')) {
            $Object.ScanRulesetType = $ScanRulesetType
        }
        if ($PSBoundParameters.ContainsKey('Tenant')) {
            $Object.Tenant = $Tenant
        }
        if ($PSBoundParameters.ContainsKey('UserName')) {
            $Object.UserName = $UserName
        }
        if ($PSBoundParameters.ContainsKey('Worker')) {
            $Object.Worker = $Worker
        }
        return $Object
    }
}

