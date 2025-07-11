﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    using System;
    using System.Collections.Generic;

    public static class ProviderExtension
    {
        public static IReadOnlyCollection<IExtension> ReadExtensions(this IProvider provider)
        {
            if(null == provider)
            {
                throw new ArgumentNullException(nameof(provider));
            }
            IReadOnlyCollection<IExtension> result;
            try
            {
                result = provider.Extensions;
            }
            catch (NotImplementedException)
            {
                result = null;
            }
            return result;
        }
    }

}
