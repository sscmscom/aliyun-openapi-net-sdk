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

namespace Aliyun.Acs.dcdn.Model.V20180115
{
	public class DescribeDcdnBgpBpsDataResponse : AcsResponse
	{

		private string requestId;

		private string startTime;

		private string endTime;

		private List<DescribeDcdnBgpBpsData_BgpData> bgpDataInterval;

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

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public List<DescribeDcdnBgpBpsData_BgpData> BgpDataInterval
		{
			get
			{
				return bgpDataInterval;
			}
			set	
			{
				bgpDataInterval = value;
			}
		}

		public class DescribeDcdnBgpBpsData_BgpData
		{

			private float? _in;

			private float? _out;

			private string timeStamp;

			public float? _In
			{
				get
				{
					return _in;
				}
				set	
				{
					_in = value;
				}
			}

			public float? _Out
			{
				get
				{
					return _out;
				}
				set	
				{
					_out = value;
				}
			}

			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}
		}
	}
}
