// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ManagedDatabaseRestoreDetailsResult along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ManagedDatabaseRestoreDetailsResultResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetManagedDatabaseRestoreDetailsResultResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedDatabaseResource" /> using the GetManagedDatabaseRestoreDetailsResult method.
    /// </summary>
    public partial class ManagedDatabaseRestoreDetailsResultResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedDatabaseRestoreDetailsResultResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string restoreDetailsName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/restoreDetails/{restoreDetailsName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedDatabaseRestoreDetailsResultManagedDatabaseRestoreDetailsClientDiagnostics;
        private readonly ManagedDatabaseRestoreDetailsRestOperations _managedDatabaseRestoreDetailsResultManagedDatabaseRestoreDetailsRestClient;
        private readonly ManagedDatabaseRestoreDetailsResultData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseRestoreDetailsResultResource"/> class for mocking. </summary>
        protected ManagedDatabaseRestoreDetailsResultResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedDatabaseRestoreDetailsResultResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedDatabaseRestoreDetailsResultResource(ArmClient client, ManagedDatabaseRestoreDetailsResultData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseRestoreDetailsResultResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedDatabaseRestoreDetailsResultResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedDatabaseRestoreDetailsResultManagedDatabaseRestoreDetailsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedDatabaseRestoreDetailsResultManagedDatabaseRestoreDetailsApiVersion);
            _managedDatabaseRestoreDetailsResultManagedDatabaseRestoreDetailsRestClient = new ManagedDatabaseRestoreDetailsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedDatabaseRestoreDetailsResultManagedDatabaseRestoreDetailsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/restoreDetails";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedDatabaseRestoreDetailsResultData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets managed database restore details.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/restoreDetails/{restoreDetailsName}
        /// Operation Id: ManagedDatabaseRestoreDetails_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedDatabaseRestoreDetailsResultResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseRestoreDetailsResultManagedDatabaseRestoreDetailsClientDiagnostics.CreateScope("ManagedDatabaseRestoreDetailsResultResource.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseRestoreDetailsResultManagedDatabaseRestoreDetailsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseRestoreDetailsResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets managed database restore details.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/restoreDetails/{restoreDetailsName}
        /// Operation Id: ManagedDatabaseRestoreDetails_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedDatabaseRestoreDetailsResultResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseRestoreDetailsResultManagedDatabaseRestoreDetailsClientDiagnostics.CreateScope("ManagedDatabaseRestoreDetailsResultResource.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseRestoreDetailsResultManagedDatabaseRestoreDetailsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseRestoreDetailsResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
