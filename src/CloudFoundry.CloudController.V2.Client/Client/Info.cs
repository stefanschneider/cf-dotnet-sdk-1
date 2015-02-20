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
using System;
using System.CodeDom.Compiler;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class InfoEndpoint : BaseEndpoint
    {
        public InfoEndpoint(CloudFoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }

        /// <summary>
        /// Get Info
        /// </summary>

        public async Task<GetInfoResponse> GetInfo()
        {
            string route = "/v2/info";

            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;

            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());

            var response = await this.SendAsync(client);

            return Utilities.DeserializeJson<GetInfoResponse>(await response.ReadContentAsStringAsync());
        }
    }
}