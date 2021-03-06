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

namespace Aliyun.Acs.Vcs.Model.V20200515
{
	public class ListUserGroupsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private List<ListUserGroups_DataItem> data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<ListUserGroups_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListUserGroups_DataItem
		{

			private string creator;

			private string userGroupName;

			private string isvSubId;

			private long? userGroupId;

			private long? userCount;

			private string createTime;

			private string updateTime;

			private long? parentUserGroupId;

			public string Creator
			{
				get
				{
					return creator;
				}
				set	
				{
					creator = value;
				}
			}

			public string UserGroupName
			{
				get
				{
					return userGroupName;
				}
				set	
				{
					userGroupName = value;
				}
			}

			public string IsvSubId
			{
				get
				{
					return isvSubId;
				}
				set	
				{
					isvSubId = value;
				}
			}

			public long? UserGroupId
			{
				get
				{
					return userGroupId;
				}
				set	
				{
					userGroupId = value;
				}
			}

			public long? UserCount
			{
				get
				{
					return userCount;
				}
				set	
				{
					userCount = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public long? ParentUserGroupId
			{
				get
				{
					return parentUserGroupId;
				}
				set	
				{
					parentUserGroupId = value;
				}
			}
		}
	}
}
