// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace FirstTestTypeSpec
{
    /// <summary> Client options for FirstTestTypeSpecClient. </summary>
    public partial class FirstTestTypeSpecClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V0_1_0;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "0.1.0". </summary>
            V0_1_0 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of FirstTestTypeSpecClientOptions. </summary>
        public FirstTestTypeSpecClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V0_1_0 => "0.1.0",
                _ => throw new NotSupportedException()
            };
        }
    }
}
