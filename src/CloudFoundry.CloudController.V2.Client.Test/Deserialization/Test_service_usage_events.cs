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
    public class ServiceUsageEventsTest
    {


        [TestMethod]
        public void TestListServiceUsageEventsResponse()
        {
            string json = @"{
  ""total_results"": 2,
  ""total_pages"": 2,
  ""prev_url"": null,
  ""next_url"": ""/v2/service_usage_events?after_guid=5e71847e-4220-4680-a009-9d7a262facaa=asc=2=1"",
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""f7a671bc-2e97-48af-9eae-42ab496478e7"",
        ""url"": ""/v2/service_usage_events/9e255a78-1983-47e3-ac0e-ccaeaafdcce7"",
        ""created_at"": ""2016-05-26T11:34:34Z""
      },
      ""entity"": {
        ""state"": ""CREATED"",
        ""org_guid"": ""f7a671bc-2e97-48af-9eae-42ab496478e7"",
        ""space_guid"": ""f7a671bc-2e97-48af-9eae-42ab496478e7"",
        ""space_name"": ""name-645"",
        ""service_instance_guid"": ""f7a671bc-2e97-48af-9eae-42ab496478e7"",
        ""service_instance_name"": ""name-646"",
        ""service_instance_type"": ""type-5"",
        ""service_plan_guid"": ""f7a671bc-2e97-48af-9eae-42ab496478e7"",
        ""service_plan_name"": ""name-647"",
        ""service_guid"": ""f7a671bc-2e97-48af-9eae-42ab496478e7"",
        ""service_label"": ""label-25""
      }
    }
  ]
}";

            PagedResponseCollection<ListServiceUsageEventsResponse> page = Utilities.DeserializePage<ListServiceUsageEventsResponse>(json, null);

            Assert.AreEqual("2", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("2", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("/v2/service_usage_events?after_guid=5e71847e-4220-4680-a009-9d7a262facaa=asc=2=1", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("f7a671bc-2e97-48af-9eae-42ab496478e7", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_usage_events/9e255a78-1983-47e3-ac0e-ccaeaafdcce7", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:34Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("CREATED", TestUtil.ToTestableString(page[0].State), true);
            Assert.AreEqual("f7a671bc-2e97-48af-9eae-42ab496478e7", TestUtil.ToTestableString(page[0].OrgGuid), true);
            Assert.AreEqual("f7a671bc-2e97-48af-9eae-42ab496478e7", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("name-645", TestUtil.ToTestableString(page[0].SpaceName), true);
            Assert.AreEqual("f7a671bc-2e97-48af-9eae-42ab496478e7", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("name-646", TestUtil.ToTestableString(page[0].ServiceInstanceName), true);
            Assert.AreEqual("type-5", TestUtil.ToTestableString(page[0].ServiceInstanceType), true);
            Assert.AreEqual("f7a671bc-2e97-48af-9eae-42ab496478e7", TestUtil.ToTestableString(page[0].ServicePlanGuid), true);
            Assert.AreEqual("name-647", TestUtil.ToTestableString(page[0].ServicePlanName), true);
            Assert.AreEqual("f7a671bc-2e97-48af-9eae-42ab496478e7", TestUtil.ToTestableString(page[0].ServiceGuid), true);
            Assert.AreEqual("label-25", TestUtil.ToTestableString(page[0].ServiceLabel), true);
        }

        [TestMethod]
        public void TestRetrieveServiceUsageEventResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""babfb643-fbec-4c1f-b58b-b9e57531906e"",
    ""url"": ""/v2/service_usage_events/5aa4fb84-8cc3-4111-9611-9b56ec2b34c2"",
    ""created_at"": ""2016-05-26T11:34:34Z""
  },
  ""entity"": {
    ""state"": ""CREATED"",
    ""org_guid"": ""babfb643-fbec-4c1f-b58b-b9e57531906e"",
    ""space_guid"": ""babfb643-fbec-4c1f-b58b-b9e57531906e"",
    ""space_name"": ""name-651"",
    ""service_instance_guid"": ""babfb643-fbec-4c1f-b58b-b9e57531906e"",
    ""service_instance_name"": ""name-652"",
    ""service_instance_type"": ""type-7"",
    ""service_plan_guid"": ""babfb643-fbec-4c1f-b58b-b9e57531906e"",
    ""service_plan_name"": ""name-653"",
    ""service_guid"": ""babfb643-fbec-4c1f-b58b-b9e57531906e"",
    ""service_label"": ""label-27""
  }
}";

            RetrieveServiceUsageEventResponse obj = Utilities.DeserializeJson<RetrieveServiceUsageEventResponse>(json);

            Assert.AreEqual("babfb643-fbec-4c1f-b58b-b9e57531906e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_usage_events/5aa4fb84-8cc3-4111-9611-9b56ec2b34c2", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:34Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("CREATED", TestUtil.ToTestableString(obj.State), true);
            Assert.AreEqual("babfb643-fbec-4c1f-b58b-b9e57531906e", TestUtil.ToTestableString(obj.OrgGuid), true);
            Assert.AreEqual("babfb643-fbec-4c1f-b58b-b9e57531906e", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("name-651", TestUtil.ToTestableString(obj.SpaceName), true);
            Assert.AreEqual("babfb643-fbec-4c1f-b58b-b9e57531906e", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
            Assert.AreEqual("name-652", TestUtil.ToTestableString(obj.ServiceInstanceName), true);
            Assert.AreEqual("type-7", TestUtil.ToTestableString(obj.ServiceInstanceType), true);
            Assert.AreEqual("babfb643-fbec-4c1f-b58b-b9e57531906e", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("name-653", TestUtil.ToTestableString(obj.ServicePlanName), true);
            Assert.AreEqual("babfb643-fbec-4c1f-b58b-b9e57531906e", TestUtil.ToTestableString(obj.ServiceGuid), true);
            Assert.AreEqual("label-27", TestUtil.ToTestableString(obj.ServiceLabel), true);
        }
    }
}
