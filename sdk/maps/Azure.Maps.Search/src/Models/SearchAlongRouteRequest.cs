// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.GeoJson;
using Azure.Core;
using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> Initializes a new instance of SearchAlongRouteRequest. </summary>
    [CodeGenModel("SearchAlongRouteRequest")]
    internal partial class SearchAlongRouteRequest {
        /// constructor takes in geolinestring
        public SearchAlongRouteRequest(GeoLineString route) {
            List<List<double>> listCoordinates = new List<List<double>>();
            foreach (GeoPosition coordinate in route.Coordinates) {
                List<double> result = new List<double>();
                result.Add(coordinate.Longitude);
                result.Add(coordinate.Latitude);
                listCoordinates.Add(result);
            }
            Route = new GeoJsonLineString(listCoordinates);
        }
    }
}
