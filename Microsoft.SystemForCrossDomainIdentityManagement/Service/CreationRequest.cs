// Copyright (c) Microsoft Corporation.// Licensed under the MIT license.

namespace Mod.SCIM
{
    using System.Collections.Generic;
    using System.Net.Http;

    public sealed class CreationRequest : SystemForCrossDomainIdentityManagementRequest<Resource>
    {
        public CreationRequest(
            HttpRequestMessage request,
            Resource payload,
            string correlationIdentifier,
            IReadOnlyCollection<IExtension> extensions)
            : base(request, payload, correlationIdentifier, extensions)
        {
        }
    }
}
