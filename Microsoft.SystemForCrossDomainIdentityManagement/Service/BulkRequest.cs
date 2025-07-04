﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    using System.Collections.Generic;
    using System.Net.Http;

        public sealed class BulkRequest : SystemForCrossDomainIdentityManagementRequest<BulkRequest2>
    {
        public BulkRequest(
            HttpRequestMessage request,
            BulkRequest2 payload,
            string correlationIdentifier,
            IReadOnlyCollection<IExtension> extensions)
            : base(request, payload, correlationIdentifier, extensions)
        {
        }
    }
}
