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
    public class RoutesEndpoint
{
        [TestMethod]
        public void ListAllRoutesTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""19e43fc0-72ad-4217-92a1-3ab3151df471"",
        ""url"": ""/v2/routes/1c7ec5c5-5223-46dd-bd81-e14861229acd"",
        ""created_at"": ""2016-05-26T11:34:52Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""host"": ""host-30"",
        ""path"": """",
        ""domain_guid"": ""19e43fc0-72ad-4217-92a1-3ab3151df471"",
        ""space_guid"": ""19e43fc0-72ad-4217-92a1-3ab3151df471"",
        ""service_instance_guid"": ""19e43fc0-72ad-4217-92a1-3ab3151df471"",
        ""port"": null,
        ""domain_url"": ""/v2/domains/aaa325f4-120f-4f19-8e28-4c95dd0d2172"",
        ""space_url"": ""/v2/spaces/4db7ade4-8ae7-4755-b8cd-e7341931c92c"",
        ""service_instance_url"": ""/v2/service_instances/1647b375-5a96-44dd-b0ad-9b770df87904"",
        ""apps_url"": ""/v2/routes/1c7ec5c5-5223-46dd-bd81-e14861229acd/apps"",
        ""route_mappings_url"": ""/v2/routes/1c7ec5c5-5223-46dd-bd81-e14861229acd/route_mappings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Routes.ListAllRoutes().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("19e43fc0-72ad-4217-92a1-3ab3151df471", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/1c7ec5c5-5223-46dd-bd81-e14861229acd", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-26T11:34:52Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-30", TestUtil.ToTestableString(obj[0].Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Path), true);
                Assert.AreEqual("19e43fc0-72ad-4217-92a1-3ab3151df471", TestUtil.ToTestableString(obj[0].DomainGuid), true);
                Assert.AreEqual("19e43fc0-72ad-4217-92a1-3ab3151df471", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("19e43fc0-72ad-4217-92a1-3ab3151df471", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Port), true);
                Assert.AreEqual("/v2/domains/aaa325f4-120f-4f19-8e28-4c95dd0d2172", TestUtil.ToTestableString(obj[0].DomainUrl), true);
                Assert.AreEqual("/v2/spaces/4db7ade4-8ae7-4755-b8cd-e7341931c92c", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/service_instances/1647b375-5a96-44dd-b0ad-9b770df87904", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);
                Assert.AreEqual("/v2/routes/1c7ec5c5-5223-46dd-bd81-e14861229acd/apps", TestUtil.ToTestableString(obj[0].AppsUrl), true);
                Assert.AreEqual("/v2/routes/1c7ec5c5-5223-46dd-bd81-e14861229acd/route_mappings", TestUtil.ToTestableString(obj[0].RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void CheckRouteExistsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? domain_guid = Guid.NewGuid();

                dynamic host = null;

                dynamic path = null;

                dynamic port = null;


                cfClient.Routes.CheckRouteExists(domain_guid, host, path, port).Wait();

            }
        }

        [TestMethod]
        public void DeleteRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                dynamic recursive = null;


                cfClient.Routes.DeleteRoute(guid, recursive).Wait();

            }
        }

        [TestMethod]
        public void RemoveAppFromRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? app_guid = Guid.NewGuid();


                cfClient.Routes.RemoveAppFromRoute(guid, app_guid).Wait();

            }
        }

        [TestMethod]
        public void AssociateAppWithRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""8cc86367-d71f-478f-a27e-c858e9f34441"",
    ""url"": ""/v2/routes/141c9e16-cab0-48b4-95dc-6deddb5ce3f5"",
    ""created_at"": ""2016-05-26T11:34:53Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-34"",
    ""path"": """",
    ""domain_guid"": ""8cc86367-d71f-478f-a27e-c858e9f34441"",
    ""space_guid"": ""8cc86367-d71f-478f-a27e-c858e9f34441"",
    ""service_instance_guid"": null,
    ""port"": null,
    ""domain_url"": ""/v2/domains/4b79072e-35fa-4489-8b4e-a97fb3ba27ee"",
    ""space_url"": ""/v2/spaces/8e91021c-86db-4833-8e00-338a3e3cd646"",
    ""apps_url"": ""/v2/routes/141c9e16-cab0-48b4-95dc-6deddb5ce3f5/apps"",
    ""route_mappings_url"": ""/v2/routes/141c9e16-cab0-48b4-95dc-6deddb5ce3f5/route_mappings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? app_guid = Guid.NewGuid();


                var obj = cfClient.Routes.AssociateAppWithRoute(guid, app_guid).Result;


