//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    public interface IPatchOperation2Base
    {
        OperationName Name { get; set; }
        IPath Path { get; set; }
    }
}
