﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class ExtensionAttributeWindowsAzureActiveDirectoryGroup
    {
        [DataMember(Name = AttributeNames.ElectronicMailAddresses)]
        public IEnumerable<ElectronicMailAddress> ElectronicMailAddresses
        {
            get;
            set;
        }

        [DataMember(Name = AttributeNames.ExternalIdentifier)]
        public string ExternalIdentifier
        {
            get;
            set;
        }

        [DataMember(Name = AttributeNames.MailEnabled, IsRequired = false)]
        public bool MailEnabled
        {
            get;
            set;
        }

        [DataMember(Name = AttributeNames.SecurityEnabled, IsRequired = false)]
        public bool SecurityEnabled
        {
            get;
            set;
        }
    }
}