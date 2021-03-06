// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The RegistryListCredentialsResult. </summary>
    public partial class RegistryListCredentialsResult
    {
        /// <summary> Initializes a new instance of RegistryListCredentialsResult. </summary>
        internal RegistryListCredentialsResult()
        {
            Passwords = new ChangeTrackingList<Password>();
        }

        /// <summary> Initializes a new instance of RegistryListCredentialsResult. </summary>
        /// <param name="location"> . </param>
        /// <param name="username"> . </param>
        /// <param name="passwords"> . </param>
        internal RegistryListCredentialsResult(string location, string username, IReadOnlyList<Password> passwords)
        {
            Location = location;
            Username = username;
            Passwords = passwords;
        }

        public string Location { get; }
        public string Username { get; }
        public IReadOnlyList<Password> Passwords { get; }
    }
}
