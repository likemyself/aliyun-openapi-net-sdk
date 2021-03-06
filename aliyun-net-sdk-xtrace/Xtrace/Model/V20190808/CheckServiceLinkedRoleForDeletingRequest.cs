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
using Aliyun.Acs.xtrace;
using Aliyun.Acs.xtrace.Transform;
using Aliyun.Acs.xtrace.Transform.V20190808;

namespace Aliyun.Acs.xtrace.Model.V20190808
{
    public class CheckServiceLinkedRoleForDeletingRequest : RpcAcsRequest<CheckServiceLinkedRoleForDeletingResponse>
    {
        public CheckServiceLinkedRoleForDeletingRequest()
            : base("xtrace", "2019-08-08", "CheckServiceLinkedRoleForDeleting")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sPIRegionId;

		private string roleArn;

		private string deletionTaskId;

		private string serviceName;

		public string SPIRegionId
		{
			get
			{
				return sPIRegionId;
			}
			set	
			{
				sPIRegionId = value;
				DictionaryUtil.Add(QueryParameters, "SPIRegionId", value);
			}
		}

		public string RoleArn
		{
			get
			{
				return roleArn;
			}
			set	
			{
				roleArn = value;
				DictionaryUtil.Add(QueryParameters, "RoleArn", value);
			}
		}

		public string DeletionTaskId
		{
			get
			{
				return deletionTaskId;
			}
			set	
			{
				deletionTaskId = value;
				DictionaryUtil.Add(QueryParameters, "DeletionTaskId", value);
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CheckServiceLinkedRoleForDeletingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckServiceLinkedRoleForDeletingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
