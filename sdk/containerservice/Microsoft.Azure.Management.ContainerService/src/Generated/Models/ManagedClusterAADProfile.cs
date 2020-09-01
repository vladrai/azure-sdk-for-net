// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AADProfile specifies attributes for Azure Active Directory integration.
    /// </summary>
    public partial class ManagedClusterAADProfile
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterAADProfile class.
        /// </summary>
        public ManagedClusterAADProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterAADProfile class.
        /// </summary>
        /// <param name="managed">Whether to enable managed AAD.</param>
        /// <param name="enableAzureRBAC">Whether to enable Azure RBAC for
        /// Kubernetes authorization.</param>
        /// <param name="adminGroupObjectIDs">AAD group object IDs that will
        /// have admin role of the cluster.</param>
        /// <param name="clientAppID">The client AAD application ID.</param>
        /// <param name="serverAppID">The server AAD application ID.</param>
        /// <param name="serverAppSecret">The server AAD application
        /// secret.</param>
        /// <param name="tenantID">The AAD tenant ID to use for authentication.
        /// If not specified, will use the tenant of the deployment
        /// subscription.</param>
        public ManagedClusterAADProfile(bool? managed = default(bool?), bool? enableAzureRBAC = default(bool?), IList<string> adminGroupObjectIDs = default(IList<string>), string clientAppID = default(string), string serverAppID = default(string), string serverAppSecret = default(string), string tenantID = default(string))
        {
            Managed = managed;
            EnableAzureRBAC = enableAzureRBAC;
            AdminGroupObjectIDs = adminGroupObjectIDs;
            ClientAppID = clientAppID;
            ServerAppID = serverAppID;
            ServerAppSecret = serverAppSecret;
            TenantID = tenantID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether to enable managed AAD.
        /// </summary>
        [JsonProperty(PropertyName = "managed")]
        public bool? Managed { get; set; }

        /// <summary>
        /// Gets or sets whether to enable Azure RBAC for Kubernetes
        /// authorization.
        /// </summary>
        [JsonProperty(PropertyName = "enableAzureRBAC")]
        public bool? EnableAzureRBAC { get; set; }

        /// <summary>
        /// Gets or sets AAD group object IDs that will have admin role of the
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "adminGroupObjectIDs")]
        public IList<string> AdminGroupObjectIDs { get; set; }

        /// <summary>
        /// Gets or sets the client AAD application ID.
        /// </summary>
        [JsonProperty(PropertyName = "clientAppID")]
        public string ClientAppID { get; set; }

        /// <summary>
        /// Gets or sets the server AAD application ID.
        /// </summary>
        [JsonProperty(PropertyName = "serverAppID")]
        public string ServerAppID { get; set; }

        /// <summary>
        /// Gets or sets the server AAD application secret.
        /// </summary>
        [JsonProperty(PropertyName = "serverAppSecret")]
        public string ServerAppSecret { get; set; }

        /// <summary>
        /// Gets or sets the AAD tenant ID to use for authentication. If not
        /// specified, will use the tenant of the deployment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "tenantID")]
        public string TenantID { get; set; }

    }
}
