﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class BulkRequestsFeature : FeatureBase
    {
        private BulkRequestsFeature()
        {
        }

        public int ConcurrentOperations
        {
            get;
            private set;
        }

        [DataMember(Name = AttributeNames.MaximumOperations)]
        public int MaximumOperations
        {
            get;
            private set;
        }

        [DataMember(Name = AttributeNames.MaximumPayloadSize)]
        public int MaximumPayloadSize
        {
            get;
            private set;
        }

        public static BulkRequestsFeature CreateUnsupportedFeature()
        {
            BulkRequestsFeature result =
                new BulkRequestsFeature()
                {
                    Supported = false
                };
            return result;
        }
    }
}