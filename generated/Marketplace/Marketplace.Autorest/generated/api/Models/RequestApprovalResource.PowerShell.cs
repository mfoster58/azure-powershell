// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.PowerShell;

    /// <summary>Request approval resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(RequestApprovalResourceTypeConverter))]
    public partial class RequestApprovalResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.RequestApprovalResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RequestApprovalResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.RequestApprovalResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RequestApprovalResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RequestApprovalResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RequestApprovalResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.RequestApprovalResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RequestApprovalResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.RequestApprovalPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("OfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).OfferId = (string) content.GetValueForProperty("OfferId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).OfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).OfferDisplayName = (string) content.GetValueForProperty("OfferDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).OfferDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("PublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).PublisherId = (string) content.GetValueForProperty("PublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).PublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("PlansDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).PlansDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlanDetails>) content.GetValueForProperty("PlansDetail",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).PlansDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlanDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.PlanDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("IsClosed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).IsClosed = (bool?) content.GetValueForProperty("IsClosed",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).IsClosed, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("MessageCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).MessageCode = (long?) content.GetValueForProperty("MessageCode",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).MessageCode, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.RequestApprovalResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RequestApprovalResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.RequestApprovalPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("OfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).OfferId = (string) content.GetValueForProperty("OfferId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).OfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).OfferDisplayName = (string) content.GetValueForProperty("OfferDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).OfferDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("PublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).PublisherId = (string) content.GetValueForProperty("PublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).PublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("PlansDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).PlansDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlanDetails>) content.GetValueForProperty("PlansDetail",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).PlansDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlanDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.PlanDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("IsClosed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).IsClosed = (bool?) content.GetValueForProperty("IsClosed",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).IsClosed, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("MessageCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).MessageCode = (long?) content.GetValueForProperty("MessageCode",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRequestApprovalResourceInternal)this).MessageCode, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Request approval resource.
    [System.ComponentModel.TypeConverter(typeof(RequestApprovalResourceTypeConverter))]
    public partial interface IRequestApprovalResource

    {

    }
}