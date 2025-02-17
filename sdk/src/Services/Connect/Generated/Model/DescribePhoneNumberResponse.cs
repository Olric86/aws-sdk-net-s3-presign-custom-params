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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the DescribePhoneNumber operation.
    /// </summary>
    public partial class DescribePhoneNumberResponse : AmazonWebServiceResponse
    {
        private ClaimedPhoneNumberSummary _claimedPhoneNumberSummary;

        /// <summary>
        /// Gets and sets the property ClaimedPhoneNumberSummary. 
        /// <para>
        /// Information about a phone number that's been claimed to your Amazon Connect instance.
        /// </para>
        /// </summary>
        public ClaimedPhoneNumberSummary ClaimedPhoneNumberSummary
        {
            get { return this._claimedPhoneNumberSummary; }
            set { this._claimedPhoneNumberSummary = value; }
        }

        // Check to see if ClaimedPhoneNumberSummary property is set
        internal bool IsSetClaimedPhoneNumberSummary()
        {
            return this._claimedPhoneNumberSummary != null;
        }

    }
}