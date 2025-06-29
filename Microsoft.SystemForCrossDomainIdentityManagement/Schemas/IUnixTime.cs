//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    using System;

    public interface IUnixTime
    {
        long EpochTimestamp { get; }

        DateTime ToUniversalTime();
    }
}