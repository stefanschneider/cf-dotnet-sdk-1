//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class CreateServiceDeprecatedRequest
    {
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label
        {
            get;
            set;
        }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description
        {
            get;
            set;
        }

        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider
        {
            get;
            set;
        }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version
        {
            get;
            set;
        }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url
        {
            get;
            set;
        }

        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid
        {
            get;
            set;
        }

        [JsonProperty("long_description", NullValueHandling = NullValueHandling.Ignore)]
        public string LongDescription
        {
            get;
            set;
        }

        [JsonProperty("info_url", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoUrl
        {
            get;
            set;
        }

        [JsonProperty("documentation_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentationUrl
        {
            get;
            set;
        }

        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Timeout
        {
            get;
            set;
        }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Active
        {
            get;
            set;
        }

        [JsonProperty("bindable", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Bindable
        {
            get;
            set;
        }

        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public string Extra
        {
            get;
            set;
        }

        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic UniqueId
        {
            get;
            set;
        }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags
        {
            get;
            set;
        }

        [JsonProperty("requires", NullValueHandling = NullValueHandling.Ignore)]
        public string Requires
        {
            get;
            set;
        }

        [JsonProperty("service_broker_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceBrokerGuid
        {
            get;
            set;
        }
    }
}