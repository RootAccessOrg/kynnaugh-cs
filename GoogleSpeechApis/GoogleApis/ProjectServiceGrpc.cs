// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/ml/v1beta1/project_service.proto
// Original file comments:
// Copyright 2016 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Google.Cloud.Ml.V1Beta1 {
  /// <summary>
  ///  Allows retrieving project related information.
  /// </summary>
  public static class ProjectManagementService
  {
    static readonly string __ServiceName = "google.cloud.ml.v1beta1.ProjectManagementService";

    static readonly Marshaller<global::Google.Cloud.Ml.V1Beta1.GetConfigRequest> __Marshaller_GetConfigRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Ml.V1Beta1.GetConfigRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Ml.V1Beta1.GetConfigResponse> __Marshaller_GetConfigResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Ml.V1Beta1.GetConfigResponse.Parser.ParseFrom);

    static readonly Method<global::Google.Cloud.Ml.V1Beta1.GetConfigRequest, global::Google.Cloud.Ml.V1Beta1.GetConfigResponse> __Method_GetConfig = new Method<global::Google.Cloud.Ml.V1Beta1.GetConfigRequest, global::Google.Cloud.Ml.V1Beta1.GetConfigResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetConfig",
        __Marshaller_GetConfigRequest,
        __Marshaller_GetConfigResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Ml.V1Beta1.ProjectServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProjectManagementService</summary>
    public abstract class ProjectManagementServiceBase
    {
      /// <summary>
      ///  Get the service account information associated with your project. You need
      ///  this information in order to grant the service account persmissions for
      ///  the Google Cloud Storage location where you put your model training code
      ///  for training the model with Google Cloud Machine Learning.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Ml.V1Beta1.GetConfigResponse> GetConfig(global::Google.Cloud.Ml.V1Beta1.GetConfigRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ProjectManagementService</summary>
    public class ProjectManagementServiceClient : ClientBase<ProjectManagementServiceClient>
    {
      /// <summary>Creates a new client for ProjectManagementService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ProjectManagementServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProjectManagementService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ProjectManagementServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ProjectManagementServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ProjectManagementServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Get the service account information associated with your project. You need
      ///  this information in order to grant the service account persmissions for
      ///  the Google Cloud Storage location where you put your model training code
      ///  for training the model with Google Cloud Machine Learning.
      /// </summary>
      public virtual global::Google.Cloud.Ml.V1Beta1.GetConfigResponse GetConfig(global::Google.Cloud.Ml.V1Beta1.GetConfigRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetConfig(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Get the service account information associated with your project. You need
      ///  this information in order to grant the service account persmissions for
      ///  the Google Cloud Storage location where you put your model training code
      ///  for training the model with Google Cloud Machine Learning.
      /// </summary>
      public virtual global::Google.Cloud.Ml.V1Beta1.GetConfigResponse GetConfig(global::Google.Cloud.Ml.V1Beta1.GetConfigRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetConfig, null, options, request);
      }
      /// <summary>
      ///  Get the service account information associated with your project. You need
      ///  this information in order to grant the service account persmissions for
      ///  the Google Cloud Storage location where you put your model training code
      ///  for training the model with Google Cloud Machine Learning.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Ml.V1Beta1.GetConfigResponse> GetConfigAsync(global::Google.Cloud.Ml.V1Beta1.GetConfigRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetConfigAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Get the service account information associated with your project. You need
      ///  this information in order to grant the service account persmissions for
      ///  the Google Cloud Storage location where you put your model training code
      ///  for training the model with Google Cloud Machine Learning.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Ml.V1Beta1.GetConfigResponse> GetConfigAsync(global::Google.Cloud.Ml.V1Beta1.GetConfigRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetConfig, null, options, request);
      }
      protected override ProjectManagementServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProjectManagementServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ProjectManagementServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetConfig, serviceImpl.GetConfig).Build();
    }

  }
}
#endregion
