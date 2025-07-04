﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    public interface IResourceIdentifier
    {
        string Identifier { get; set; }
        string SchemaIdentifier { get; set; }
    }
}