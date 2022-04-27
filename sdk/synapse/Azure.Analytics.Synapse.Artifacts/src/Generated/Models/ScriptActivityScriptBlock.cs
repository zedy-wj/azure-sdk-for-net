// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Script block of scripts. </summary>
    public partial class ScriptActivityScriptBlock
    {
        /// <summary> Initializes a new instance of ScriptActivityScriptBlock. </summary>
        /// <param name="text"> The query text. Type: string (or Expression with resultType string). </param>
        /// <param name="type"> The type of the query. Type: string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        public ScriptActivityScriptBlock(object text, ScriptType type)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            Text = text;
            Type = type;
            Parameters = new ChangeTrackingList<ScriptActivityParameter>();
        }

        /// <summary> Initializes a new instance of ScriptActivityScriptBlock. </summary>
        /// <param name="text"> The query text. Type: string (or Expression with resultType string). </param>
        /// <param name="type"> The type of the query. Type: string. </param>
        /// <param name="parameters"> Array of script parameters. Type: array. </param>
        internal ScriptActivityScriptBlock(object text, ScriptType type, IList<ScriptActivityParameter> parameters)
        {
            Text = text;
            Type = type;
            Parameters = parameters;
        }

        /// <summary> The query text. Type: string (or Expression with resultType string). </summary>
        public object Text { get; set; }
        /// <summary> The type of the query. Type: string. </summary>
        public ScriptType Type { get; set; }
        /// <summary> Array of script parameters. Type: array. </summary>
        public IList<ScriptActivityParameter> Parameters { get; }
    }
}
