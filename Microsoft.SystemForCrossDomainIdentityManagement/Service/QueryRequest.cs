// Copyright (c) Microsoft Corporation.// Licensed under the MIT license.

namespace Mod.SCIM
{
    using System.Collections.Generic;
    using System.Net.Http;

    public sealed class QueryRequest :
        SystemForCrossDomainIdentityManagementRequest<IQueryParameters>
    {
        public QueryRequest(
            HttpRequestMessage request,
            IQueryParameters payload,
            string correlationIdentifier,
            IReadOnlyCollection<IExtension> extensions)
            : base(request, payload, correlationIdentifier, extensions)
        {
        }
    }
}
