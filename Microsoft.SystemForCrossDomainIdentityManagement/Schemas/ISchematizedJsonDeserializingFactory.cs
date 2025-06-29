//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    using System.Collections.Generic;

    public interface ISchematizedJsonDeserializingFactory<TOutput> where TOutput : Schematized
    {
        TOutput Create(IReadOnlyDictionary<string, object> json);
    }
}