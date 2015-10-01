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
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network
{
    /// <summary>
    /// The Network Resource Provider API includes operations for managing the
    /// ExpressRouteServiceProviders for your subscription.
    /// </summary>
    public partial interface IExpressRouteServiceProviderOperations
    {
        /// <summary>
        /// The List ExpressRouteServiceProvider opertion retrieves all the
        /// available ExpressRouteServiceProviders.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for ListExpressRouteResourceProvider Api service call
        /// </returns>
        Task<ExpressRouteResourceProviderListResponse> ListAsync(CancellationToken cancellationToken);
    }
}