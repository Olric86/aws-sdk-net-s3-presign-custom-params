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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLiveSource operation.
    /// Updates a specific live source in a specific source location.
    /// </summary>
    public partial class UpdateLiveSourceRequest : AmazonMediaTailorRequest
    {
        private List<HttpPackageConfiguration> _httpPackageConfigurations = new List<HttpPackageConfiguration>();
        private string _liveSourceName;
        private string _sourceLocationName;

        /// <summary>
        /// Gets and sets the property HttpPackageConfigurations. 
        /// <para>
        /// A list of HTTP package configurations for the live source on this account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<HttpPackageConfiguration> HttpPackageConfigurations
        {
            get { return this._httpPackageConfigurations; }
            set { this._httpPackageConfigurations = value; }
        }

        // Check to see if HttpPackageConfigurations property is set
        internal bool IsSetHttpPackageConfigurations()
        {
            return this._httpPackageConfigurations != null && this._httpPackageConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LiveSourceName. 
        /// <para>
        /// The identifier for the live source you are working on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LiveSourceName
        {
            get { return this._liveSourceName; }
            set { this._liveSourceName = value; }
        }

        // Check to see if LiveSourceName property is set
        internal bool IsSetLiveSourceName()
        {
            return this._liveSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The identifier for the source location you are working on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceLocationName
        {
            get { return this._sourceLocationName; }
            set { this._sourceLocationName = value; }
        }

        // Check to see if SourceLocationName property is set
        internal bool IsSetSourceLocationName()
        {
            return this._sourceLocationName != null;
        }

    }
}