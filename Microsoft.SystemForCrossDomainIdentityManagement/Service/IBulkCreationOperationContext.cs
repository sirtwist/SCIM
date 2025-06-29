//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    public interface IBulkCreationOperationContext : IBulkOperationContext<Resource>, IBulkCreationOperationState
    {
        IBulkOperationState<Resource> PendingState { get; }
    }
}
