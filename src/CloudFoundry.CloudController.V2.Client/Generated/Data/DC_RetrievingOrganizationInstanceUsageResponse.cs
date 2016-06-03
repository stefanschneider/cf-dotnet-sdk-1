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

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.RetrievingOrganizationInstanceUsage()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/237/organizations/retrieving_organization_instance_usage.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RetrievingOrganizationInstanceUsageResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractRetrievingOrganizationInstanceUsageResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.RetrievingOrganizationInstanceUsage()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/237/organizations/retrieving_organization_instance_usage.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractRetrievingOrganizationInstanceUsageResponse : IResponse
    {
        /// <summary>
        /// Contains the Metadata for this Entity
        /// </summary>
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Instance Usage</para>
        /// </summary>
        [JsonProperty("instance_usage", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceUsage
        {
            get;
            set;
        }
    }
}