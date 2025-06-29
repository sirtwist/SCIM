//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    using System.Collections.Generic;

    public interface IBulkCreationOperationState : IBulkOperationState<Resource>
    {
        IReadOnlyCollection<IBulkUpdateOperationContext> Dependents { get; }
        IReadOnlyCollection<IBulkUpdateOperationContext> Subordinates { get; }

        void AddDependent(IBulkUpdateOperationContext dependent);
        void AddSubordinate(IBulkUpdateOperationContext subordinate);
    }
}
