// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Flux Configuration object returned in Get &amp; Put response.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FluxConfiguration : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the FluxConfiguration class.
        /// </summary>
        public FluxConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FluxConfiguration class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="scope">Scope at which the operator will be installed.
        /// Possible values include: 'cluster', 'namespace'</param>
        /// <param name="namespaceProperty">The namespace to which this
        /// configuration is installed to. Maximum of 253 lower case
        /// alphanumeric characters, hyphen and period only.</param>
        /// <param name="sourceKind">Source Kind to pull the configuration data
        /// from. Possible values include: 'GitRepository', 'Bucket'</param>
        /// <param name="suspend">Whether this configuration should suspend its
        /// reconciliation of its kustomizations and sources.</param>
        /// <param name="gitRepository">Parameters to reconcile to the
        /// GitRepository source kind type.</param>
        /// <param name="bucket">Parameters to reconcile to the Bucket source
        /// kind type.</param>
        /// <param name="kustomizations">Array of kustomizations used to
        /// reconcile the artifact pulled by the source type on the
        /// cluster.</param>
        /// <param name="configurationProtectedSettings">Key-value pairs of
        /// protected configuration settings for the configuration</param>
        /// <param name="statuses">Statuses of the Flux Kubernetes resources
        /// created by the fluxConfiguration or created by the managed objects
        /// provisioned by the fluxConfiguration.</param>
        /// <param name="repositoryPublicKey">Public Key associated with this
        /// fluxConfiguration (either generated within the cluster or provided
        /// by the user).</param>
        /// <param name="sourceSyncedCommitId">Branch and/or SHA of the source
        /// commit synced with the cluster.</param>
        /// <param name="sourceUpdatedAt">Datetime the fluxConfiguration synced
        /// its source on the cluster.</param>
        /// <param name="statusUpdatedAt">Datetime the fluxConfiguration synced
        /// its status on the cluster with Azure.</param>
        /// <param name="complianceState">Combined status of the Flux
        /// Kubernetes resources created by the fluxConfiguration or created by
        /// the managed objects. Possible values include: 'Compliant',
        /// 'Non-Compliant', 'Pending', 'Suspended', 'Unknown'</param>
        /// <param name="provisioningState">Status of the creation of the
        /// fluxConfiguration. Possible values include: 'Succeeded', 'Failed',
        /// 'Canceled', 'Creating', 'Updating', 'Deleting'</param>
        /// <param name="errorMessage">Error message returned to the user in
        /// the case of provisioning failure.</param>
        /// <param name="systemData">Top level metadata
        /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources</param>
        public FluxConfiguration(string id = default(string), string name = default(string), string type = default(string), string scope = default(string), string namespaceProperty = default(string), string sourceKind = default(string), bool? suspend = default(bool?), GitRepositoryDefinition gitRepository = default(GitRepositoryDefinition), BucketDefinition bucket = default(BucketDefinition), IDictionary<string, KustomizationDefinition> kustomizations = default(IDictionary<string, KustomizationDefinition>), IDictionary<string, string> configurationProtectedSettings = default(IDictionary<string, string>), IList<ObjectStatusDefinition> statuses = default(IList<ObjectStatusDefinition>), string repositoryPublicKey = default(string), string sourceSyncedCommitId = default(string), System.DateTime? sourceUpdatedAt = default(System.DateTime?), System.DateTime? statusUpdatedAt = default(System.DateTime?), string complianceState = default(string), string provisioningState = default(string), string errorMessage = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            Scope = scope;
            NamespaceProperty = namespaceProperty;
            SourceKind = sourceKind;
            Suspend = suspend;
            GitRepository = gitRepository;
            Bucket = bucket;
            Kustomizations = kustomizations;
            ConfigurationProtectedSettings = configurationProtectedSettings;
            Statuses = statuses;
            RepositoryPublicKey = repositoryPublicKey;
            SourceSyncedCommitId = sourceSyncedCommitId;
            SourceUpdatedAt = sourceUpdatedAt;
            StatusUpdatedAt = statusUpdatedAt;
            ComplianceState = complianceState;
            ProvisioningState = provisioningState;
            ErrorMessage = errorMessage;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets scope at which the operator will be installed.
        /// Possible values include: 'cluster', 'namespace'
        /// </summary>
        [JsonProperty(PropertyName = "properties.scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the namespace to which this configuration is installed
        /// to. Maximum of 253 lower case alphanumeric characters, hyphen and
        /// period only.
        /// </summary>
        [JsonProperty(PropertyName = "properties.namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// Gets or sets source Kind to pull the configuration data from.
        /// Possible values include: 'GitRepository', 'Bucket'
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceKind")]
        public string SourceKind { get; set; }

        /// <summary>
        /// Gets or sets whether this configuration should suspend its
        /// reconciliation of its kustomizations and sources.
        /// </summary>
        [JsonProperty(PropertyName = "properties.suspend")]
        public bool? Suspend { get; set; }

        /// <summary>
        /// Gets or sets parameters to reconcile to the GitRepository source
        /// kind type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gitRepository")]
        public GitRepositoryDefinition GitRepository { get; set; }

        /// <summary>
        /// Gets or sets parameters to reconcile to the Bucket source kind
        /// type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bucket")]
        public BucketDefinition Bucket { get; set; }

        /// <summary>
        /// Gets or sets array of kustomizations used to reconcile the artifact
        /// pulled by the source type on the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.kustomizations")]
        public IDictionary<string, KustomizationDefinition> Kustomizations { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs of protected configuration settings
        /// for the configuration
        /// </summary>
        [JsonProperty(PropertyName = "properties.configurationProtectedSettings")]
        public IDictionary<string, string> ConfigurationProtectedSettings { get; set; }

        /// <summary>
        /// Gets statuses of the Flux Kubernetes resources created by the
        /// fluxConfiguration or created by the managed objects provisioned by
        /// the fluxConfiguration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.statuses")]
        public IList<ObjectStatusDefinition> Statuses { get; private set; }

        /// <summary>
        /// Gets public Key associated with this fluxConfiguration (either
        /// generated within the cluster or provided by the user).
        /// </summary>
        [JsonProperty(PropertyName = "properties.repositoryPublicKey")]
        public string RepositoryPublicKey { get; private set; }

        /// <summary>
        /// Gets branch and/or SHA of the source commit synced with the
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceSyncedCommitId")]
        public string SourceSyncedCommitId { get; private set; }

        /// <summary>
        /// Gets datetime the fluxConfiguration synced its source on the
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceUpdatedAt")]
        public System.DateTime? SourceUpdatedAt { get; private set; }

        /// <summary>
        /// Gets datetime the fluxConfiguration synced its status on the
        /// cluster with Azure.
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusUpdatedAt")]
        public System.DateTime? StatusUpdatedAt { get; private set; }

        /// <summary>
        /// Gets combined status of the Flux Kubernetes resources created by
        /// the fluxConfiguration or created by the managed objects. Possible
        /// values include: 'Compliant', 'Non-Compliant', 'Pending',
        /// 'Suspended', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.complianceState")]
        public string ComplianceState { get; private set; }

        /// <summary>
        /// Gets status of the creation of the fluxConfiguration. Possible
        /// values include: 'Succeeded', 'Failed', 'Canceled', 'Creating',
        /// 'Updating', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets error message returned to the user in the case of provisioning
        /// failure.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorMessage")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Gets or sets top level metadata
        /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

    }
}
