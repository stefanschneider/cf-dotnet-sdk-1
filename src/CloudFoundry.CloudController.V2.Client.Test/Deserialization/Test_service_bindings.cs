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
    public class ServiceBindingsTest
    {


        [TestMethod]
        public void TestListAllServiceBindingsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""6fe99e07-6f05-4d6d-9b67-5cb88612e197"",
        ""url"": ""/v2/service_bindings/7201c5d0-85ed-42df-98d2-c9258c706afd"",
        ""created_at"": ""2016-05-26T11:34:22Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""6fe99e07-6f05-4d6d-9b67-5cb88612e197"",
        ""service_instance_guid"": ""6fe99e07-6f05-4d6d-9b67-5cb88612e197"",
        ""credentials"": {
          ""creds-key-3"": ""creds-val-3""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""volume_mounts"": [

        ],
        ""app_url"": ""/v2/apps/037f237d-a0c7-4e61-b64f-d2614071129a"",
        ""service_instance_url"": ""/v2/service_instances/fdcbf098-6863-4f46-9838-9f4e3ba65732""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBindingsResponse> page = Utilities.DeserializePage<ListAllServiceBindingsResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("6fe99e07-6f05-4d6d-9b67-5cb88612e197", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/7201c5d0-85ed-42df-98d2-c9258c706afd", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:22Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("6fe99e07-6f05-4d6d-9b67-5cb88612e197", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("6fe99e07-6f05-4d6d-9b67-5cb88612e197", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/037f237d-a0c7-4e61-b64f-d2614071129a", TestUtil.ToTestableString(page[0].AppUrl), true);
            Assert.AreEqual("/v2/service_instances/fdcbf098-6863-4f46-9838-9f4e3ba65732", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestRetrieveServiceBindingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""45cda2e5-bb06-4450-9dbf-0fb8eb74a96e"",
    ""url"": ""/v2/service_bindings/855665ee-cfd7-4bfa-b202-7aac0ce654fd"",
    ""created_at"": ""2016-05-26T11:34:21Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_guid"": ""45cda2e5-bb06-4450-9dbf-0fb8eb74a96e"",
    ""service_instance_guid"": ""45cda2e5-bb06-4450-9dbf-0fb8eb74a96e"",
    ""credentials"": {
      ""creds-key-1"": ""creds-val-1""
    },
    ""binding_options"": {

    },
    ""gateway_data"": null,
    ""gateway_name"": """",
    ""syslog_drain_url"": null,
    ""volume_mounts"": [

    ],
    ""app_url"": ""/v2/apps/a9d68943-9c7a-470f-807e-5cf6c0ac6d5a"",
    ""service_instance_url"": ""/v2/service_instances/9de981f8-577a-45de-b498-7f9cd164967f""
  }
}";

            RetrieveServiceBindingResponse obj = Utilities.DeserializeJson<RetrieveServiceBindingResponse>(json);

            Assert.AreEqual("45cda2e5-bb06-4450-9dbf-0fb8eb74a96e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/855665ee-cfd7-4bfa-b202-7aac0ce654fd", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:21Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("45cda2e5-bb06-4450-9dbf-0fb8eb74a96e", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("45cda2e5-bb06-4450-9dbf-0fb8eb74a96e", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/a9d68943-9c7a-470f-807e-5cf6c0ac6d5a", TestUtil.ToTestableString(obj.AppUrl), true);
            Assert.AreEqual("/v2/service_instances/9de981f8-577a-45de-b498-7f9cd164967f", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestCreateServiceBindingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""ff4ae9f6-e78c-48c4-9ad8-70e9010e4cb9"",
    ""url"": ""/v2/service_bindings/7be5b4b7-33cb-449b-ab80-3a1cfbbd4ac6"",
    ""created_at"": ""2016-05-26T11:34:22Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_guid"": ""ff4ae9f6-e78c-48c4-9ad8-70e9010e4cb9"",
    ""service_instance_guid"": ""ff4ae9f6-e78c-48c4-9ad8-70e9010e4cb9"",
    ""credentials"": {
      ""creds-key-7"": ""creds-val-7""
    },
    ""binding_options"": {

    },
    ""gateway_data"": null,
    ""gateway_name"": """",
    ""syslog_drain_url"": null,
    ""volume_mounts"": [

    ],
    ""app_url"": ""/v2/apps/a8b5e15b-064c-47f9-86b4-f416d771bed9"",
    ""service_instance_url"": ""/v2/user_provided_service_instances/27717c47-0b57-456d-9157-a7df6b830653""
  }
}";

            CreateServiceBindingResponse obj = Utilities.DeserializeJson<CreateServiceBindingResponse>(json);

            Assert.AreEqual("ff4ae9f6-e78c-48c4-9ad8-70e9010e4cb9", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/7be5b4b7-33cb-449b-ab80-3a1cfbbd4ac6", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:22Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("ff4ae9f6-e78c-48c4-9ad8-70e9010e4cb9", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("ff4ae9f6-e78c-48c4-9ad8-70e9010e4cb9", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/a8b5e15b-064c-47f9-86b4-f416d771bed9", TestUtil.ToTestableString(obj.AppUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/27717c47-0b57-456d-9157-a7df6b830653", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);
        }
    }
}
