// Copyright (c) Microsoft Corporation.// Licensed under the MIT license.

namespace Mod.SCIM
{
    using System.Collections.Generic;
    using System.Net.Http;

    public sealed class RetrievalRequest :
        SystemForCrossDomainIdentityManagementRequest<IResourceRetrievalParameters>
    {
        public RetrievalRequest(
            HttpRequestMessage request,
            IResourceRetrievalParameters payload,
            string correlationIdentifier,
            IReadOnlyCollection<IExtension> extensions)
            : base(request, payload, correlationIdentifier, extensions)
        {
        }
    }
}
