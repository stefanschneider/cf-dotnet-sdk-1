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
    public class ServiceBrokersTest
    {


        [TestMethod]
        public void TestRetrieveServiceBrokerResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""ea05aeed-7c19-4288-a991-38561d5e1b06"",
    ""url"": ""/v2/service_brokers/0d650aa0-9b4e-4c47-9872-1e217f85d37f"",
    ""created_at"": ""2016-05-26T11:34:47Z"",
    ""updated_at"": ""2016-05-26T11:34:47Z""
  },
  ""entity"": {
    ""name"": ""name-2269"",
    ""broker_url"": ""https://foo.com/url-88"",
    ""auth_username"": ""auth_username-70"",
    ""space_guid"": ""ea05aeed-7c19-4288-a991-38561d5e1b06""
  }
}";

            RetrieveServiceBrokerResponse obj = Utilities.DeserializeJson<RetrieveServiceBrokerResponse>(json);

            Assert.AreEqual("ea05aeed-7c19-4288-a991-38561d5e1b06", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/0d650aa0-9b4e-4c47-9872-1e217f85d37f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:47Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-05-26T11:34:47Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2269", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("https://foo.com/url-88", TestUtil.ToTestableString(obj.BrokerUrl), true);
            Assert.AreEqual("auth_username-70", TestUtil.ToTestableString(obj.AuthUsername), true);
            Assert.AreEqual("ea05aeed-7c19-4288-a991-38561d5e1b06", TestUtil.ToTestableString(obj.SpaceGuid), true);
        }

        [TestMethod]
        public void TestCreateServiceBrokerResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""002f9c05-3ad9-4ee1-9408-a36482c79c1b"",
    ""created_at"": ""2016-05-26T11:34:47Z"",
    ""updated_at"": null,
    ""url"": ""/v2/service_brokers/186e9a4b-3ba6-4007-a1ff-1eac6d978e00""
  },
  ""entity"": {
    ""name"": ""service-broker-name"",
    ""broker_url"": ""https://broker.example.com"",
    ""auth_username"": ""admin"",
    ""space_guid"": null
  }
}";

            CreateServiceBrokerResponse obj = Utilities.DeserializeJson<CreateServiceBrokerResponse>(json);

            Assert.AreEqual("002f9c05-3ad9-4ee1-9408-a36482c79c1b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2016-05-26T11:34:47Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("/v2/service_brokers/186e9a4b-3ba6-4007-a1ff-1eac6d978e00", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("service-broker-name", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("https://broker.example.com", TestUtil.ToTestableString(obj.BrokerUrl), true);
            Assert.AreEqual("admin", TestUtil.ToTestableString(obj.AuthUsername), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.SpaceGuid), true);
        }

        [TestMethod]
        public void TestListAllServiceBrokersResponse()
        {
            string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""d7fb80a0-6a64-411b-a9d4-492977d5e0f8"",
        ""url"": ""/v2/service_brokers/d98e4f23-378c-423a-a78f-4cfe9fcdc7b6"",
        ""created_at"": ""2016-05-26T11:34:47Z"",
        ""updated_at"": ""2016-05-26T11:34:47Z""
      },
      ""entity"": {
        ""name"": ""name-2251"",
        ""broker_url"": ""https://foo.com/url-79"",
        ""auth_username"": ""auth_username-61"",
        ""space_guid"": ""d7fb80a0-6a64-411b-a9d4-492977d5e0f8""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""d7fb80a0-6a64-411b-a9d4-492977d5e0f8"",
        ""url"": ""/v2/service_brokers/c04a5bb4-64d4-499d-a6ec-662abfcb833f"",
        ""created_at"": ""2016-05-26T11:34:47Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2252"",
        ""broker_url"": ""https://foo.com/url-80"",
        ""auth_username"": ""auth_username-62"",
        ""space_guid"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""d7fb80a0-6a64-411b-a9d4-492977d5e0f8"",
        ""url"": ""/v2/service_brokers/e7220cfa-5d6b-431d-aa1a-cd7927036f44"",
        ""created_at"": ""2016-05-26T11:34:47Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2253"",
        ""broker_url"": ""https://foo.com/url-81"",
        ""auth_username"": ""auth_username-63"",
        ""space_guid"": null
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBrokersResponse> page = Utilities.DeserializePage<ListAllServiceBrokersResponse>(json, null);

            Assert.AreEqual("3", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("d7fb80a0-6a64-411b-a9d4-492977d5e0f8", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/d98e4f23-378c-423a-a78f-4cfe9fcdc7b6", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:47Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-05-26T11:34:47Z", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2251", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("https://foo.com/url-79", TestUtil.ToTestableString(page[0].BrokerUrl), true);
            Assert.AreEqual("auth_username-61", TestUtil.ToTestableString(page[0].AuthUsername), true);
            Assert.AreEqual("d7fb80a0-6a64-411b-a9d4-492977d5e0f8", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("d7fb80a0-6a64-411b-a9d4-492977d5e0f8", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/c04a5bb4-64d4-499d-a6ec-662abfcb833f", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:47Z", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2252", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("https://foo.com/url-80", TestUtil.ToTestableString(page[1].BrokerUrl), true);
            Assert.AreEqual("auth_username-62", TestUtil.ToTestableString(page[1].AuthUsername), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].SpaceGuid), true);
            Assert.AreEqual("d7fb80a0-6a64-411b-a9d4-492977d5e0f8", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/e7220cfa-5d6b-431d-aa1a-cd7927036f44", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-26T11:34:47Z", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2253", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("https://foo.com/url-81", TestUtil.ToTestableString(page[2].BrokerUrl), true);
            Assert.AreEqual("auth_username-63", TestUtil.ToTestableString(page[2].AuthUsername), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].SpaceGuid), true);
        }

        [TestMethod]
        public void TestUpdateServiceBrokerResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""28574596-6edf-4932-8ed1-3a07cded71dc"",
    ""created_at"": ""2016-05-26T11:34:46Z"",
    ""updated_at"": ""2016-05-26T11:34:47Z"",
    ""url"": ""/v2/service_brokers/a81e2f6f-2ec6-4c2b-9158-f69355f77f56""
  },
  ""entity"": {
    ""name"": ""name-2245"",
    ""broker_url"": ""https://mybroker.example.com"",
    ""auth_username"": ""admin-user"",
    ""space_guid"": ""28574596-6edf-4932-8ed1-3a07cded71dc""
  }
}";

            UpdateServiceBrokerResponse obj = Utilities.DeserializeJson<UpdateServiceBrokerResponse>(json);

            Assert.AreEqual("28574596-6edf-4932-8ed1-3a07cded71dc", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2016-05-26T11:34:46Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-05-26T11:34:47Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("/v2/service_brokers/a81e2f6f-2ec6-4c2b-9158-f69355f77f56", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("name-2245", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("https://mybroker.example.com", TestUtil.ToTestableString(obj.BrokerUrl), true);
            Assert.AreEqual("admin-user", TestUtil.ToTestableString(obj.AuthUsername), true);
            Assert.AreEqual("28574596-6edf-4932-8ed1-3a07cded71dc", TestUtil.ToTestableString(obj.SpaceGuid), true);
        }
    }
}
