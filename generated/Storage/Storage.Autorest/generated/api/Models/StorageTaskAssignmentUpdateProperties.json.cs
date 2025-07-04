// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Storage.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Extensions;

    /// <summary>Properties of the storage task update assignment.</summary>
    public partial class StorageTaskAssignmentUpdateProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskAssignmentUpdateProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskAssignmentUpdateProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskAssignmentUpdateProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject json ? new StorageTaskAssignmentUpdateProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject into a new instance of <see cref="StorageTaskAssignmentUpdateProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal StorageTaskAssignmentUpdateProperties(Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_executionContext = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject>("executionContext"), out var __jsonExecutionContext) ? Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.StorageTaskAssignmentUpdateExecutionContext.FromJson(__jsonExecutionContext) : _executionContext;}
            {_report = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject>("report"), out var __jsonReport) ? Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.StorageTaskAssignmentUpdateReport.FromJson(__jsonReport) : _report;}
            {_runStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject>("runStatus"), out var __jsonRunStatus) ? Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.StorageTaskReportProperties.FromJson(__jsonRunStatus) : _runStatus;}
            {_taskId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonString>("taskId"), out var __jsonTaskId) ? (string)__jsonTaskId : (string)_taskId;}
            {_enabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonBoolean>("enabled"), out var __jsonEnabled) ? (bool?)__jsonEnabled : _enabled;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)_description;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="StorageTaskAssignmentUpdateProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="StorageTaskAssignmentUpdateProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._executionContext ? (Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode) this._executionContext.ToJson(null,serializationMode) : null, "executionContext" ,container.Add );
            AddIf( null != this._report ? (Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode) this._report.ToJson(null,serializationMode) : null, "report" ,container.Add );
            AddIf( null != this._runStatus ? (Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode) this._runStatus.ToJson(null,serializationMode) : null, "runStatus" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._taskId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonString(this._taskId.ToString()) : null, "taskId" ,container.Add );
            }
            AddIf( null != this._enabled ? (Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonBoolean((bool)this._enabled) : null, "enabled" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}