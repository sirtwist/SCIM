//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    using System.Collections.Generic;

    public interface IJsonSerializable
    {
        Dictionary<string, object> ToJson();
        string Serialize();

    }
}
