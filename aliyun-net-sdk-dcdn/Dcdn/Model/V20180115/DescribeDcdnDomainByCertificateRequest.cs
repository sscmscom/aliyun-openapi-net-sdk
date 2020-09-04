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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.dcdn;
using Aliyun.Acs.dcdn.Transform;
using Aliyun.Acs.dcdn.Transform.V20180115;

namespace Aliyun.Acs.dcdn.Model.V20180115
{
    public class DescribeDcdnDomainByCertificateRequest : RpcAcsRequest<DescribeDcdnDomainByCertificateResponse>
    {
        public DescribeDcdnDomainByCertificateRequest()
            : base("dcdn", "2018-01-15", "DescribeDcdnDomainByCertificate")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? ownerId;

		private string sSLPub;

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string SSLPub
		{
			get
			{
				return sSLPub;
			}
			set	
			{
				sSLPub = value;
				DictionaryUtil.Add(QueryParameters, "SSLPub", value);
			}
		}

        public override DescribeDcdnDomainByCertificateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDcdnDomainByCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
