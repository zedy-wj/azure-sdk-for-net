// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The properties indicating the operation result of an operation on a service. </summary>
    public partial class OperationResultsDescription
    {
        /// <summary> Initializes a new instance of OperationResultsDescription. </summary>
        internal OperationResultsDescription()
        {
        }

        /// <summary> Initializes a new instance of OperationResultsDescription. </summary>
        /// <param name="id"> The ID of the operation returned. </param>
        /// <param name="name"> The name of the operation result. </param>
        /// <param name="status"> The status of the operation being performed. </param>
        /// <param name="startOn"> The time that the operation was started. </param>
        internal OperationResultsDescription(string id, string name, OperationResultStatus? status, DateTimeOffset? startOn)
        {
            Id = id;
            Name = name;
            Status = status;
            StartOn = startOn;
        }

        /// <summary> The ID of the operation returned. </summary>
        public string Id { get; }
        /// <summary> The name of the operation result. </summary>
        public string Name { get; }
        /// <summary> The status of the operation being performed. </summary>
        public OperationResultStatus? Status { get; }
        /// <summary> The time that the operation was started. </summary>
        public DateTimeOffset? StartOn { get; }
    }
}
