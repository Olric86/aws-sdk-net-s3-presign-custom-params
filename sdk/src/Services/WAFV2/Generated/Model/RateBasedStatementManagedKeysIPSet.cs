/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The set of IP addresses that are currently blocked for a <a>RateBasedStatement</a>.
    /// </summary>
    public partial class RateBasedStatementManagedKeysIPSet
    {
        private List<string> _addresses = new List<string>();
        private IPAddressVersion _ipAddressVersion;

        /// <summary>
        /// Gets and sets the property Addresses. 
        /// <para>
        /// The IP addresses that are currently blocked.
        /// </para>
        /// </summary>
        public List<string> Addresses
        {
            get { return this._addresses; }
            set { this._addresses = value; }
        }

        // Check to see if Addresses property is set
        internal bool IsSetAddresses()
        {
            return this._addresses != null && this._addresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IPAddressVersion. 
        /// <para>
        /// The version of the IP addresses, either <code>IPV4</code> or <code>IPV6</code>. 
        /// </para>
        /// </summary>
        public IPAddressVersion IPAddressVersion
        {
            get { return this._ipAddressVersion; }
            set { this._ipAddressVersion = value; }
        }

        // Check to see if IPAddressVersion property is set
        internal bool IsSetIPAddressVersion()
        {
            return this._ipAddressVersion != null;
        }

    }
}