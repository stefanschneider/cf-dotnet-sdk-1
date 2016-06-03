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
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.ListAllServicesForOrganization()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/237/organizations/list_all_services_for_the_organization.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ListAllServicesForOrganizationResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractListAllServicesForOrganizationResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.ListAllServicesForOrganization()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/237/organizations/list_all_services_for_the_organization.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractListAllServicesForOrganizationResponse : IResponse
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
        /// <para>The Label</para>
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Provider</para>
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Provider
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Url</para>
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Url
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Description</para>
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Long Description</para>
        /// </summary>
        [JsonProperty("long_description", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic LongDescription
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Version</para>
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Version
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Info Url</para>
        /// </summary>
        [JsonProperty("info_url", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic InfoUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Active</para>
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Bindable</para>
        /// </summary>
        [JsonProperty("bindable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bindable
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Unique Id</para>
        /// </summary>
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UniqueId
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Extra</para>
        /// </summary>
        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Extra
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Tags</para>
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic[] Tags
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Requires</para>
        /// </summary>
        [JsonProperty("requires", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic[] Requires
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Documentation Url</para>
        /// </summary>
        [JsonProperty("documentation_url", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DocumentationUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Broker Guid</para>
        /// </summary>
        [JsonProperty("service_broker_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceBrokerGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Plan Updateable</para>
        /// </summary>
        [JsonProperty("plan_updateable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PlanUpdateable
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Plans Url</para>
        /// </summary>
        [JsonProperty("service_plans_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlansUrl
        {
            get;
            set;
        }
    }
}