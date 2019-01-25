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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Chatbot.Transform;
using Aliyun.Acs.Chatbot.Transform.V20171011;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Model.V20171011
{
    public class QueryKnowledgesRequest : RpcAcsRequest<QueryKnowledgesResponse>
    {
        public QueryKnowledgesRequest()
            : base("Chatbot", "2017-10-11", "QueryKnowledges", "beebot", "openAPI")
        {
        }

		private int? pageSize;

		private string coreWordName;

		private string knowledgeTitle;

		private int? pageNumber;

		private long? categoryId;

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string CoreWordName
		{
			get
			{
				return coreWordName;
			}
			set	
			{
				coreWordName = value;
				DictionaryUtil.Add(QueryParameters, "CoreWordName", value);
			}
		}

		public string KnowledgeTitle
		{
			get
			{
				return knowledgeTitle;
			}
			set	
			{
				knowledgeTitle = value;
				DictionaryUtil.Add(QueryParameters, "KnowledgeTitle", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public long? CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
				DictionaryUtil.Add(QueryParameters, "CategoryId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryKnowledgesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryKnowledgesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}