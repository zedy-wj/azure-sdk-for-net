// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> A priming job instance. </summary>
    public partial class PrimingJob
    {
        /// <summary> Initializes a new instance of PrimingJob. </summary>
        /// <param name="primingJobName"> The priming job name. </param>
        /// <param name="primingManifestUri"> The URL for the priming manifest file to download. This file must be readable from the HPC Cache. When the file is in Azure blob storage the URL should include a Shared Access Signature (SAS) granting read permissions on the blob. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="primingJobName"/> or <paramref name="primingManifestUri"/> is null. </exception>
        public PrimingJob(string primingJobName, Uri primingManifestUri)
        {
            if (primingJobName == null)
            {
                throw new ArgumentNullException(nameof(primingJobName));
            }
            if (primingManifestUri == null)
            {
                throw new ArgumentNullException(nameof(primingManifestUri));
            }

            PrimingJobName = primingJobName;
            PrimingManifestUri = primingManifestUri;
        }

        /// <summary> Initializes a new instance of PrimingJob. </summary>
        /// <param name="primingJobName"> The priming job name. </param>
        /// <param name="primingManifestUri"> The URL for the priming manifest file to download. This file must be readable from the HPC Cache. When the file is in Azure blob storage the URL should include a Shared Access Signature (SAS) granting read permissions on the blob. </param>
        /// <param name="primingJobId"> The unique identifier of the priming job. </param>
        /// <param name="primingJobState"> The state of the priming operation. </param>
        /// <param name="primingJobStatus"> The status code of the priming job. </param>
        /// <param name="primingJobDetails"> The job details or error information if any. </param>
        /// <param name="primingJobPercentComplete"> The current progress of the priming job, as a percentage. </param>
        internal PrimingJob(string primingJobName, Uri primingManifestUri, string primingJobId, PrimingJobState? primingJobState, string primingJobStatus, string primingJobDetails, double? primingJobPercentComplete)
        {
            PrimingJobName = primingJobName;
            PrimingManifestUri = primingManifestUri;
            PrimingJobId = primingJobId;
            PrimingJobState = primingJobState;
            PrimingJobStatus = primingJobStatus;
            PrimingJobDetails = primingJobDetails;
            PrimingJobPercentComplete = primingJobPercentComplete;
        }

        /// <summary> The priming job name. </summary>
        public string PrimingJobName { get; set; }
        /// <summary> The URL for the priming manifest file to download. This file must be readable from the HPC Cache. When the file is in Azure blob storage the URL should include a Shared Access Signature (SAS) granting read permissions on the blob. </summary>
        public Uri PrimingManifestUri { get; set; }
        /// <summary> The unique identifier of the priming job. </summary>
        public string PrimingJobId { get; }
        /// <summary> The state of the priming operation. </summary>
        public PrimingJobState? PrimingJobState { get; }
        /// <summary> The status code of the priming job. </summary>
        public string PrimingJobStatus { get; }
        /// <summary> The job details or error information if any. </summary>
        public string PrimingJobDetails { get; }
        /// <summary> The current progress of the priming job, as a percentage. </summary>
        public double? PrimingJobPercentComplete { get; }
    }
}
