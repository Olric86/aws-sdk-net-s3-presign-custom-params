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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMeetings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMeetings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Meeting Object
    /// </summary>  
    public class MeetingUnmarshaller : IUnmarshaller<Meeting, XmlUnmarshallerContext>, IUnmarshaller<Meeting, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Meeting IUnmarshaller<Meeting, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Meeting Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Meeting unmarshalledObject = new Meeting();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ExternalMeetingId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExternalMeetingId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MediaPlacement", targetDepth))
                {
                    var unmarshaller = MediaPlacementUnmarshaller.Instance;
                    unmarshalledObject.MediaPlacement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MediaRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MeetingFeatures", targetDepth))
                {
                    var unmarshaller = MeetingFeaturesConfigurationUnmarshaller.Instance;
                    unmarshalledObject.MeetingFeatures = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MeetingHostId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MeetingHostId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MeetingId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MeetingId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrimaryMeetingId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrimaryMeetingId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TenantIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TenantIds = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MeetingUnmarshaller _instance = new MeetingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MeetingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}