/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateInput Request Marshaller
    /// </summary>       
    public class CreateInputRequestMarshaller : IMarshaller<IRequest, CreateInputRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateInputRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateInputRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/prod/inputs";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDestinations())
                {
                    context.Writer.WritePropertyName("destinations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDestinationsListValue in publicRequest.Destinations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = InputDestinationRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestDestinationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetInputSecurityGroups())
                {
                    context.Writer.WritePropertyName("inputSecurityGroups");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInputSecurityGroupsListValue in publicRequest.InputSecurityGroups)
                    {
                            context.Writer.Write(publicRequestInputSecurityGroupsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRequestId())
                {
                    context.Writer.WritePropertyName("requestId");
                    context.Writer.Write(publicRequest.RequestId);
                }

                else if(!(publicRequest.IsSetRequestId()))
                {
                    context.Writer.WritePropertyName("requestId");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetSources())
                {
                    context.Writer.WritePropertyName("sources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourcesListValue in publicRequest.Sources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = InputSourceRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestSourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("type");
                    context.Writer.Write(publicRequest.Type);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateInputRequestMarshaller _instance = new CreateInputRequestMarshaller();        

        internal static CreateInputRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateInputRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}