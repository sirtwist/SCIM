﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    using System.Runtime.Serialization;

    [DataContract]
    public abstract class UserBase : Resource
    {
        [DataMember(Name = AttributeNames.UserName)]
        public virtual string UserName
        {
            get;
            set;
        }
    }
}