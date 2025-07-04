// Copyright (c) Microsoft Corporation.// Licensed under the MIT license.

namespace Mod.SCIM
{
    using System.Collections.Generic;

    public abstract class DeserializingFactory<TResource> :
            JsonDeserializingFactory<TResource>,
            IResourceJsonDeserializingFactory<TResource> where TResource : Resource, new()
    {
        public new TResource Create(IReadOnlyDictionary<string, object> json)
        {
            TResource result = base.Create(json);
            return result;
        }
    }
}
