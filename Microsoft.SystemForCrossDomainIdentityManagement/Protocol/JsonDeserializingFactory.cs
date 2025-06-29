//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    using System.Collections.Generic;

    public delegate Resource JsonDeserializingFactory(IReadOnlyDictionary<string, object> json);
}