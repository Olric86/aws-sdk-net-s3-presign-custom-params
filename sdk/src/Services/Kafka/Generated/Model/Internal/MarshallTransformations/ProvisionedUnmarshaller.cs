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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Provisioned Object
    /// </summary>  
    public class ProvisionedUnmarshaller : IUnmarshaller<Provisioned, XmlUnmarshallerContext>, IUnmarshaller<Provisioned, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Provisioned IUnmarshaller<Provisioned, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Provisioned Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Provisioned unmarshalledObject = new Provisioned();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("brokerNodeGroupInfo", targetDepth))
                {
                    var unmarshaller = BrokerNodeGroupInfoUnmarshaller.Instance;
                    unmarshalledObject.BrokerNodeGroupInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientAuthentication", targetDepth))
                {
                    var unmarshaller = ClientAuthenticationUnmarshaller.Instance;
                    unmarshalledObject.ClientAuthentication = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentBrokerSoftwareInfo", targetDepth))
                {
                    var unmarshaller = BrokerSoftwareInfoUnmarshaller.Instance;
                    unmarshalledObject.CurrentBrokerSoftwareInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryptionInfo", targetDepth))
                {
                    var unmarshaller = EncryptionInfoUnmarshaller.Instance;
                    unmarshalledObject.EncryptionInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enhancedMonitoring", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EnhancedMonitoring = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("loggingInfo", targetDepth))
                {
                    var unmarshaller = LoggingInfoUnmarshaller.Instance;
                    unmarshalledObject.LoggingInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberOfBrokerNodes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfBrokerNodes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("openMonitoring", targetDepth))
                {
                    var unmarshaller = OpenMonitoringInfoUnmarshaller.Instance;
                    unmarshalledObject.OpenMonitoring = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zookeeperConnectString", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ZookeeperConnectString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zookeeperConnectStringTls", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ZookeeperConnectStringTls = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProvisionedUnmarshaller _instance = new ProvisionedUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProvisionedUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}