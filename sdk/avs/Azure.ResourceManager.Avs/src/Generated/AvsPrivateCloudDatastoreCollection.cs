// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="AvsPrivateCloudDatastoreResource" /> and their operations.
    /// Each <see cref="AvsPrivateCloudDatastoreResource" /> in the collection will belong to the same instance of <see cref="AvsPrivateCloudClusterResource" />.
    /// To get an <see cref="AvsPrivateCloudDatastoreCollection" /> instance call the GetAvsPrivateCloudDatastores method from an instance of <see cref="AvsPrivateCloudClusterResource" />.
    /// </summary>
    public partial class AvsPrivateCloudDatastoreCollection : ArmCollection, IEnumerable<AvsPrivateCloudDatastoreResource>, IAsyncEnumerable<AvsPrivateCloudDatastoreResource>
    {
        private readonly ClientDiagnostics _avsPrivateCloudDatastoreDatastoresClientDiagnostics;
        private readonly DatastoresRestOperations _avsPrivateCloudDatastoreDatastoresRestClient;

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudDatastoreCollection"/> class for mocking. </summary>
        protected AvsPrivateCloudDatastoreCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudDatastoreCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AvsPrivateCloudDatastoreCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _avsPrivateCloudDatastoreDatastoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", AvsPrivateCloudDatastoreResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AvsPrivateCloudDatastoreResource.ResourceType, out string avsPrivateCloudDatastoreDatastoresApiVersion);
            _avsPrivateCloudDatastoreDatastoresRestClient = new DatastoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, avsPrivateCloudDatastoreDatastoresApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvsPrivateCloudClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvsPrivateCloudClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a datastore in a private cloud cluster
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/datastores/{datastoreName}
        /// Operation Id: Datastores_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="datastoreName"> Name of the datastore in the private cloud cluster. </param>
        /// <param name="data"> A datastore in a private cloud cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AvsPrivateCloudDatastoreResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string datastoreName, AvsPrivateCloudDatastoreData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _avsPrivateCloudDatastoreDatastoresClientDiagnostics.CreateScope("AvsPrivateCloudDatastoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudDatastoreDatastoresRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, datastoreName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<AvsPrivateCloudDatastoreResource>(new AvsPrivateCloudDatastoreOperationSource(Client), _avsPrivateCloudDatastoreDatastoresClientDiagnostics, Pipeline, _avsPrivateCloudDatastoreDatastoresRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, datastoreName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a datastore in a private cloud cluster
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/datastores/{datastoreName}
        /// Operation Id: Datastores_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="datastoreName"> Name of the datastore in the private cloud cluster. </param>
        /// <param name="data"> A datastore in a private cloud cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AvsPrivateCloudDatastoreResource> CreateOrUpdate(WaitUntil waitUntil, string datastoreName, AvsPrivateCloudDatastoreData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _avsPrivateCloudDatastoreDatastoresClientDiagnostics.CreateScope("AvsPrivateCloudDatastoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudDatastoreDatastoresRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, datastoreName, data, cancellationToken);
                var operation = new AvsArmOperation<AvsPrivateCloudDatastoreResource>(new AvsPrivateCloudDatastoreOperationSource(Client), _avsPrivateCloudDatastoreDatastoresClientDiagnostics, Pipeline, _avsPrivateCloudDatastoreDatastoresRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, datastoreName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a datastore in a private cloud cluster
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/datastores/{datastoreName}
        /// Operation Id: Datastores_Get
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore in the private cloud cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual async Task<Response<AvsPrivateCloudDatastoreResource>> GetAsync(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _avsPrivateCloudDatastoreDatastoresClientDiagnostics.CreateScope("AvsPrivateCloudDatastoreCollection.Get");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, datastoreName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudDatastoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a datastore in a private cloud cluster
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/datastores/{datastoreName}
        /// Operation Id: Datastores_Get
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore in the private cloud cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual Response<AvsPrivateCloudDatastoreResource> Get(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _avsPrivateCloudDatastoreDatastoresClientDiagnostics.CreateScope("AvsPrivateCloudDatastoreCollection.Get");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, datastoreName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudDatastoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List datastores in a private cloud cluster
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/datastores
        /// Operation Id: Datastores_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvsPrivateCloudDatastoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvsPrivateCloudDatastoreResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AvsPrivateCloudDatastoreResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _avsPrivateCloudDatastoreDatastoresClientDiagnostics.CreateScope("AvsPrivateCloudDatastoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _avsPrivateCloudDatastoreDatastoresRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AvsPrivateCloudDatastoreResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AvsPrivateCloudDatastoreResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _avsPrivateCloudDatastoreDatastoresClientDiagnostics.CreateScope("AvsPrivateCloudDatastoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _avsPrivateCloudDatastoreDatastoresRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AvsPrivateCloudDatastoreResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List datastores in a private cloud cluster
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/datastores
        /// Operation Id: Datastores_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvsPrivateCloudDatastoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvsPrivateCloudDatastoreResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AvsPrivateCloudDatastoreResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _avsPrivateCloudDatastoreDatastoresClientDiagnostics.CreateScope("AvsPrivateCloudDatastoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _avsPrivateCloudDatastoreDatastoresRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AvsPrivateCloudDatastoreResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AvsPrivateCloudDatastoreResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _avsPrivateCloudDatastoreDatastoresClientDiagnostics.CreateScope("AvsPrivateCloudDatastoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _avsPrivateCloudDatastoreDatastoresRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AvsPrivateCloudDatastoreResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/datastores/{datastoreName}
        /// Operation Id: Datastores_Get
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore in the private cloud cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _avsPrivateCloudDatastoreDatastoresClientDiagnostics.CreateScope("AvsPrivateCloudDatastoreCollection.Exists");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, datastoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/datastores/{datastoreName}
        /// Operation Id: Datastores_Get
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore in the private cloud cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual Response<bool> Exists(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _avsPrivateCloudDatastoreDatastoresClientDiagnostics.CreateScope("AvsPrivateCloudDatastoreCollection.Exists");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, datastoreName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AvsPrivateCloudDatastoreResource> IEnumerable<AvsPrivateCloudDatastoreResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AvsPrivateCloudDatastoreResource> IAsyncEnumerable<AvsPrivateCloudDatastoreResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
