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

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServicePlanVisibilitiesTest
    {


        [TestMethod]
        public void TestUpdateServicePlanVisibilityResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""2b9b2b6e-0aa2-438c-942e-0147add32778"",
    ""url"": ""/v2/service_plan_visibilities/e8360394-88b8-4f91-98ca-8b232e9ec5eb"",
    ""created_at"": ""2016-05-26T11:34:35Z"",
    ""updated_at"": ""2016-05-26T11:34:35Z""
  },
  ""entity"": {
    ""service_plan_guid"": ""2b9b2b6e-0aa2-438c-942e-0147add32778"",
    ""organization_guid"": ""2b9b2b6e-0aa2-438c-942e-0147add32778"",
    ""service_plan_url"": ""/v2/service_plans/854b09fb-80fb-4aa1-a14b-c7abdc5bfaa4"",
    ""organization_url"": ""/v2/organizations/7a5ebd98-1866-4a97-acfe-86018a9d795b""
  }
}";

            UpdateServicePlanVisibilityResponse obj = Utilities.DeserializeJson<UpdateServicePlanVisibilityResponse>(json);

            Assert.AreEqual("2b9b2b6e-0aa2-438c-942e-0147add32778", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plan_visibilities/e8360394-88b8-4f91-98ca-8b232e9ec5eb", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:35Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-05-26T11:34:35Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("2b9b2b6e-0aa2-438c-942e-0147add32778", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("2b9b2b6e-0aa2-438c-942e-0147add32778", TestUtil.ToTestableString(obj.OrganizationGuid), true);
            Assert.AreEqual("/v2/service_plans/854b09fb-80fb-4aa1-a14b-c7abdc5bfaa4", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/organizations/7a5ebd98-1866-4a97-acfe-86018a9d795b", TestUtil.ToTestableString(obj.OrganizationUrl), true);
        }

        [TestMethod]
        public void TestListAllServicePlanVisibilitiesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""c1d805bd-8a4a-40fa-9dc5-d4f51ec38b44"",
        ""url"": ""/v2/service_plan_visibilities/d3ab93c7-6b96-483b-9dbf-ee09b2aeff3c"",
        ""created_at"": ""2016-05-26T11:34:35Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""service_plan_guid"": ""c1d805bd-8a4a-40fa-9dc5-d4f51ec38b44"",
        ""organization_guid"": ""c1d805bd-8a4a-40fa-9dc5-d4f51ec38b44"",
        ""service_plan_url"": ""/v2/service_plans/789eccb8-0dca-4dbf-ac99-613e970dc55a"",
        ""organization_url"": ""/v2/organizations/91e3bb2a-fb26-47a1-8ec8-ea5290801db3""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServicePlanVisibilitiesResponse> page = Utilities.DeserializePage<ListAllServicePlanVisibilitiesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("c1d805bd-8a4a-40fa-9dc5-d4f51ec38b44", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plan_visibilities/d3ab93c7-6b96-483b-9dbf-ee09b2aeff3c", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:35Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("c1d805bd-8a4a-40fa-9dc5-d4f51ec38b44", TestUtil.ToTestableString(page[0].ServicePlanGuid), true);
            Assert.AreEqual("c1d805bd-8a4a-40fa-9dc5-d4f51ec38b44", TestUtil.ToTestableString(page[0].OrganizationGuid), true);
            Assert.AreEqual("/v2/service_plans/789eccb8-0dca-4dbf-ac99-613e970dc55a", TestUtil.ToTestableString(page[0].ServicePlanUrl), true);
            Assert.AreEqual("/v2/organizations/91e3bb2a-fb26-47a1-8ec8-ea5290801db3", TestUtil.ToTestableString(page[0].OrganizationUrl), true);
        }

        [TestMethod]
        public void TestRetrieveServicePlanVisibilityResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""5740984e-9fec-4152-bd86-78fce8ac5a1b"",
    ""url"": ""/v2/service_plan_visibilities/a3009078-644c-42d9-82f5-b9f8c14f2392"",
    ""created_at"": ""2016-05-26T11:34:34Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""service_plan_guid"": ""5740984e-9fec-4152-bd86-78fce8ac5a1b"",
    ""organization_guid"": ""5740984e-9fec-4152-bd86-78fce8ac5a1b"",
    ""service_plan_url"": ""/v2/service_plans/6b6500ee-b89f-44f9-aa1f-feeb84b5db72"",
    ""organization_url"": ""/v2/organizations/7c73285a-584e-4e6a-8159-34ae4966613d""
  }
}";

            RetrieveServicePlanVisibilityResponse obj = Utilities.DeserializeJson<RetrieveServicePlanVisibilityResponse>(json);

            Assert.AreEqual("5740984e-9fec-4152-bd86-78fce8ac5a1b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plan_visibilities/a3009078-644c-42d9-82f5-b9f8c14f2392", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:34Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("5740984e-9fec-4152-bd86-78fce8ac5a1b", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("5740984e-9fec-4152-bd86-78fce8ac5a1b", TestUtil.ToTestableString(obj.OrganizationGuid), true);
            Assert.AreEqual("/v2/service_plans/6b6500ee-b89f-44f9-aa1f-feeb84b5db72", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/organizations/7c73285a-584e-4e6a-8159-34ae4966613d", TestUtil.ToTestableString(obj.OrganizationUrl), true);
        }

        [TestMethod]
        public void TestCreateServicePlanVisibilityResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""864b7ee9-9046-45fe-a407-026548fee92b"",
    ""url"": ""/v2/service_plan_visibilities/618abd0f-b6c6-41db-92cd-af01e8db392b"",
    ""created_at"": ""2016-05-26T11:34:35Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""service_plan_guid"": ""864b7ee9-9046-45fe-a407-026548fee92b"",
    ""organization_guid"": ""864b7ee9-9046-45fe-a407-026548fee92b"",
    ""service_plan_url"": ""/v2/service_plans/9de3b3fa-35cc-45a0-88b7-d60191c176b7"",
    ""organization_url"": ""/v2/organizations/c847639a-ad1d-4393-87bf-be604c8c8f6b""
  }
}";

            CreateServicePlanVisibilityResponse obj = Utilities.DeserializeJson<CreateServicePlanVisibilityResponse>(json);

            Assert.AreEqual("864b7ee9-9046-45fe-a407-026548fee92b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plan_visibilities/618abd0f-b6c6-41db-92cd-af01e8db392b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:35Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("864b7ee9-9046-45fe-a407-026548fee92b", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("864b7ee9-9046-45fe-a407-026548fee92b", TestUtil.ToTestableString(obj.OrganizationGuid), true);
            Assert.AreEqual("/v2/service_plans/9de3b3fa-35cc-45a0-88b7-d60191c176b7", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/organizations/c847639a-ad1d-4393-87bf-be604c8c8f6b", TestUtil.ToTestableString(obj.OrganizationUrl), true);
        }
    }
}
