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
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The List Extensions operation response.
    /// </summary>
    public partial class HostedServiceListExtensionsResponse : OperationResponse, IEnumerable<HostedServiceListExtensionsResponse.Extension>
    {
        private IList<HostedServiceListExtensionsResponse.Extension> _extensions;
        
        /// <summary>
        /// Optional. The extensions that were added to a cloud service.
        /// </summary>
        public IList<HostedServiceListExtensionsResponse.Extension> Extensions
        {
            get { return this._extensions; }
            set { this._extensions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// HostedServiceListExtensionsResponse class.
        /// </summary>
        public HostedServiceListExtensionsResponse()
        {
            this.Extensions = new LazyList<HostedServiceListExtensionsResponse.Extension>();
        }
        
        /// <summary>
        /// Gets the sequence of Extensions.
        /// </summary>
        public IEnumerator<HostedServiceListExtensionsResponse.Extension> GetEnumerator()
        {
            return this.Extensions.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Extensions.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// An extension that was added to a cloud service.
        /// </summary>
        public partial class Extension
        {
            private string _id;
            
            /// <summary>
            /// Optional. The identifier of the extension.
            /// </summary>
            public string Id
            {
                get { return this._id; }
                set { this._id = value; }
            }
            
            private string _providerNamespace;
            
            /// <summary>
            /// Optional. The provider namespace of the extension. The provider
            /// namespace for Azure extensions is
            /// Microsoft.Windows.Azure.Extensions.
            /// </summary>
            public string ProviderNamespace
            {
                get { return this._providerNamespace; }
                set { this._providerNamespace = value; }
            }
            
            private string _publicConfiguration;
            
            /// <summary>
            /// Optional. The public configuration that is defined using the
            /// schema returned by the List Extensions operation.
            /// </summary>
            public string PublicConfiguration
            {
                get { return this._publicConfiguration; }
                set { this._publicConfiguration = value; }
            }
            
            private string _thumbprint;
            
            /// <summary>
            /// Optional. The thumbprint of the certificate that is used to
            /// encrypt the configuration specified in PrivateConfiguration.
            /// If this element is not specified, a certificate may be
            /// automatically generated and added to the cloud service.
            /// </summary>
            public string Thumbprint
            {
                get { return this._thumbprint; }
                set { this._thumbprint = value; }
            }
            
            private string _thumbprintAlgorithm;
            
            /// <summary>
            /// Optional. The thumbprint algorithm of the certificate that is
            /// used to encrypt the configuration specified in
            /// PrivateConfiguration.
            /// </summary>
            public string ThumbprintAlgorithm
            {
                get { return this._thumbprintAlgorithm; }
                set { this._thumbprintAlgorithm = value; }
            }
            
            private string _type;
            
            /// <summary>
            /// Required. The type of the extension.
            /// </summary>
            public string Type
            {
                get { return this._type; }
                set { this._type = value; }
            }
            
            private string _version;
            
            /// <summary>
            /// Optional. The version of the extension.
            /// </summary>
            public string Version
            {
                get { return this._version; }
                set { this._version = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the Extension class.
            /// </summary>
            public Extension()
            {
            }
            
            /// <summary>
            /// Initializes a new instance of the Extension class with required
            /// arguments.
            /// </summary>
            public Extension(string type)
                : this()
            {
                if (type == null)
                {
                    throw new ArgumentNullException("type");
                }
                this.Type = type;
            }
        }
    }
}