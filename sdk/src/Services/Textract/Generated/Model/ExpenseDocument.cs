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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// The structure holding all the information returned by AnalyzeExpense
    /// </summary>
    public partial class ExpenseDocument
    {
        private int? _expenseIndex;
        private List<LineItemGroup> _lineItemGroups = new List<LineItemGroup>();
        private List<ExpenseField> _summaryFields = new List<ExpenseField>();

        /// <summary>
        /// Gets and sets the property ExpenseIndex. 
        /// <para>
        /// Denotes which invoice or receipt in the document the information is coming from. First
        /// document will be 1, the second 2, and so on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int ExpenseIndex
        {
            get { return this._expenseIndex.GetValueOrDefault(); }
            set { this._expenseIndex = value; }
        }

        // Check to see if ExpenseIndex property is set
        internal bool IsSetExpenseIndex()
        {
            return this._expenseIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LineItemGroups. 
        /// <para>
        /// Information detected on each table of a document, seperated into <code>LineItems</code>.
        /// </para>
        /// </summary>
        public List<LineItemGroup> LineItemGroups
        {
            get { return this._lineItemGroups; }
            set { this._lineItemGroups = value; }
        }

        // Check to see if LineItemGroups property is set
        internal bool IsSetLineItemGroups()
        {
            return this._lineItemGroups != null && this._lineItemGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SummaryFields. 
        /// <para>
        /// Any information found outside of a table by Amazon Textract.
        /// </para>
        /// </summary>
        public List<ExpenseField> SummaryFields
        {
            get { return this._summaryFields; }
            set { this._summaryFields = value; }
        }

        // Check to see if SummaryFields property is set
        internal bool IsSetSummaryFields()
        {
            return this._summaryFields != null && this._summaryFields.Count > 0; 
        }

    }
}