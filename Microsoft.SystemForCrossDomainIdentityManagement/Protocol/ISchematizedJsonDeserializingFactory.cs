//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    internal interface ISchematizedJsonDeserializingFactory :
        IGroupDeserializer,
        IPatchRequest2Deserializer,
        IUserDeserializer
    {
    }
}