                Assert.AreEqual("8cc86367-d71f-478f-a27e-c858e9f34441", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/141c9e16-cab0-48b4-95dc-6deddb5ce3f5", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-26T11:34:53Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-34", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
                Assert.AreEqual("8cc86367-d71f-478f-a27e-c858e9f34441", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("8cc86367-d71f-478f-a27e-c858e9f34441", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Port), true);
                Assert.AreEqual("/v2/domains/4b79072e-35fa-4489-8b4e-a97fb3ba27ee", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/8e91021c-86db-4833-8e00-338a3e3cd646", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/141c9e16-cab0-48b4-95dc-6deddb5ce3f5/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
                Assert.AreEqual("/v2/routes/141c9e16-cab0-48b4-95dc-6deddb5ce3f5/route_mappings", TestUtil.ToTestableString(obj.RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllAppsForRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""c7a655ca-9fe8-4470-942f-1f39f55ee867"",
        ""url"": ""/v2/apps/75d9acb5-8b5d-4223-b1e2-2c6609bc3f54"",
        ""created_at"": ""2016-05-26T11:34:53Z"",
        ""updated_at"": ""2016-05-26T11:34:53Z""
      },
      ""entity"": {
        ""name"": ""name-2506"",
        ""production"": false,
        ""space_guid"": ""c7a655ca-9fe8-4470-942f-1f39f55ee867"",
        ""stack_guid"": ""c7a655ca-9fe8-4470-942f-1f39f55ee867"",
        ""buildpack"": null,
        ""detected_buildpack"": null,
        ""environment_json"": null,
        ""memory"": 1024,
        ""instances"": 1,
        ""disk_quota"": 1024,
        ""state"": ""STOPPED"",
        ""version"": ""984eb699-e23a-4604-90b5-7b67c901dfce"",
        ""command"": null,
        ""console"": false,
        ""debug"": null,
        ""staging_task_id"": null,
        ""package_state"": ""PENDING"",
        ""health_check_type"": ""port"",
        ""health_check_timeout"": null,
        ""staging_failed_reason"": null,
        ""staging_failed_description"": null,
        ""diego"": false,
        ""docker_image"": null,
        ""package_updated_at"": ""2016-05-26T11:34:53Z"",
        ""detected_start_command"": """",
        ""enable_ssh"": true,
        ""docker_credentials_json"": {
          ""redacted_message"": ""[PRIVATE DATA HIDDEN]""
        },
        ""ports"": null,
        ""space_url"": ""/v2/spaces/ad3a6b15-8f31-49c6-9eb2-0fefb5c4b34e"",
        ""stack_url"": ""/v2/stacks/e2a7f339-eda6-4e85-8c6a-ecb11c1b6a29"",
        ""routes_url"": ""/v2/apps/75d9acb5-8b5d-4223-b1e2-2c6609bc3f54/routes"",
        ""events_url"": ""/v2/apps/75d9acb5-8b5d-4223-b1e2-2c6609bc3f54/events"",
        ""service_bindings_url"": ""/v2/apps/75d9acb5-8b5d-4223-b1e2-2c6609bc3f54/service_bindings"",
        ""route_mappings_url"": ""/v2/apps/75d9acb5-8b5d-4223-b1e2-2c6609bc3f54/route_mappings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Routes.ListAllAppsForRoute(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("c7a655ca-9fe8-4470-942f-1f39f55ee867", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/apps/75d9acb5-8b5d-4223-b1e2-2c6609bc3f54", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-26T11:34:53Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-05-26T11:34:53Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2506", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Production), true);
                Assert.AreEqual("c7a655ca-9fe8-4470-942f-1f39f55ee867", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("c7a655ca-9fe8-4470-942f-1f39f55ee867", TestUtil.ToTestableString(obj[0].StackGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Buildpack), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DetectedBuildpack), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EnvironmentJson), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj[0].Memory), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj[0].Instances), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj[0].DiskQuota), true);
                Assert.AreEqual("STOPPED", TestUtil.ToTestableString(obj[0].State), true);
                Assert.AreEqual("984eb699-e23a-4604-90b5-7b67c901dfce", TestUtil.ToTestableString(obj[0].Version), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Command), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Console), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Debug), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].StagingTaskId), true);
                Assert.AreEqual("PENDING", TestUtil.ToTestableString(obj[0].PackageState), true);
                Assert.AreEqual("port", TestUtil.ToTestableString(obj[0].HealthCheckType), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].HealthCheckTimeout), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].StagingFailedReason), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].StagingFailedDescription), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Diego), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DockerImage), true);
                Assert.AreEqual("2016-05-26T11:34:53Z", TestUtil.ToTestableString(obj[0].PackageUpdatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DetectedStartCommand), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].EnableSsh), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Ports), true);
                Assert.AreEqual("/v2/spaces/ad3a6b15-8f31-49c6-9eb2-0fefb5c4b34e", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/stacks/e2a7f339-eda6-4e85-8c6a-ecb11c1b6a29", TestUtil.ToTestableString(obj[0].StackUrl), true);
                Assert.AreEqual("/v2/apps/75d9acb5-8b5d-4223-b1e2-2c6609bc3f54/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);
                Assert.AreEqual("/v2/apps/75d9acb5-8b5d-4223-b1e2-2c6609bc3f54/events", TestUtil.ToTestableString(obj[0].EventsUrl), true);
                Assert.AreEqual("/v2/apps/75d9acb5-8b5d-4223-b1e2-2c6609bc3f54/service_bindings", TestUtil.ToTestableString(obj[0].ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/apps/75d9acb5-8b5d-4223-b1e2-2c6609bc3f54/route_mappings", TestUtil.ToTestableString(obj[0].RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void CheckHttpRouteExistsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? domain_guid = Guid.NewGuid();

                dynamic host = null;

                dynamic path = null;


                cfClient.Routes.CheckHttpRouteExists(domain_guid, host, path).Wait();

            }
        }

        [TestMethod]
        public void CreateRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""437fa33e-b585-409a-b081-1ba347e0be34"",
    ""url"": ""/v2/routes/b7092a6c-8dd6-4c4d-a2a9-b430e4783912"",
    ""created_at"": ""2016-05-26T11:34:52Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": """",
    ""path"": """",
    ""domain_guid"": ""437fa33e-b585-409a-b081-1ba347e0be34"",
    ""space_guid"": ""437fa33e-b585-409a-b081-1ba347e0be34"",
    ""service_instance_guid"": null,
    ""port"": 10000,
    ""domain_url"": ""/v2/domains/5552b0e0-82d9-4778-a18a-259486be27ac"",
    ""space_url"": ""/v2/spaces/c851bce1-0e4b-4f67-80fc-23e21ccdc99c"",
    ""apps_url"": ""/v2/routes/b7092a6c-8dd6-4c4d-a2a9-b430e4783912/apps"",
    ""route_mappings_url"": ""/v2/routes/b7092a6c-8dd6-4c4d-a2a9-b430e4783912/route_mappings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateRouteRequest value = new CreateRouteRequest();


                var obj = cfClient.Routes.CreateRoute(value).Result;


                Assert.AreEqual("437fa33e-b585-409a-b081-1ba347e0be34", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/b7092a6c-8dd6-4c4d-a2a9-b430e4783912", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-26T11:34:52Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
                Assert.AreEqual("437fa33e-b585-409a-b081-1ba347e0be34", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("437fa33e-b585-409a-b081-1ba347e0be34", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("10000", TestUtil.ToTestableString(obj.Port), true);
                Assert.AreEqual("/v2/domains/5552b0e0-82d9-4778-a18a-259486be27ac", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/c851bce1-0e4b-4f67-80fc-23e21ccdc99c", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/b7092a6c-8dd6-4c4d-a2a9-b430e4783912/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
                Assert.AreEqual("/v2/routes/b7092a6c-8dd6-4c4d-a2a9-b430e4783912/route_mappings", TestUtil.ToTestableString(obj.RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void RetrieveRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""5e8aa1ba-f649-40df-84f2-b40c196a21a7"",
    ""url"": ""/v2/routes/c984eeb2-c217-4155-8d9d-5f18a8651cc2"",
    ""created_at"": ""2016-05-26T11:34:52Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-32"",
    ""path"": """",
    ""domain_guid"": ""5e8aa1ba-f649-40df-84f2-b40c196a21a7"",
    ""space_guid"": ""5e8aa1ba-f649-40df-84f2-b40c196a21a7"",
    ""service_instance_guid"": ""5e8aa1ba-f649-40df-84f2-b40c196a21a7"",
    ""port"": null,
    ""domain_url"": ""/v2/domains/bbcf87a2-bd48-4a83-a762-3bbff7626769"",
    ""space_url"": ""/v2/spaces/f911cae3-b363-474a-ba37-9e5b3a386024"",
    ""service_instance_url"": ""/v2/service_instances/ff272e83-5861-4cb5-a104-7a1db67ec4f3"",
    ""apps_url"": ""/v2/routes/c984eeb2-c217-4155-8d9d-5f18a8651cc2/apps"",
    ""route_mappings_url"": ""/v2/routes/c984eeb2-c217-4155-8d9d-5f18a8651cc2/route_mappings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Routes.RetrieveRoute(guid).Result;


                Assert.AreEqual("5e8aa1ba-f649-40df-84f2-b40c196a21a7", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/c984eeb2-c217-4155-8d9d-5f18a8651cc2", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-26T11:34:52Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-32", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
                Assert.AreEqual("5e8aa1ba-f649-40df-84f2-b40c196a21a7", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("5e8aa1ba-f649-40df-84f2-b40c196a21a7", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("5e8aa1ba-f649-40df-84f2-b40c196a21a7", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Port), true);
                Assert.AreEqual("/v2/domains/bbcf87a2-bd48-4a83-a762-3bbff7626769", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/f911cae3-b363-474a-ba37-9e5b3a386024", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/service_instances/ff272e83-5861-4cb5-a104-7a1db67ec4f3", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);
                Assert.AreEqual("/v2/routes/c984eeb2-c217-4155-8d9d-5f18a8651cc2/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
                Assert.AreEqual("/v2/routes/c984eeb2-c217-4155-8d9d-5f18a8651cc2/route_mappings", TestUtil.ToTestableString(obj.RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void UpdateRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""e70645dd-c0dd-44a2-b7a0-48f20c091245"",
    ""url"": ""/v2/routes/9638e99b-0873-4e7a-8340-2d68a73a39ba"",
    ""created_at"": ""2016-05-26T11:34:52Z"",
    ""updated_at"": ""2016-05-26T11:34:52Z""
  },
  ""entity"": {
    ""host"": ""host-29"",
    ""path"": """",
    ""domain_guid"": ""e70645dd-c0dd-44a2-b7a0-48f20c091245"",
    ""space_guid"": ""e70645dd-c0dd-44a2-b7a0-48f20c091245"",
    ""service_instance_guid"": null,
    ""port"": 10000,
    ""domain_url"": ""/v2/domains/beb370a3-6384-4dfc-a22f-88f188ee0179"",
    ""space_url"": ""/v2/spaces/150a6d24-cc19-4c06-a603-da7a23fd4a91"",
    ""apps_url"": ""/v2/routes/9638e99b-0873-4e7a-8340-2d68a73a39ba/apps"",
    ""route_mappings_url"": ""/v2/routes/9638e99b-0873-4e7a-8340-2d68a73a39ba/route_mappings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateRouteRequest value = new UpdateRouteRequest();


                var obj = cfClient.Routes.UpdateRoute(guid, value).Result;


                Assert.AreEqual("e70645dd-c0dd-44a2-b7a0-48f20c091245", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/9638e99b-0873-4e7a-8340-2d68a73a39ba", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-26T11:34:52Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-05-26T11:34:52Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-29", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
                Assert.AreEqual("e70645dd-c0dd-44a2-b7a0-48f20c091245", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("e70645dd-c0dd-44a2-b7a0-48f20c091245", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("10000", TestUtil.ToTestableString(obj.Port), true);
                Assert.AreEqual("/v2/domains/beb370a3-6384-4dfc-a22f-88f188ee0179", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/150a6d24-cc19-4c06-a603-da7a23fd4a91", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/9638e99b-0873-4e7a-8340-2d68a73a39ba/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
                Assert.AreEqual("/v2/routes/9638e99b-0873-4e7a-8340-2d68a73a39ba/route_mappings", TestUtil.ToTestableString(obj.RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllRouteMappingsForRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""c59b62ac-0d1a-4f83-ba89-9fa6a6f3e6c3"",
        ""url"": ""/v2/route_mappings/794e1b18-88e0-4258-9012-88d50cb50676"",
        ""created_at"": ""2016-05-26T11:34:53Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_port"": null,
        ""app_guid"": ""c59b62ac-0d1a-4f83-ba89-9fa6a6f3e6c3"",
        ""route_guid"": ""c59b62ac-0d1a-4f83-ba89-9fa6a6f3e6c3"",
        ""app_url"": ""/v2/apps/8c336e37-364f-4e8c-ad94-6e7ad654fa88"",
        ""route_url"": ""/v2/routes/5ece0eb9-ad46-43df-8ac6-950da318eb6f""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Routes.ListAllRouteMappingsForRoute(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("c59b62ac-0d1a-4f83-ba89-9fa6a6f3e6c3", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/route_mappings/794e1b18-88e0-4258-9012-88d50cb50676", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-26T11:34:53Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].AppPort), true);
                Assert.AreEqual("c59b62ac-0d1a-4f83-ba89-9fa6a6f3e6c3", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("c59b62ac-0d1a-4f83-ba89-9fa6a6f3e6c3", TestUtil.ToTestableString(obj[0].RouteGuid), true);
                Assert.AreEqual("/v2/apps/8c336e37-364f-4e8c-ad94-6e7ad654fa88", TestUtil.ToTestableString(obj[0].AppUrl), true);
                Assert.AreEqual("/v2/routes/5ece0eb9-ad46-43df-8ac6-950da318eb6f", TestUtil.ToTestableString(obj[0].RouteUrl), true);

            }
        }

    }
}