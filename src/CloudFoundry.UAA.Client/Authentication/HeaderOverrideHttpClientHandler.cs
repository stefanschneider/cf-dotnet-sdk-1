using CloudFoundry.CloudController.Common.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CloudFoundry.UAA.Authentication
{
    class HeaderOverrideHttpClientHandler : PlatformBaseHttpClientHandler
    {
        public string OverrideAcceptHeader { get; set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;


            if (!string.IsNullOrEmpty(this.OverrideAcceptHeader))
            {
                request.Headers.Add("Accept", this.OverrideAcceptHeader);
            }

            response = await base.SendAsync(request, cancellationToken);
            return response;
        }

    }
}
