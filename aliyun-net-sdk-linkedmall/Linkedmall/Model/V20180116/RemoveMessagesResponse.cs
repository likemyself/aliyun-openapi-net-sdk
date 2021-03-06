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

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class RemoveMessagesResponse : AcsResponse
	{

		private string requestId;

		private string logsId;

		private string subCode;

		private string subMessage;

		private string code;

		private string message;

		private bool? success;

		private RemoveMessages_ActionResult actionResult;

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

		public string LogsId
		{
			get
			{
				return logsId;
			}
			set	
			{
				logsId = value;
			}
		}

		public string SubCode
		{
			get
			{
				return subCode;
			}
			set	
			{
				subCode = value;
			}
		}

		public string SubMessage
		{
			get
			{
				return subMessage;
			}
			set	
			{
				subMessage = value;
			}
		}

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public RemoveMessages_ActionResult ActionResult
		{
			get
			{
				return actionResult;
			}
			set	
			{
				actionResult = value;
			}
		}

		public class RemoveMessages_ActionResult
		{

			private string returnCode;

			private string returnValue;

			private string returnMessage;

			public string ReturnCode
			{
				get
				{
					return returnCode;
				}
				set	
				{
					returnCode = value;
				}
			}

			public string ReturnValue
			{
				get
				{
					return returnValue;
				}
				set	
				{
					returnValue = value;
				}
			}

			public string ReturnMessage
			{
				get
				{
					return returnMessage;
				}
				set	
				{
					returnMessage = value;
				}
			}
		}
	}
}
