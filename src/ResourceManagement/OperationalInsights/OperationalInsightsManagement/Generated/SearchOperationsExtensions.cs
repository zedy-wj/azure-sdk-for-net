// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.OperationalInsights;
using Microsoft.Azure.Management.OperationalInsights.Models;

namespace Microsoft.Azure.Management.OperationalInsights
{
    /// <summary>
    /// .Net client wrapper for the REST API for Azure Operational Insights
    /// </summary>
    public static partial class SearchOperationsExtensions
    {
        /// <summary>
        /// Creates or updates a saved search for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='savedSearchId'>
        /// Required. The id of the saved search.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to save a search.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse CreateOrUpdateSavedSearch(this ISearchOperations operations, string resourceGroupName, string workspaceName, string savedSearchId, SearchCreateOrUpdateSavedSearchParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISearchOperations)s).CreateOrUpdateSavedSearchAsync(resourceGroupName, workspaceName, savedSearchId, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates or updates a saved search for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='savedSearchId'>
        /// Required. The id of the saved search.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to save a search.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> CreateOrUpdateSavedSearchAsync(this ISearchOperations operations, string resourceGroupName, string workspaceName, string savedSearchId, SearchCreateOrUpdateSavedSearchParameters parameters)
        {
            return operations.CreateOrUpdateSavedSearchAsync(resourceGroupName, workspaceName, savedSearchId, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes the specified saved search in a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='savedSearchId'>
        /// Required. The id of the saved search.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse DeleteSavedSearch(this ISearchOperations operations, string resourceGroupName, string workspaceName, string savedSearchId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISearchOperations)s).DeleteSavedSearchAsync(resourceGroupName, workspaceName, savedSearchId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes the specified saved search in a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='savedSearchId'>
        /// Required. The id of the saved search.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteSavedSearchAsync(this ISearchOperations operations, string resourceGroupName, string workspaceName, string savedSearchId)
        {
            return operations.DeleteSavedSearchAsync(resourceGroupName, workspaceName, savedSearchId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the specified saved search for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='savedSearchId'>
        /// Required. The id of the saved search.
        /// </param>
        /// <returns>
        /// Value object for saved search results.
        /// </returns>
        public static SearchGetSavedSearchResponse GetSavedSearch(this ISearchOperations operations, string resourceGroupName, string workspaceName, string savedSearchId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISearchOperations)s).GetSavedSearchAsync(resourceGroupName, workspaceName, savedSearchId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the specified saved search for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='savedSearchId'>
        /// Required. The id of the saved search.
        /// </param>
        /// <returns>
        /// Value object for saved search results.
        /// </returns>
        public static Task<SearchGetSavedSearchResponse> GetSavedSearchAsync(this ISearchOperations operations, string resourceGroupName, string workspaceName, string savedSearchId)
        {
            return operations.GetSavedSearchAsync(resourceGroupName, workspaceName, savedSearchId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the results from a saved search for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='savedSearchId'>
        /// Required. The id of the saved search.
        /// </param>
        /// <returns>
        /// The get search result operation response.
        /// </returns>
        public static SearchGetSearchResultsResponse GetSavedSearchResults(this ISearchOperations operations, string resourceGroupName, string workspaceName, string savedSearchId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISearchOperations)s).GetSavedSearchResultsAsync(resourceGroupName, workspaceName, savedSearchId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the results from a saved search for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='savedSearchId'>
        /// Required. The id of the saved search.
        /// </param>
        /// <returns>
        /// The get search result operation response.
        /// </returns>
        public static Task<SearchGetSearchResultsResponse> GetSavedSearchResultsAsync(this ISearchOperations operations, string resourceGroupName, string workspaceName, string savedSearchId)
        {
            return operations.GetSavedSearchResultsAsync(resourceGroupName, workspaceName, savedSearchId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the schema for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <returns>
        /// The get schema operation response.
        /// </returns>
        public static SearchGetSchemaResponse GetSchema(this ISearchOperations operations, string resourceGroupName, string workspaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISearchOperations)s).GetSchemaAsync(resourceGroupName, workspaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the schema for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <returns>
        /// The get schema operation response.
        /// </returns>
        public static Task<SearchGetSchemaResponse> GetSchemaAsync(this ISearchOperations operations, string resourceGroupName, string workspaceName)
        {
            return operations.GetSchemaAsync(resourceGroupName, workspaceName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the search results for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to execute a search query.
        /// </param>
        /// <returns>
        /// The get search result operation response.
        /// </returns>
        public static SearchGetSearchResultsResponse GetSearchResults(this ISearchOperations operations, string resourceGroupName, string workspaceName, SearchGetSearchResultsParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISearchOperations)s).GetSearchResultsAsync(resourceGroupName, workspaceName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the search results for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to execute a search query.
        /// </param>
        /// <returns>
        /// The get search result operation response.
        /// </returns>
        public static Task<SearchGetSearchResultsResponse> GetSearchResultsAsync(this ISearchOperations operations, string resourceGroupName, string workspaceName, SearchGetSearchResultsParameters parameters)
        {
            return operations.GetSearchResultsAsync(resourceGroupName, workspaceName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets updated search results for a given search query.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='id'>
        /// Required. The id of the search that will have results updated.
        /// </param>
        /// <returns>
        /// The get search result operation response.
        /// </returns>
        public static SearchGetSearchResultsResponse GetSearchResultUpdate(this ISearchOperations operations, string resourceGroupName, string workspaceName, string id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISearchOperations)s).GetSearchResultUpdateAsync(resourceGroupName, workspaceName, id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets updated search results for a given search query.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='id'>
        /// Required. The id of the search that will have results updated.
        /// </param>
        /// <returns>
        /// The get search result operation response.
        /// </returns>
        public static Task<SearchGetSearchResultsResponse> GetSearchResultUpdateAsync(this ISearchOperations operations, string resourceGroupName, string workspaceName, string id)
        {
            return operations.GetSearchResultUpdateAsync(resourceGroupName, workspaceName, id, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the saved searches for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <returns>
        /// The saved search operation response.
        /// </returns>
        public static SearchListSavedSearchResponse ListSavedSearches(this ISearchOperations operations, string resourceGroupName, string workspaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISearchOperations)s).ListSavedSearchesAsync(resourceGroupName, workspaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the saved searches for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.ISearchOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <returns>
        /// The saved search operation response.
        /// </returns>
        public static Task<SearchListSavedSearchResponse> ListSavedSearchesAsync(this ISearchOperations operations, string resourceGroupName, string workspaceName)
        {
            return operations.ListSavedSearchesAsync(resourceGroupName, workspaceName, CancellationToken.None);
        }
    }
}
