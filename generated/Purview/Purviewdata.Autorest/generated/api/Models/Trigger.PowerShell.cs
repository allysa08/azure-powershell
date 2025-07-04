// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(TriggerTypeConverter))]
    public partial class Trigger
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Trigger"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITrigger" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITrigger DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Trigger(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Trigger"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITrigger" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITrigger DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Trigger(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Trigger" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Trigger" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITrigger FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Trigger"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Trigger(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.TriggerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Recurrence"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).Recurrence = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesRecurrence) content.GetValueForProperty("Recurrence",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).Recurrence, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.TriggerPropertiesRecurrenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecurrenceInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceInterval = (string) content.GetValueForProperty("RecurrenceInterval",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceInterval, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastScheduled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).LastScheduled = (global::System.DateTime?) content.GetValueForProperty("LastScheduled",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).LastScheduled, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ScanLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).ScanLevel = (string) content.GetValueForProperty("ScanLevel",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).ScanLevel, global::System.Convert.ToString);
            }
            if (content.Contains("IncrementalScanStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).IncrementalScanStartTime = (global::System.DateTime?) content.GetValueForProperty("IncrementalScanStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).IncrementalScanStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RecurrenceScheduleAdditionalProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleAdditionalProperty = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleAdditionalProperties) content.GetValueForProperty("RecurrenceScheduleAdditionalProperty",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleAdditionalProperty, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.RecurrenceScheduleAdditionalPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecurrenceScheduleWeekDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleWeekDay = (System.Collections.Generic.List<string>) content.GetValueForProperty("RecurrenceScheduleWeekDay",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleWeekDay, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RecurrenceScheduleMonthlyOccurrence"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleMonthlyOccurrence = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence>) content.GetValueForProperty("RecurrenceScheduleMonthlyOccurrence",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleMonthlyOccurrence, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence>(__y, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.RecurrenceScheduleOccurrenceTypeConverter.ConvertFrom));
            }
            if (content.Contains("RecurrenceSchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceSchedule = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceSchedule) content.GetValueForProperty("RecurrenceSchedule",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceSchedule, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.TriggerRecurrenceScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecurrenceFrequency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceFrequency = (string) content.GetValueForProperty("RecurrenceFrequency",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceFrequency, global::System.Convert.ToString);
            }
            if (content.Contains("Interval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).Interval = (int?) content.GetValueForProperty("Interval",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).Interval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RecurrenceStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceStartTime = (global::System.DateTime?) content.GetValueForProperty("RecurrenceStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RecurrenceEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceEndTime = (global::System.DateTime?) content.GetValueForProperty("RecurrenceEndTime",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RecurrenceTimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceTimeZone = (string) content.GetValueForProperty("RecurrenceTimeZone",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceTimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("RecurrenceScheduleMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleMinute = (System.Collections.Generic.List<int>) content.GetValueForProperty("RecurrenceScheduleMinute",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleMinute, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("RecurrenceScheduleHour"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleHour = (System.Collections.Generic.List<int>) content.GetValueForProperty("RecurrenceScheduleHour",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleHour, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("RecurrenceScheduleMonthDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleMonthDay = (System.Collections.Generic.List<int>) content.GetValueForProperty("RecurrenceScheduleMonthDay",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleMonthDay, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Trigger"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Trigger(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.TriggerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Recurrence"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).Recurrence = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesRecurrence) content.GetValueForProperty("Recurrence",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).Recurrence, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.TriggerPropertiesRecurrenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecurrenceInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceInterval = (string) content.GetValueForProperty("RecurrenceInterval",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceInterval, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastScheduled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).LastScheduled = (global::System.DateTime?) content.GetValueForProperty("LastScheduled",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).LastScheduled, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ScanLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).ScanLevel = (string) content.GetValueForProperty("ScanLevel",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).ScanLevel, global::System.Convert.ToString);
            }
            if (content.Contains("IncrementalScanStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).IncrementalScanStartTime = (global::System.DateTime?) content.GetValueForProperty("IncrementalScanStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).IncrementalScanStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RecurrenceScheduleAdditionalProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleAdditionalProperty = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleAdditionalProperties) content.GetValueForProperty("RecurrenceScheduleAdditionalProperty",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleAdditionalProperty, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.RecurrenceScheduleAdditionalPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecurrenceScheduleWeekDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleWeekDay = (System.Collections.Generic.List<string>) content.GetValueForProperty("RecurrenceScheduleWeekDay",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleWeekDay, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RecurrenceScheduleMonthlyOccurrence"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleMonthlyOccurrence = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence>) content.GetValueForProperty("RecurrenceScheduleMonthlyOccurrence",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleMonthlyOccurrence, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence>(__y, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.RecurrenceScheduleOccurrenceTypeConverter.ConvertFrom));
            }
            if (content.Contains("RecurrenceSchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceSchedule = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceSchedule) content.GetValueForProperty("RecurrenceSchedule",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceSchedule, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.TriggerRecurrenceScheduleTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecurrenceFrequency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceFrequency = (string) content.GetValueForProperty("RecurrenceFrequency",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceFrequency, global::System.Convert.ToString);
            }
            if (content.Contains("Interval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).Interval = (int?) content.GetValueForProperty("Interval",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).Interval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RecurrenceStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceStartTime = (global::System.DateTime?) content.GetValueForProperty("RecurrenceStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RecurrenceEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceEndTime = (global::System.DateTime?) content.GetValueForProperty("RecurrenceEndTime",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RecurrenceTimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceTimeZone = (string) content.GetValueForProperty("RecurrenceTimeZone",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceTimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("RecurrenceScheduleMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleMinute = (System.Collections.Generic.List<int>) content.GetValueForProperty("RecurrenceScheduleMinute",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleMinute, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("RecurrenceScheduleHour"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleHour = (System.Collections.Generic.List<int>) content.GetValueForProperty("RecurrenceScheduleHour",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleHour, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("RecurrenceScheduleMonthDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleMonthDay = (System.Collections.Generic.List<int>) content.GetValueForProperty("RecurrenceScheduleMonthDay",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerInternal)this).RecurrenceScheduleMonthDay, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            AfterDeserializePSObject(content);
        }
    }
    [System.ComponentModel.TypeConverter(typeof(TriggerTypeConverter))]
    public partial interface ITrigger

    {

    }
}