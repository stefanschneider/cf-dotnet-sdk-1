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
    public class ServiceAuthTokensDeprecatedTest
    {


        [TestMethod]
        public void TestListAllServiceAuthTokensDeprecatedResponse()
        {
            string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""443e0580-8b1e-47d2-b618-6a934ebc622d"",
        ""url"": ""/v2/service_auth_tokens/443e0580-8b1e-47d2-b618-6a934ebc622d"",
        ""created_at"": ""2015-04-16T12:04:17+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-11"",
        ""provider"": ""provider-11""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""476626c0-a007-4590-abae-38ebe4898f64"",
        ""url"": ""/v2/service_auth_tokens/476626c0-a007-4590-abae-38ebe4898f64"",
        ""created_at"": ""2015-04-16T12:04:17+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-12"",
        ""provider"": ""provider-12""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""f4569a3d-76e2-4cbe-a849-acf1bae623e4"",
        ""url"": ""/v2/service_auth_tokens/f4569a3d-76e2-4cbe-a849-acf1bae623e4"",
        ""created_at"": ""2015-04-16T12:04:17+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-13"",
        ""provider"": ""provider-13""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceAuthTokensDeprecatedResponse> page = Utilities.DeserializePage<ListAllServiceAuthTokensDeprecatedResponse>(json, null);

            Assert.AreEqual("3", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("443e0580-8b1e-47d2-b618-6a934ebc622d", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_auth_tokens/443e0580-8b1e-47d2-b618-6a934ebc622d", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:17+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-11", TestUtil.ToTestableString(page[0].Label), true);
            Assert.AreEqual("provider-11", TestUtil.ToTestableString(page[0].Provider), true);
            Assert.AreEqual("476626c0-a007-4590-abae-38ebe4898f64", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_auth_tokens/476626c0-a007-4590-abae-38ebe4898f64", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:17+00:00", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-12", TestUtil.ToTestableString(page[1].Label), true);
            Assert.AreEqual("provider-12", TestUtil.ToTestableString(page[1].Provider), true);
            Assert.AreEqual("f4569a3d-76e2-4cbe-a849-acf1bae623e4", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_auth_tokens/f4569a3d-76e2-4cbe-a849-acf1bae623e4", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:17+00:00", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-13", TestUtil.ToTestableString(page[2].Label), true);
            Assert.AreEqual("provider-13", TestUtil.ToTestableString(page[2].Provider), true);
        }

        [TestMethod]
        public void TestFilterResultSetByLabelDeprecatedResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""1854dd17-586d-456d-af55-0d863bac4dc7"",
        ""url"": ""/v2/service_auth_tokens/1854dd17-586d-456d-af55-0d863bac4dc7"",
        ""created_at"": ""2015-04-16T12:04:17+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""Nic-Token"",
        ""provider"": ""provider-23""
      }
    }
  ]
}";

            PagedResponseCollection<FilterResultSetByLabelDeprecatedResponse> page = Utilities.DeserializePage<FilterResultSetByLabelDeprecatedResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("1854dd17-586d-456d-af55-0d863bac4dc7", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_auth_tokens/1854dd17-586d-456d-af55-0d863bac4dc7", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:17+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("Nic-Token", TestUtil.ToTestableString(page[0].Label), true);
            Assert.AreEqual("provider-23", TestUtil.ToTestableString(page[0].Provider), true);
        }

        [TestMethod]
        public void TestRetrieveServiceAuthTokenDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""caefa4a5-7b98-423c-850b-8dd1d4247ab8"",
    ""url"": ""/v2/service_auth_tokens/caefa4a5-7b98-423c-850b-8dd1d4247ab8"",
    ""created_at"": ""2015-04-16T12:04:17+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""label-17"",
    ""provider"": ""provider-17""
  }
}";

            RetrieveServiceAuthTokenDeprecatedResponse obj = Utilities.DeserializeJson<RetrieveServiceAuthTokenDeprecatedResponse>(json);

            Assert.AreEqual("caefa4a5-7b98-423c-850b-8dd1d4247ab8", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_auth_tokens/caefa4a5-7b98-423c-850b-8dd1d4247ab8", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:17+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-17", TestUtil.ToTestableString(obj.Label), true);
            Assert.AreEqual("provider-17", TestUtil.ToTestableString(obj.Provider), true);
        }

        [TestMethod]
        public void TestFilterResultSetByProviderDeprecatedResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""8e8d9e86-dbcb-4049-8a70-5e022988f607"",
        ""url"": ""/v2/service_auth_tokens/8e8d9e86-dbcb-4049-8a70-5e022988f607"",
        ""created_at"": ""2015-04-16T12:04:17+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-26"",
        ""provider"": ""Face-Offer""
      }
    }
  ]
}";

            PagedResponseCollection<FilterResultSetByProviderDeprecatedResponse> page = Utilities.DeserializePage<FilterResultSetByProviderDeprecatedResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("8e8d9e86-dbcb-4049-8a70-5e022988f607", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_auth_tokens/8e8d9e86-dbcb-4049-8a70-5e022988f607", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-16T12:04:17+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-26", TestUtil.ToTestableString(page[0].Label), true);
            Assert.AreEqual("Face-Offer", TestUtil.ToTestableString(page[0].Provider), true);
        }
    }
}
