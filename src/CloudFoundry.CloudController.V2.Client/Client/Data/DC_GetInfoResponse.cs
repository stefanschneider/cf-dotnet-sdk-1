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

using CloudFoundry.CloudController.V2.Interfaces;
using Newtonsoft.Json;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class GetInfoResponse : IResponse
    {
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("build", NullValueHandling = NullValueHandling.Ignore)]
        public string Build
        {
            get;
            set;
        }

        [JsonProperty("support", NullValueHandling = NullValueHandling.Ignore)]
        public string Support
        {
            get;
            set;
        }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version
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

        [JsonProperty("authorization_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationEndpoint
        {
            get;
            set;
        }

        [JsonProperty("token_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenEndpoint
        {
            get;
            set;
        }

        [JsonProperty("api_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion
        {
            get;
            set;
        }

        [JsonProperty("logging_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string LoggingEndpoint
        {
            get;
            set;
        }
    }
}