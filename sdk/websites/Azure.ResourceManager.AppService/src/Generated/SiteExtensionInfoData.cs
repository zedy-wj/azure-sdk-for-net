// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the SiteExtensionInfo data model. </summary>
    public partial class SiteExtensionInfoData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of SiteExtensionInfoData. </summary>
        public SiteExtensionInfoData()
        {
            Authors = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SiteExtensionInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="extensionId"> Site extension ID. </param>
        /// <param name="title"></param>
        /// <param name="extensionType"> Site extension type. </param>
        /// <param name="summary"> Summary description. </param>
        /// <param name="description"> Detailed description. </param>
        /// <param name="version"> Version information. </param>
        /// <param name="extensionUri"> Extension URL. </param>
        /// <param name="projectUri"> Project URL. </param>
        /// <param name="iconUri"> Icon URL. </param>
        /// <param name="licenseUri"> License URL. </param>
        /// <param name="feedUri"> Feed URL. </param>
        /// <param name="authors"> List of authors. </param>
        /// <param name="installerCommandLineParams"> Installer command line parameters. </param>
        /// <param name="publishedOn"> Published timestamp. </param>
        /// <param name="downloadCount"> Count of downloads. </param>
        /// <param name="localIsLatestVersion"> &lt;code&gt;true&lt;/code&gt; if the local version is the latest version; &lt;code&gt;false&lt;/code&gt; otherwise. </param>
        /// <param name="localPath"> Local path. </param>
        /// <param name="installedOn"> Installed timestamp. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="comment"> Site Extension comment. </param>
        internal SiteExtensionInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string extensionId, string title, SiteExtensionType? extensionType, string summary, string description, string version, Uri extensionUri, Uri projectUri, Uri iconUri, Uri licenseUri, Uri feedUri, IList<string> authors, string installerCommandLineParams, DateTimeOffset? publishedOn, int? downloadCount, bool? localIsLatestVersion, string localPath, DateTimeOffset? installedOn, string provisioningState, string comment) : base(id, name, resourceType, systemData, kind)
        {
            ExtensionId = extensionId;
            Title = title;
            ExtensionType = extensionType;
            Summary = summary;
            Description = description;
            Version = version;
            ExtensionUri = extensionUri;
            ProjectUri = projectUri;
            IconUri = iconUri;
            LicenseUri = licenseUri;
            FeedUri = feedUri;
            Authors = authors;
            InstallerCommandLineParams = installerCommandLineParams;
            PublishedOn = publishedOn;
            DownloadCount = downloadCount;
            LocalIsLatestVersion = localIsLatestVersion;
            LocalPath = localPath;
            InstalledOn = installedOn;
            ProvisioningState = provisioningState;
            Comment = comment;
        }

        /// <summary> Site extension ID. </summary>
        public string ExtensionId { get; set; }
        /// <summary> Gets or sets the title. </summary>
        public string Title { get; set; }
        /// <summary> Site extension type. </summary>
        public SiteExtensionType? ExtensionType { get; set; }
        /// <summary> Summary description. </summary>
        public string Summary { get; set; }
        /// <summary> Detailed description. </summary>
        public string Description { get; set; }
        /// <summary> Version information. </summary>
        public string Version { get; set; }
        /// <summary> Extension URL. </summary>
        public Uri ExtensionUri { get; set; }
        /// <summary> Project URL. </summary>
        public Uri ProjectUri { get; set; }
        /// <summary> Icon URL. </summary>
        public Uri IconUri { get; set; }
        /// <summary> License URL. </summary>
        public Uri LicenseUri { get; set; }
        /// <summary> Feed URL. </summary>
        public Uri FeedUri { get; set; }
        /// <summary> List of authors. </summary>
        public IList<string> Authors { get; }
        /// <summary> Installer command line parameters. </summary>
        public string InstallerCommandLineParams { get; set; }
        /// <summary> Published timestamp. </summary>
        public DateTimeOffset? PublishedOn { get; set; }
        /// <summary> Count of downloads. </summary>
        public int? DownloadCount { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the local version is the latest version; &lt;code&gt;false&lt;/code&gt; otherwise. </summary>
        public bool? LocalIsLatestVersion { get; set; }
        /// <summary> Local path. </summary>
        public string LocalPath { get; set; }
        /// <summary> Installed timestamp. </summary>
        public DateTimeOffset? InstalledOn { get; set; }
        /// <summary> Provisioning state. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> Site Extension comment. </summary>
        public string Comment { get; set; }
    }
}
