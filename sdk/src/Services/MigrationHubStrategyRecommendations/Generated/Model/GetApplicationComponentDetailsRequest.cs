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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Container for the parameters to the GetApplicationComponentDetails operation.
    /// Retrieves details about an application component.
    /// </summary>
    public partial class GetApplicationComponentDetailsRequest : AmazonMigrationHubStrategyRecommendationsRequest
    {
        private string _applicationComponentId;

        /// <summary>
        /// Gets and sets the property ApplicationComponentId. 
        /// <para>
        ///  The ID of the application component. The ID is unique within an AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=44)]
        public string ApplicationComponentId
        {
            get { return this._applicationComponentId; }
            set { this._applicationComponentId = value; }
        }

        // Check to see if ApplicationComponentId property is set
        internal bool IsSetApplicationComponentId()
        {
            return this._applicationComponentId != null;
        }

    }
}