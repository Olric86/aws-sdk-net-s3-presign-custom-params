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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeComputeEnvironments operation.
    /// Describes one or more of your compute environments.
    /// 
    ///  
    /// <para>
    /// If you're using an unmanaged compute environment, you can use the <code>DescribeComputeEnvironment</code>
    /// operation to determine the <code>ecsClusterArn</code> that you launch your Amazon
    /// ECS container instances into.
    /// </para>
    /// </summary>
    public partial class DescribeComputeEnvironmentsRequest : AmazonBatchRequest
    {
        private List<string> _computeEnvironments = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ComputeEnvironments. 
        /// <para>
        /// A list of up to 100 compute environment names or full Amazon Resource Name (ARN) entries.
        /// </para>
        /// </summary>
        public List<string> ComputeEnvironments
        {
            get { return this._computeEnvironments; }
            set { this._computeEnvironments = value; }
        }

        // Check to see if ComputeEnvironments property is set
        internal bool IsSetComputeEnvironments()
        {
            return this._computeEnvironments != null && this._computeEnvironments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of cluster results returned by <code>DescribeComputeEnvironments</code>
        /// in paginated output. When this parameter is used, <code>DescribeComputeEnvironments</code>
        /// only returns <code>maxResults</code> results in a single page along with a <code>nextToken</code>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <code>DescribeComputeEnvironments</code> request with the returned <code>nextToken</code>
        /// value. This value can be between 1 and 100. If this parameter isn't used, then <code>DescribeComputeEnvironments</code>
        /// returns up to 100 results and a <code>nextToken</code> value if applicable.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value returned from a previous paginated <code>DescribeComputeEnvironments</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value. This value is <code>null</code> when there
        /// are no more results to return.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that's only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}