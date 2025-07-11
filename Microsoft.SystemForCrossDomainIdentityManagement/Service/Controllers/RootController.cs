// Copyright (c) Microsoft Corporation.// Licensed under the MIT license.

namespace Mod.SCIM
{
    using System;

    public sealed class RootController : ControllerTemplate<Resource>
    {
        public RootController(IProvider provider, IMonitor monitor)
            : base(provider, monitor)
        {
        }

        protected override IProviderAdapter<Resource> AdaptProvider(IProvider provider)
        {
            if (null == provider)
            {
                throw new ArgumentNullException(nameof(provider));
            }

            IProviderAdapter<Resource> result = new RootProviderAdapter(provider);
            return result;
        }
    }
}
