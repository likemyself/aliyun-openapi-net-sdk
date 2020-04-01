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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class UpdateEslDeviceLightResponseUnmarshaller
    {
        public static UpdateEslDeviceLightResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateEslDeviceLightResponse updateEslDeviceLightResponse = new UpdateEslDeviceLightResponse();

			updateEslDeviceLightResponse.HttpResponse = context.HttpResponse;
			updateEslDeviceLightResponse.ErrorMessage = context.StringValue("UpdateEslDeviceLight.ErrorMessage");
			updateEslDeviceLightResponse.ErrorCode = context.StringValue("UpdateEslDeviceLight.ErrorCode");
			updateEslDeviceLightResponse.Message = context.StringValue("UpdateEslDeviceLight.Message");
			updateEslDeviceLightResponse.SuccessCount = context.IntegerValue("UpdateEslDeviceLight.SuccessCount");
			updateEslDeviceLightResponse.FailCount = context.IntegerValue("UpdateEslDeviceLight.FailCount");
			updateEslDeviceLightResponse.DynamicCode = context.StringValue("UpdateEslDeviceLight.DynamicCode");
			updateEslDeviceLightResponse.Code = context.StringValue("UpdateEslDeviceLight.Code");
			updateEslDeviceLightResponse.DynamicMessage = context.StringValue("UpdateEslDeviceLight.DynamicMessage");
			updateEslDeviceLightResponse.RequestId = context.StringValue("UpdateEslDeviceLight.RequestId");
			updateEslDeviceLightResponse.Success = context.BooleanValue("UpdateEslDeviceLight.Success");

			List<UpdateEslDeviceLightResponse.UpdateEslDeviceLight_LightFailEslInfo> updateEslDeviceLightResponse_lightFailEslInfos = new List<UpdateEslDeviceLightResponse.UpdateEslDeviceLight_LightFailEslInfo>();
			for (int i = 0; i < context.Length("UpdateEslDeviceLight.LightFailEslInfos.Length"); i++) {
				UpdateEslDeviceLightResponse.UpdateEslDeviceLight_LightFailEslInfo lightFailEslInfo = new UpdateEslDeviceLightResponse.UpdateEslDeviceLight_LightFailEslInfo();
				lightFailEslInfo.ErrorMessage = context.StringValue("UpdateEslDeviceLight.LightFailEslInfos["+ i +"].ErrorMessage");
				lightFailEslInfo.EslBarCode = context.StringValue("UpdateEslDeviceLight.LightFailEslInfos["+ i +"].EslBarCode");

				updateEslDeviceLightResponse_lightFailEslInfos.Add(lightFailEslInfo);
			}
			updateEslDeviceLightResponse.LightFailEslInfos = updateEslDeviceLightResponse_lightFailEslInfos;
        
			return updateEslDeviceLightResponse;
        }
    }
}
