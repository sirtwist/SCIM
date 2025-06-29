//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    public interface ISchemaIdentifier
    {
        string Value { get; }

        string FindPath();
        bool TryFindPath(out string path);
    }
}