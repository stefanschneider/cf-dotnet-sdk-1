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
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServiceInstancesTest
    {

        [TestMethod]
        public void TestUpdateServiceInstanceRequest()
        {
            string json = @"{""service_plan_guid"":""4ff4dfc6-dbfc-41a3-a3f3-18e61c9fef28""}";

            UpdateServiceInstanceRequest request = new UpdateServiceInstanceRequest();

            request.ServicePlanGuid = new Guid("4ff4dfc6-dbfc-41a3-a3f3-18e61c9fef28");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateServiceInstanceRequest()
        {
            string json = @"{
  ""space_guid"": ""6b65de44-ce3e-444f-988c-b29ef16f2f07"",
  ""name"": ""my-service-instance"",
  ""service_plan_guid"": ""06f4e5a8-fc14-4d97-9bea-5bc92dec2cfa""
}";

            CreateServiceInstanceRequest request = new CreateServiceInstanceRequest();

            request.SpaceGuid = new Guid("6b65de44-ce3e-444f-988c-b29ef16f2f07");
            request.Name = "my-service-instance";
            request.ServicePlanGuid = new Guid("06f4e5a8-fc14-4d97-9bea-5bc92dec2cfa");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestMigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalRequest()
        {
            string json = @"{""service_plan_guid"":""a51bd3d3-99c1-4ca7-8cc6-ab5ac37eb40a""}";

            MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalRequest request = new MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalRequest();

            request.ServicePlanGuid = new Guid("a51bd3d3-99c1-4ca7-8cc6-ab5ac37eb40a");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
