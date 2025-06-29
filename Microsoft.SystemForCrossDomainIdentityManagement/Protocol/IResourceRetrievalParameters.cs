//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    public interface IResourceRetrievalParameters : IRetrievalParameters
    {
        IResourceIdentifier ResourceIdentifier { get; }
    }
}