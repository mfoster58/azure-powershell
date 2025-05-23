// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(AssignmentReportTypeConverter))]
    public partial class AssignmentReport
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.AssignmentReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AssignmentReport(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Assignment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).Assignment = (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentInfo) content.GetValueForProperty("Assignment",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).Assignment, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.AssignmentInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("VM"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).VM = (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IVMInfo) content.GetValueForProperty("VM",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).VM, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.VMInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("ReportId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ReportId = (string) content.GetValueForProperty("ReportId",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ReportId, global::System.Convert.ToString);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ComplianceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ComplianceStatus = (string) content.GetValueForProperty("ComplianceStatus",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ComplianceStatus, global::System.Convert.ToString);
            }
            if (content.Contains("OperationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).OperationType = (string) content.GetValueForProperty("OperationType",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).OperationType, global::System.Convert.ToString);
            }
            if (content.Contains("Resource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).Resource = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportResource>) content.GetValueForProperty("Resource",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).Resource, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.AssignmentReportResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("AssignmentConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).AssignmentConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationInfo) content.GetValueForProperty("AssignmentConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).AssignmentConfiguration, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.ConfigurationInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("AssignmentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).AssignmentName = (string) content.GetValueForProperty("AssignmentName",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).AssignmentName, global::System.Convert.ToString);
            }
            if (content.Contains("VMId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).VMId = (string) content.GetValueForProperty("VMId",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).VMId, global::System.Convert.ToString);
            }
            if (content.Contains("VMUuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).VMUuid = (string) content.GetValueForProperty("VMUuid",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).VMUuid, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ConfigurationName = (string) content.GetValueForProperty("ConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ConfigurationVersion = (string) content.GetValueForProperty("ConfigurationVersion",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ConfigurationVersion, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.AssignmentReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AssignmentReport(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Assignment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).Assignment = (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentInfo) content.GetValueForProperty("Assignment",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).Assignment, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.AssignmentInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("VM"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).VM = (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IVMInfo) content.GetValueForProperty("VM",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).VM, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.VMInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("ReportId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ReportId = (string) content.GetValueForProperty("ReportId",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ReportId, global::System.Convert.ToString);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ComplianceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ComplianceStatus = (string) content.GetValueForProperty("ComplianceStatus",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ComplianceStatus, global::System.Convert.ToString);
            }
            if (content.Contains("OperationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).OperationType = (string) content.GetValueForProperty("OperationType",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).OperationType, global::System.Convert.ToString);
            }
            if (content.Contains("Resource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).Resource = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportResource>) content.GetValueForProperty("Resource",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).Resource, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.AssignmentReportResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("AssignmentConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).AssignmentConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationInfo) content.GetValueForProperty("AssignmentConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).AssignmentConfiguration, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.ConfigurationInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("AssignmentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).AssignmentName = (string) content.GetValueForProperty("AssignmentName",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).AssignmentName, global::System.Convert.ToString);
            }
            if (content.Contains("VMId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).VMId = (string) content.GetValueForProperty("VMId",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).VMId, global::System.Convert.ToString);
            }
            if (content.Contains("VMUuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).VMUuid = (string) content.GetValueForProperty("VMUuid",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).VMUuid, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ConfigurationName = (string) content.GetValueForProperty("ConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ConfigurationVersion = (string) content.GetValueForProperty("ConfigurationVersion",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReportInternal)this).ConfigurationVersion, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.AssignmentReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReport" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReport DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AssignmentReport(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.AssignmentReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReport" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReport DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AssignmentReport(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AssignmentReport" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AssignmentReport" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IAssignmentReport FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    [System.ComponentModel.TypeConverter(typeof(AssignmentReportTypeConverter))]
    public partial interface IAssignmentReport

    {

    }
}