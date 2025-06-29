//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Mod.SCIM
{
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class Feature : FeatureBase
    {
        public Feature(bool supported)
        {
            this.Supported = supported;
        }
    }
}