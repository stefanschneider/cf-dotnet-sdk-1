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

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class JobsEndpoint
{
        [TestMethod]
        public void RetrieveJobThatWasSuccessfulTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""0"",
    ""created_at"": ""1970-01-01T00:00:00+00:00"",
    ""url"": ""/v2/jobs/0""
  },
  ""entity"": {
    ""guid"": ""0"",
    ""status"": ""finished""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobThatWasSuccessful(guid).Result;


                Assert.AreEqual("0", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("1970-01-01T00:00:00+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/0", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("0", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("finished", TestUtil.ToTestableString(obj.Status), true);

            }
        }

        [TestMethod]
        public void RetrieveJobWithKnownFailureTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""8fe8e51c-4fa2-4d7c-9c5d-5894442ba2d5"",
    ""created_at"": ""2015-04-10T20:04:29+00:00"",
    ""url"": ""/v2/jobs/8fe8e51c-4fa2-4d7c-9c5d-5894442ba2d5""
  },
  ""entity"": {
    ""guid"": ""8fe8e51c-4fa2-4d7c-9c5d-5894442ba2d5"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""code"": 1001,
      ""description"": ""Request invalid due to parse error: arbitrary string"",
      ""error_code"": ""CF-MessageParseError""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobWithKnownFailure(guid).Result;


                Assert.AreEqual("8fe8e51c-4fa2-4d7c-9c5d-5894442ba2d5", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2015-04-10T20:04:29+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/8fe8e51c-4fa2-4d7c-9c5d-5894442ba2d5", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("8fe8e51c-4fa2-4d7c-9c5d-5894442ba2d5", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
                Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);

            }
        }

        [TestMethod]
        public void RetrieveJobThatIsQueuedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""f1310f10-87ce-4500-938f-dd5ebae380ef"",
    ""created_at"": ""2015-04-10T20:04:29+00:00"",
    ""url"": ""/v2/jobs/f1310f10-87ce-4500-938f-dd5ebae380ef""
  },
  ""entity"": {
    ""guid"": ""f1310f10-87ce-4500-938f-dd5ebae380ef"",
    ""status"": ""queued""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobThatIsQueued(guid).Result;


                Assert.AreEqual("f1310f10-87ce-4500-938f-dd5ebae380ef", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2015-04-10T20:04:29+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/f1310f10-87ce-4500-938f-dd5ebae380ef", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("f1310f10-87ce-4500-938f-dd5ebae380ef", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);

            }
        }

        [TestMethod]
        public void RetrieveJobWithUnknownFailureTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""ad61c022-0c8b-4ae0-be86-9b1e2d33314a"",
    ""created_at"": ""2015-04-10T20:04:29+00:00"",
    ""url"": ""/v2/jobs/ad61c022-0c8b-4ae0-be86-9b1e2d33314a""
  },
  ""entity"": {
    ""guid"": ""ad61c022-0c8b-4ae0-be86-9b1e2d33314a"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""error_code"": ""UnknownError"",
      ""description"": ""An unknown error occurred."",
      ""code"": 10001
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobWithUnknownFailure(guid).Result;


                Assert.AreEqual("ad61c022-0c8b-4ae0-be86-9b1e2d33314a", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2015-04-10T20:04:29+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/ad61c022-0c8b-4ae0-be86-9b1e2d33314a", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("ad61c022-0c8b-4ae0-be86-9b1e2d33314a", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
                Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);

            }
        }

    }
}