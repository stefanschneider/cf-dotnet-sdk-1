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

using System;
using System.CodeDom.Compiler;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CloudFoundry.CloudController.V2.Client.Data;
using CloudFoundry.CloudController.V2;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class RoutesTest
    {

    
        [TestMethod]
        public void TestListAllAppsForRouteResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""8f4e700d-628d-4d7e-aa15-63ca1dce37a7"",
        ""url"": ""/v2/apps/8f4e700d-628d-4d7e-aa15-63ca1dce37a7"",
        ""created_at"": ""2015-02-19T03:52:33+00:00"",
        ""updated_at"": ""2015-02-19T03:52:33+00:00""
      },
      ""entity"": {
        ""name"": ""name-22"",
        ""production"": false,
        ""space_guid"": ""fbffa74d-500b-49cf-874c-9de784d2c76f"",
        ""stack_guid"": ""ec1b1a6e-36a7-40fd-858b-0a51b4f44cb5"",
        ""buildpack"": null,
        ""detected_buildpack"": null,
        ""environment_json"": null,
        ""memory"": 1024,
        ""instances"": 1,
        ""disk_quota"": 1024,
        ""state"": ""STOPPED"",
        ""version"": ""716bb4f1-8102-4eb2-b439-8feb33417951"",
        ""command"": null,
        ""console"": false,
        ""debug"": null,
        ""staging_task_id"": null,
        ""package_state"": ""PENDING"",
        ""health_check_type"": ""port"",
        ""health_check_timeout"": null,
        ""staging_failed_reason"": null,
        ""docker_image"": null,
        ""package_updated_at"": ""2015-02-19T03:52:33+00:00"",
        ""detected_start_command"": """",
        ""space_url"": ""/v2/spaces/fbffa74d-500b-49cf-874c-9de784d2c76f"",
        ""stack_url"": ""/v2/stacks/ec1b1a6e-36a7-40fd-858b-0a51b4f44cb5"",
        ""events_url"": ""/v2/apps/8f4e700d-628d-4d7e-aa15-63ca1dce37a7/events"",
        ""service_bindings_url"": ""/v2/apps/8f4e700d-628d-4d7e-aa15-63ca1dce37a7/service_bindings"",
        ""routes_url"": ""/v2/apps/8f4e700d-628d-4d7e-aa15-63ca1dce37a7/routes""
      }
    }
  ]
}";
    
            PagedResponse<ListAllAppsForRouteResponse> page = Util.DeserializePage<ListAllAppsForRouteResponse>(json);
        
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
        
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
        
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PrevUrl), true);
        
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
        
            
        
            
            
                Assert.AreEqual("8f4e700d-628d-4d7e-aa15-63ca1dce37a7", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/apps/8f4e700d-628d-4d7e-aa15-63ca1dce37a7", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-02-19T03:52:33+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-02-19T03:52:33+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
                  Assert.AreEqual("name-22", TestUtil.ToTestableString(page[0].Name), true);
                  Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Production), true);
                  Assert.AreEqual("fbffa74d-500b-49cf-874c-9de784d2c76f", TestUtil.ToTestableString(page[0].SpaceGuid), true);
                  Assert.AreEqual("ec1b1a6e-36a7-40fd-858b-0a51b4f44cb5", TestUtil.ToTestableString(page[0].StackGuid), true);
                  Assert.AreEqual("", TestUtil.ToTestableString(page[0].Buildpack), true);
                  Assert.AreEqual("", TestUtil.ToTestableString(page[0].DetectedBuildpack), true);
                  Assert.AreEqual("", TestUtil.ToTestableString(page[0].EnvironmentJson), true);
                  Assert.AreEqual("1024", TestUtil.ToTestableString(page[0].Memory), true);
                  Assert.AreEqual("1", TestUtil.ToTestableString(page[0].Instances), true);
                  Assert.AreEqual("1024", TestUtil.ToTestableString(page[0].DiskQuota), true);
                  Assert.AreEqual("STOPPED", TestUtil.ToTestableString(page[0].State), true);
                  Assert.AreEqual("716bb4f1-8102-4eb2-b439-8feb33417951", TestUtil.ToTestableString(page[0].Version), true);
                  Assert.AreEqual("", TestUtil.ToTestableString(page[0].Command), true);
                  Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Console), true);
                  Assert.AreEqual("", TestUtil.ToTestableString(page[0].Debug), true);
                  Assert.AreEqual("", TestUtil.ToTestableString(page[0].StagingTaskId), true);
                  Assert.AreEqual("PENDING", TestUtil.ToTestableString(page[0].PackageState), true);
                  Assert.AreEqual("port", TestUtil.ToTestableString(page[0].HealthCheckType), true);
                  Assert.AreEqual("", TestUtil.ToTestableString(page[0].HealthCheckTimeout), true);
                  Assert.AreEqual("", TestUtil.ToTestableString(page[0].StagingFailedReason), true);
                  Assert.AreEqual("", TestUtil.ToTestableString(page[0].DockerImage), true);
                  Assert.AreEqual("2015-02-19T03:52:33+00:00", TestUtil.ToTestableString(page[0].PackageUpdatedAt), true);
                  Assert.AreEqual("", TestUtil.ToTestableString(page[0].DetectedStartCommand), true);
                  Assert.AreEqual("/v2/spaces/fbffa74d-500b-49cf-874c-9de784d2c76f", TestUtil.ToTestableString(page[0].SpaceUrl), true);
                  Assert.AreEqual("/v2/stacks/ec1b1a6e-36a7-40fd-858b-0a51b4f44cb5", TestUtil.ToTestableString(page[0].StackUrl), true);
                  Assert.AreEqual("/v2/apps/8f4e700d-628d-4d7e-aa15-63ca1dce37a7/events", TestUtil.ToTestableString(page[0].EventsUrl), true);
                  Assert.AreEqual("/v2/apps/8f4e700d-628d-4d7e-aa15-63ca1dce37a7/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
                  Assert.AreEqual("/v2/apps/8f4e700d-628d-4d7e-aa15-63ca1dce37a7/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
               
               
            
    
        }

    
        [TestMethod]
        public void TestRetrieveRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""0b76b9d2-f4e0-4359-86d5-2831bb2e7580"",
    ""url"": ""/v2/routes/0b76b9d2-f4e0-4359-86d5-2831bb2e7580"",
    ""created_at"": ""2015-02-19T03:52:33+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-5"",
    ""domain_guid"": ""fded3425-6388-491f-b77c-71b2c61c7cd0"",
    ""space_guid"": ""678dd106-4581-4819-bf91-a9e33be98f3d"",
    ""domain_url"": ""/v2/domains/fded3425-6388-491f-b77c-71b2c61c7cd0"",
    ""space_url"": ""/v2/spaces/678dd106-4581-4819-bf91-a9e33be98f3d"",
    ""apps_url"": ""/v2/routes/0b76b9d2-f4e0-4359-86d5-2831bb2e7580/apps""
  }
}";
    
            RetrieveRouteResponse obj = Util.DeserializeJson<RetrieveRouteResponse>(json);
        
            Assert.AreEqual("0b76b9d2-f4e0-4359-86d5-2831bb2e7580", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/0b76b9d2-f4e0-4359-86d5-2831bb2e7580", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:33+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-5", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("fded3425-6388-491f-b77c-71b2c61c7cd0", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("678dd106-4581-4819-bf91-a9e33be98f3d", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("/v2/domains/fded3425-6388-491f-b77c-71b2c61c7cd0", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/678dd106-4581-4819-bf91-a9e33be98f3d", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/0b76b9d2-f4e0-4359-86d5-2831bb2e7580/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
            
            
        }

    
        [TestMethod]
        public void TestUpdateRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""d40b8e30-36a9-4867-8817-f9ddca21a54b"",
    ""url"": ""/v2/routes/d40b8e30-36a9-4867-8817-f9ddca21a54b"",
    ""created_at"": ""2015-02-19T03:52:32+00:00"",
    ""updated_at"": ""2015-02-19T03:52:32+00:00""
  },
  ""entity"": {
    ""host"": ""new_host"",
    ""domain_guid"": ""51a7b9a2-42ef-4722-bdee-501cab163f9c"",
    ""space_guid"": ""d15a3f64-d4b0-4de2-a4d7-b83df096fdde"",
    ""domain_url"": ""/v2/domains/51a7b9a2-42ef-4722-bdee-501cab163f9c"",
    ""space_url"": ""/v2/spaces/d15a3f64-d4b0-4de2-a4d7-b83df096fdde"",
    ""apps_url"": ""/v2/routes/d40b8e30-36a9-4867-8817-f9ddca21a54b/apps""
  }
}";
    
            UpdateRouteResponse obj = Util.DeserializeJson<UpdateRouteResponse>(json);
        
            Assert.AreEqual("d40b8e30-36a9-4867-8817-f9ddca21a54b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/d40b8e30-36a9-4867-8817-f9ddca21a54b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:32+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-02-19T03:52:32+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("new_host", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("51a7b9a2-42ef-4722-bdee-501cab163f9c", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("d15a3f64-d4b0-4de2-a4d7-b83df096fdde", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("/v2/domains/51a7b9a2-42ef-4722-bdee-501cab163f9c", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/d15a3f64-d4b0-4de2-a4d7-b83df096fdde", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/d40b8e30-36a9-4867-8817-f9ddca21a54b/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
            
            
        }

    
        [TestMethod]
        public void TestRemoveAppFromRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""dbd703d7-96dd-47d6-b737-45c52a6c778b"",
    ""url"": ""/v2/routes/dbd703d7-96dd-47d6-b737-45c52a6c778b"",
    ""created_at"": ""2015-02-19T03:52:33+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-8"",
    ""domain_guid"": ""86413c24-0684-49e2-a4bd-6bb1299e65ca"",
    ""space_guid"": ""104c8143-f373-4aee-8a77-6727885376ad"",
    ""domain_url"": ""/v2/domains/86413c24-0684-49e2-a4bd-6bb1299e65ca"",
    ""space_url"": ""/v2/spaces/104c8143-f373-4aee-8a77-6727885376ad"",
    ""apps_url"": ""/v2/routes/dbd703d7-96dd-47d6-b737-45c52a6c778b/apps""
  }
}";
    
            RemoveAppFromRouteResponse obj = Util.DeserializeJson<RemoveAppFromRouteResponse>(json);
        
            Assert.AreEqual("dbd703d7-96dd-47d6-b737-45c52a6c778b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/dbd703d7-96dd-47d6-b737-45c52a6c778b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:33+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-8", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("86413c24-0684-49e2-a4bd-6bb1299e65ca", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("104c8143-f373-4aee-8a77-6727885376ad", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("/v2/domains/86413c24-0684-49e2-a4bd-6bb1299e65ca", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/104c8143-f373-4aee-8a77-6727885376ad", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/dbd703d7-96dd-47d6-b737-45c52a6c778b/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
            
            
        }

    
        [TestMethod]
        public void TestCreateRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""f800abdb-f484-4352-8e0f-5b8bea22c1bd"",
    ""url"": ""/v2/routes/f800abdb-f484-4352-8e0f-5b8bea22c1bd"",
    ""created_at"": ""2015-02-19T03:52:32+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": """",
    ""domain_guid"": ""2d7c75b6-3941-4346-bc7b-448e5262e60a"",
    ""space_guid"": ""b4f0a97b-4adb-4312-a6cf-0cc28642349e"",
    ""domain_url"": ""/v2/domains/2d7c75b6-3941-4346-bc7b-448e5262e60a"",
    ""space_url"": ""/v2/spaces/b4f0a97b-4adb-4312-a6cf-0cc28642349e"",
    ""apps_url"": ""/v2/routes/f800abdb-f484-4352-8e0f-5b8bea22c1bd/apps""
  }
}";
    
            CreateRouteResponse obj = Util.DeserializeJson<CreateRouteResponse>(json);
        
            Assert.AreEqual("f800abdb-f484-4352-8e0f-5b8bea22c1bd", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/f800abdb-f484-4352-8e0f-5b8bea22c1bd", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:32+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("2d7c75b6-3941-4346-bc7b-448e5262e60a", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("b4f0a97b-4adb-4312-a6cf-0cc28642349e", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("/v2/domains/2d7c75b6-3941-4346-bc7b-448e5262e60a", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/b4f0a97b-4adb-4312-a6cf-0cc28642349e", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/f800abdb-f484-4352-8e0f-5b8bea22c1bd/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
            
            
        }

    
        [TestMethod]
        public void TestAssociateAppWithRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""7be67514-ee87-4e99-9f98-000a1ce1cfe6"",
    ""url"": ""/v2/routes/7be67514-ee87-4e99-9f98-000a1ce1cfe6"",
    ""created_at"": ""2015-02-19T03:52:33+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-9"",
    ""domain_guid"": ""d8114a52-071f-412a-866a-83b34232fecd"",
    ""space_guid"": ""90e196e0-5a88-458d-b6fa-d2b0fc3e5b7e"",
    ""domain_url"": ""/v2/domains/d8114a52-071f-412a-866a-83b34232fecd"",
    ""space_url"": ""/v2/spaces/90e196e0-5a88-458d-b6fa-d2b0fc3e5b7e"",
    ""apps_url"": ""/v2/routes/7be67514-ee87-4e99-9f98-000a1ce1cfe6/apps""
  }
}";
    
            AssociateAppWithRouteResponse obj = Util.DeserializeJson<AssociateAppWithRouteResponse>(json);
        
            Assert.AreEqual("7be67514-ee87-4e99-9f98-000a1ce1cfe6", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/7be67514-ee87-4e99-9f98-000a1ce1cfe6", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:33+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-9", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("d8114a52-071f-412a-866a-83b34232fecd", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("90e196e0-5a88-458d-b6fa-d2b0fc3e5b7e", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("/v2/domains/d8114a52-071f-412a-866a-83b34232fecd", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/90e196e0-5a88-458d-b6fa-d2b0fc3e5b7e", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/7be67514-ee87-4e99-9f98-000a1ce1cfe6/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
            
            
        }

    
        [TestMethod]
        public void TestListAllRoutesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""3abbf092-21e5-4cbb-af66-f7c8e96ace38"",
        ""url"": ""/v2/routes/3abbf092-21e5-4cbb-af66-f7c8e96ace38"",
        ""created_at"": ""2015-02-19T03:52:32+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""host"": ""host-1"",
        ""domain_guid"": ""61c0085f-1216-4a47-9615-a5c65e143be4"",
        ""space_guid"": ""7e700859-cb9f-46fa-ae5c-f59043a390d7"",
        ""domain_url"": ""/v2/domains/61c0085f-1216-4a47-9615-a5c65e143be4"",
        ""space_url"": ""/v2/spaces/7e700859-cb9f-46fa-ae5c-f59043a390d7"",
        ""apps_url"": ""/v2/routes/3abbf092-21e5-4cbb-af66-f7c8e96ace38/apps""
      }
    }
  ]
}";
    
            PagedResponse<ListAllRoutesResponse> page = Util.DeserializePage<ListAllRoutesResponse>(json);
        
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
        
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
        
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PrevUrl), true);
        
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
        
            
        
            
            
                Assert.AreEqual("3abbf092-21e5-4cbb-af66-f7c8e96ace38", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/3abbf092-21e5-4cbb-af66-f7c8e96ace38", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-02-19T03:52:32+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
                  Assert.AreEqual("host-1", TestUtil.ToTestableString(page[0].Host), true);
                  Assert.AreEqual("61c0085f-1216-4a47-9615-a5c65e143be4", TestUtil.ToTestableString(page[0].DomainGuid), true);
                  Assert.AreEqual("7e700859-cb9f-46fa-ae5c-f59043a390d7", TestUtil.ToTestableString(page[0].SpaceGuid), true);
                  Assert.AreEqual("/v2/domains/61c0085f-1216-4a47-9615-a5c65e143be4", TestUtil.ToTestableString(page[0].DomainUrl), true);
                  Assert.AreEqual("/v2/spaces/7e700859-cb9f-46fa-ae5c-f59043a390d7", TestUtil.ToTestableString(page[0].SpaceUrl), true);
                  Assert.AreEqual("/v2/routes/3abbf092-21e5-4cbb-af66-f7c8e96ace38/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
               
               
            
    
        }

    }
}