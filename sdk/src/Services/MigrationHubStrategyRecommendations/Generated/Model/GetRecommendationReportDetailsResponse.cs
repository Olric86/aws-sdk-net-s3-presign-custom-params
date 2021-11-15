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
    /// This is the response object from the GetRecommendationReportDetails operation.
    /// </summary>
    public partial class GetRecommendationReportDetailsResponse : AmazonWebServiceResponse
    {
        private string _id;
        private RecommendationReportDetails _recommendationReportDetails;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The ID of the recommendation report generation task. See the response of <a>StartRecommendationReportGeneration</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=52)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationReportDetails. 
        /// <para>
        ///  Detailed information about the recommendation report. 
        /// </para>
        /// </summary>
        public RecommendationReportDetails RecommendationReportDetails
        {
            get { return this._recommendationReportDetails; }
            set { this._recommendationReportDetails = value; }
        }

        // Check to see if RecommendationReportDetails property is set
        internal bool IsSetRecommendationReportDetails()
        {
            return this._recommendationReportDetails != null;
        }

    }
}