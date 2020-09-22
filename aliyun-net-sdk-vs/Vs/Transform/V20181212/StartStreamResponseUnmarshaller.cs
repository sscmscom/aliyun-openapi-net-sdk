/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class StartStreamResponseUnmarshaller
    {
        public static StartStreamResponse Unmarshall(UnmarshallerContext context)
        {
			StartStreamResponse startStreamResponse = new StartStreamResponse();

			startStreamResponse.HttpResponse = context.HttpResponse;
			startStreamResponse.RequestId = context.StringValue("StartStream.RequestId");
			startStreamResponse.Id = context.StringValue("StartStream.Id");
			startStreamResponse.Name = context.StringValue("StartStream.Name");
        
			return startStreamResponse;
        }
    }
}
