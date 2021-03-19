// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Azure.WebJobs.Extensions.Storage.Blobs
{
    internal class BlobServiceClientProvider : StorageProvider.Blobs.BlobServiceClientProvider
    {
        public BlobServiceClientProvider(IConfiguration configuration, AzureComponentFactory componentFactory, AzureEventSourceLogForwarder logForwarder)
            : base(configuration, componentFactory, logForwarder) {}
    }
}
