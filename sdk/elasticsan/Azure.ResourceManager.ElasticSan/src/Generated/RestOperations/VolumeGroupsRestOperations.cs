// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ElasticSan.Models;

namespace Azure.ResourceManager.ElasticSan
{
    internal partial class VolumeGroupsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of VolumeGroupsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public VolumeGroupsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-11-20-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByElasticSanRequest(string subscriptionId, string resourceGroupName, string elasticSanName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ElasticSan/elasticSans/", false);
            uri.AppendPath(elasticSanName, true);
            uri.AppendPath("/volumeGroups", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List VolumeGroups. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="elasticSanName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="elasticSanName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ElasticSanVolumeGroupList>> ListByElasticSanAsync(string subscriptionId, string resourceGroupName, string elasticSanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));

            using var message = CreateListByElasticSanRequest(subscriptionId, resourceGroupName, elasticSanName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ElasticSanVolumeGroupList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ElasticSanVolumeGroupList.DeserializeElasticSanVolumeGroupList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List VolumeGroups. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="elasticSanName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="elasticSanName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ElasticSanVolumeGroupList> ListByElasticSan(string subscriptionId, string resourceGroupName, string elasticSanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));

            using var message = CreateListByElasticSanRequest(subscriptionId, resourceGroupName, elasticSanName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ElasticSanVolumeGroupList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ElasticSanVolumeGroupList.DeserializeElasticSanVolumeGroupList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, ElasticSanVolumeGroupData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ElasticSan/elasticSans/", false);
            uri.AppendPath(elasticSanName, true);
            uri.AppendPath("/volumegroups/", false);
            uri.AppendPath(volumeGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create a Volume Group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="data"> Volume Group object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, ElasticSanVolumeGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a Volume Group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="data"> Volume Group object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, ElasticSanVolumeGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, ElasticSanVolumeGroupPatch patch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ElasticSan/elasticSans/", false);
            uri.AppendPath(elasticSanName, true);
            uri.AppendPath("/volumegroups/", false);
            uri.AppendPath(volumeGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(patch);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Update an VolumeGroup. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="patch"> Volume Group object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, ElasticSanVolumeGroupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update an VolumeGroup. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="patch"> Volume Group object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/>, <paramref name="volumeGroupName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, ElasticSanVolumeGroupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ElasticSan/elasticSans/", false);
            uri.AppendPath(elasticSanName, true);
            uri.AppendPath("/volumegroups/", false);
            uri.AppendPath(volumeGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete an VolumeGroup. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete an VolumeGroup. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ElasticSan/elasticSans/", false);
            uri.AppendPath(elasticSanName, true);
            uri.AppendPath("/volumegroups/", false);
            uri.AppendPath(volumeGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get an VolumeGroups. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ElasticSanVolumeGroupData>> GetAsync(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ElasticSanVolumeGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ElasticSanVolumeGroupData.DeserializeElasticSanVolumeGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ElasticSanVolumeGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get an VolumeGroups. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="elasticSanName"/> or <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ElasticSanVolumeGroupData> Get(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, elasticSanName, volumeGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ElasticSanVolumeGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ElasticSanVolumeGroupData.DeserializeElasticSanVolumeGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ElasticSanVolumeGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByElasticSanNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string elasticSanName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List VolumeGroups. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="elasticSanName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="elasticSanName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ElasticSanVolumeGroupList>> ListByElasticSanNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string elasticSanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));

            using var message = CreateListByElasticSanNextPageRequest(nextLink, subscriptionId, resourceGroupName, elasticSanName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ElasticSanVolumeGroupList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ElasticSanVolumeGroupList.DeserializeElasticSanVolumeGroupList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List VolumeGroups. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="elasticSanName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="elasticSanName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ElasticSanVolumeGroupList> ListByElasticSanNextPage(string nextLink, string subscriptionId, string resourceGroupName, string elasticSanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));

            using var message = CreateListByElasticSanNextPageRequest(nextLink, subscriptionId, resourceGroupName, elasticSanName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ElasticSanVolumeGroupList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ElasticSanVolumeGroupList.DeserializeElasticSanVolumeGroupList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
