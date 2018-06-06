// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Ads.GoogleAds.V0.Services.Tests {

  using Google.Ads.GoogleAds.V0.Resources;
  using Google.Ads.GoogleAds.V0.Services;
  using Grpc.Core;
  using Moq;
  using NUnit.Framework;
  using System.Threading.Tasks;

  /// <summary>Generated unit tests</summary>
  public class GeneratedGeoTargetConstantServiceClientTest {

    [Test]
    public void GetGeoTargetConstant() {
      Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(MockBehavior.Strict);
      GetGeoTargetConstantRequest expectedRequest = new GetGeoTargetConstantRequest {
        ResourceName = new GeoTargetConstantName("[GEO_TARGET_CONSTANT]").ToString(),
      };
      GeoTargetConstant expectedResponse = new GeoTargetConstant {
        ResourceName = "resourceName2625949903",
      };
      mockGrpcClient.Setup(x => x.GetGeoTargetConstant(expectedRequest, It.IsAny<CallOptions>()))
          .Returns(expectedResponse);
      GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
      string formattedResourceName = new GeoTargetConstantName("[GEO_TARGET_CONSTANT]").ToString();
      GeoTargetConstant response = client.GetGeoTargetConstant(formattedResourceName);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public async Task GetGeoTargetConstantAsync() {
      Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(MockBehavior.Strict);
      GetGeoTargetConstantRequest expectedRequest = new GetGeoTargetConstantRequest {
        ResourceName = new GeoTargetConstantName("[GEO_TARGET_CONSTANT]").ToString(),
      };
      GeoTargetConstant expectedResponse = new GeoTargetConstant {
        ResourceName = "resourceName2625949903",
      };
      mockGrpcClient.Setup(x => x.GetGeoTargetConstantAsync(expectedRequest, It.IsAny<CallOptions>()))
          .Returns(new Grpc.Core.AsyncUnaryCall<GeoTargetConstant>(Task.FromResult(expectedResponse), null, null, null, null));
      GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
      string formattedResourceName = new GeoTargetConstantName("[GEO_TARGET_CONSTANT]").ToString();
      GeoTargetConstant response = await client.GetGeoTargetConstantAsync(formattedResourceName);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public void GetGeoTargetConstant2() {
      Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(MockBehavior.Strict);
      GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest {
        ResourceName = new GeoTargetConstantName("[GEO_TARGET_CONSTANT]").ToString(),
      };
      GeoTargetConstant expectedResponse = new GeoTargetConstant {
        ResourceName = "resourceName2625949903",
      };
      mockGrpcClient.Setup(x => x.GetGeoTargetConstant(request, It.IsAny<CallOptions>()))
          .Returns(expectedResponse);
      GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
      GeoTargetConstant response = client.GetGeoTargetConstant(request);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public async Task GetGeoTargetConstantAsync2() {
      Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(MockBehavior.Strict);
      GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest {
        ResourceName = new GeoTargetConstantName("[GEO_TARGET_CONSTANT]").ToString(),
      };
      GeoTargetConstant expectedResponse = new GeoTargetConstant {
        ResourceName = "resourceName2625949903",
      };
      mockGrpcClient.Setup(x => x.GetGeoTargetConstantAsync(request, It.IsAny<CallOptions>()))
          .Returns(new Grpc.Core.AsyncUnaryCall<GeoTargetConstant>(Task.FromResult(expectedResponse), null, null, null, null));
      GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
      GeoTargetConstant response = await client.GetGeoTargetConstantAsync(request);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }
  }
}