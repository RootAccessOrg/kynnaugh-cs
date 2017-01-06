// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dataproc/v1/clusters.proto
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

namespace Google.Cloud.Dataproc.V1 {
  /// <summary>
  ///  The ClusterControllerService provides methods to manage clusters
  ///  of Google Compute Engine instances.
  /// </summary>
  public static class ClusterController
  {
    static readonly string __ServiceName = "google.cloud.dataproc.v1.ClusterController";

    static readonly Marshaller<global::Google.Cloud.Dataproc.V1.CreateClusterRequest> __Marshaller_CreateClusterRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dataproc.V1.CreateClusterRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.LongRunning.Operation> __Marshaller_Operation = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.Operation.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Dataproc.V1.UpdateClusterRequest> __Marshaller_UpdateClusterRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dataproc.V1.UpdateClusterRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Dataproc.V1.DeleteClusterRequest> __Marshaller_DeleteClusterRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dataproc.V1.DeleteClusterRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Dataproc.V1.GetClusterRequest> __Marshaller_GetClusterRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dataproc.V1.GetClusterRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Dataproc.V1.Cluster> __Marshaller_Cluster = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dataproc.V1.Cluster.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Dataproc.V1.ListClustersRequest> __Marshaller_ListClustersRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dataproc.V1.ListClustersRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Dataproc.V1.ListClustersResponse> __Marshaller_ListClustersResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dataproc.V1.ListClustersResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Dataproc.V1.DiagnoseClusterRequest> __Marshaller_DiagnoseClusterRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dataproc.V1.DiagnoseClusterRequest.Parser.ParseFrom);

    static readonly Method<global::Google.Cloud.Dataproc.V1.CreateClusterRequest, global::Google.LongRunning.Operation> __Method_CreateCluster = new Method<global::Google.Cloud.Dataproc.V1.CreateClusterRequest, global::Google.LongRunning.Operation>(
        MethodType.Unary,
        __ServiceName,
        "CreateCluster",
        __Marshaller_CreateClusterRequest,
        __Marshaller_Operation);

    static readonly Method<global::Google.Cloud.Dataproc.V1.UpdateClusterRequest, global::Google.LongRunning.Operation> __Method_UpdateCluster = new Method<global::Google.Cloud.Dataproc.V1.UpdateClusterRequest, global::Google.LongRunning.Operation>(
        MethodType.Unary,
        __ServiceName,
        "UpdateCluster",
        __Marshaller_UpdateClusterRequest,
        __Marshaller_Operation);

    static readonly Method<global::Google.Cloud.Dataproc.V1.DeleteClusterRequest, global::Google.LongRunning.Operation> __Method_DeleteCluster = new Method<global::Google.Cloud.Dataproc.V1.DeleteClusterRequest, global::Google.LongRunning.Operation>(
        MethodType.Unary,
        __ServiceName,
        "DeleteCluster",
        __Marshaller_DeleteClusterRequest,
        __Marshaller_Operation);

    static readonly Method<global::Google.Cloud.Dataproc.V1.GetClusterRequest, global::Google.Cloud.Dataproc.V1.Cluster> __Method_GetCluster = new Method<global::Google.Cloud.Dataproc.V1.GetClusterRequest, global::Google.Cloud.Dataproc.V1.Cluster>(
        MethodType.Unary,
        __ServiceName,
        "GetCluster",
        __Marshaller_GetClusterRequest,
        __Marshaller_Cluster);

    static readonly Method<global::Google.Cloud.Dataproc.V1.ListClustersRequest, global::Google.Cloud.Dataproc.V1.ListClustersResponse> __Method_ListClusters = new Method<global::Google.Cloud.Dataproc.V1.ListClustersRequest, global::Google.Cloud.Dataproc.V1.ListClustersResponse>(
        MethodType.Unary,
        __ServiceName,
        "ListClusters",
        __Marshaller_ListClustersRequest,
        __Marshaller_ListClustersResponse);

    static readonly Method<global::Google.Cloud.Dataproc.V1.DiagnoseClusterRequest, global::Google.LongRunning.Operation> __Method_DiagnoseCluster = new Method<global::Google.Cloud.Dataproc.V1.DiagnoseClusterRequest, global::Google.LongRunning.Operation>(
        MethodType.Unary,
        __ServiceName,
        "DiagnoseCluster",
        __Marshaller_DiagnoseClusterRequest,
        __Marshaller_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dataproc.V1.ClustersReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ClusterController</summary>
    public abstract class ClusterControllerBase
    {
      /// <summary>
      ///  Creates a cluster in a project.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateCluster(global::Google.Cloud.Dataproc.V1.CreateClusterRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Updates a cluster in a project.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> UpdateCluster(global::Google.Cloud.Dataproc.V1.UpdateClusterRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Deletes a cluster in a project.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> DeleteCluster(global::Google.Cloud.Dataproc.V1.DeleteClusterRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Gets the resource representation for a cluster in a project.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataproc.V1.Cluster> GetCluster(global::Google.Cloud.Dataproc.V1.GetClusterRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Lists all regions/{region}/clusters in a project.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataproc.V1.ListClustersResponse> ListClusters(global::Google.Cloud.Dataproc.V1.ListClustersRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Gets cluster diagnostic information.
      ///  After the operation completes, the Operation.response field
      ///  contains `DiagnoseClusterOutputLocation`.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> DiagnoseCluster(global::Google.Cloud.Dataproc.V1.DiagnoseClusterRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ClusterController</summary>
    public class ClusterControllerClient : ClientBase<ClusterControllerClient>
    {
      /// <summary>Creates a new client for ClusterController</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ClusterControllerClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ClusterController that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ClusterControllerClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ClusterControllerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ClusterControllerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Creates a cluster in a project.
      /// </summary>
      public virtual global::Google.LongRunning.Operation CreateCluster(global::Google.Cloud.Dataproc.V1.CreateClusterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateCluster(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Creates a cluster in a project.
      /// </summary>
      public virtual global::Google.LongRunning.Operation CreateCluster(global::Google.Cloud.Dataproc.V1.CreateClusterRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateCluster, null, options, request);
      }
      /// <summary>
      ///  Creates a cluster in a project.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.LongRunning.Operation> CreateClusterAsync(global::Google.Cloud.Dataproc.V1.CreateClusterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateClusterAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Creates a cluster in a project.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.LongRunning.Operation> CreateClusterAsync(global::Google.Cloud.Dataproc.V1.CreateClusterRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateCluster, null, options, request);
      }
      /// <summary>
      ///  Updates a cluster in a project.
      /// </summary>
      public virtual global::Google.LongRunning.Operation UpdateCluster(global::Google.Cloud.Dataproc.V1.UpdateClusterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateCluster(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Updates a cluster in a project.
      /// </summary>
      public virtual global::Google.LongRunning.Operation UpdateCluster(global::Google.Cloud.Dataproc.V1.UpdateClusterRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateCluster, null, options, request);
      }
      /// <summary>
      ///  Updates a cluster in a project.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateClusterAsync(global::Google.Cloud.Dataproc.V1.UpdateClusterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateClusterAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Updates a cluster in a project.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateClusterAsync(global::Google.Cloud.Dataproc.V1.UpdateClusterRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateCluster, null, options, request);
      }
      /// <summary>
      ///  Deletes a cluster in a project.
      /// </summary>
      public virtual global::Google.LongRunning.Operation DeleteCluster(global::Google.Cloud.Dataproc.V1.DeleteClusterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteCluster(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Deletes a cluster in a project.
      /// </summary>
      public virtual global::Google.LongRunning.Operation DeleteCluster(global::Google.Cloud.Dataproc.V1.DeleteClusterRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteCluster, null, options, request);
      }
      /// <summary>
      ///  Deletes a cluster in a project.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteClusterAsync(global::Google.Cloud.Dataproc.V1.DeleteClusterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteClusterAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Deletes a cluster in a project.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteClusterAsync(global::Google.Cloud.Dataproc.V1.DeleteClusterRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteCluster, null, options, request);
      }
      /// <summary>
      ///  Gets the resource representation for a cluster in a project.
      /// </summary>
      public virtual global::Google.Cloud.Dataproc.V1.Cluster GetCluster(global::Google.Cloud.Dataproc.V1.GetClusterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetCluster(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets the resource representation for a cluster in a project.
      /// </summary>
      public virtual global::Google.Cloud.Dataproc.V1.Cluster GetCluster(global::Google.Cloud.Dataproc.V1.GetClusterRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCluster, null, options, request);
      }
      /// <summary>
      ///  Gets the resource representation for a cluster in a project.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.Cluster> GetClusterAsync(global::Google.Cloud.Dataproc.V1.GetClusterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetClusterAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets the resource representation for a cluster in a project.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.Cluster> GetClusterAsync(global::Google.Cloud.Dataproc.V1.GetClusterRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCluster, null, options, request);
      }
      /// <summary>
      ///  Lists all regions/{region}/clusters in a project.
      /// </summary>
      public virtual global::Google.Cloud.Dataproc.V1.ListClustersResponse ListClusters(global::Google.Cloud.Dataproc.V1.ListClustersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListClusters(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Lists all regions/{region}/clusters in a project.
      /// </summary>
      public virtual global::Google.Cloud.Dataproc.V1.ListClustersResponse ListClusters(global::Google.Cloud.Dataproc.V1.ListClustersRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListClusters, null, options, request);
      }
      /// <summary>
      ///  Lists all regions/{region}/clusters in a project.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.ListClustersResponse> ListClustersAsync(global::Google.Cloud.Dataproc.V1.ListClustersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListClustersAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Lists all regions/{region}/clusters in a project.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.ListClustersResponse> ListClustersAsync(global::Google.Cloud.Dataproc.V1.ListClustersRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListClusters, null, options, request);
      }
      /// <summary>
      ///  Gets cluster diagnostic information.
      ///  After the operation completes, the Operation.response field
      ///  contains `DiagnoseClusterOutputLocation`.
      /// </summary>
      public virtual global::Google.LongRunning.Operation DiagnoseCluster(global::Google.Cloud.Dataproc.V1.DiagnoseClusterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DiagnoseCluster(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets cluster diagnostic information.
      ///  After the operation completes, the Operation.response field
      ///  contains `DiagnoseClusterOutputLocation`.
      /// </summary>
      public virtual global::Google.LongRunning.Operation DiagnoseCluster(global::Google.Cloud.Dataproc.V1.DiagnoseClusterRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DiagnoseCluster, null, options, request);
      }
      /// <summary>
      ///  Gets cluster diagnostic information.
      ///  After the operation completes, the Operation.response field
      ///  contains `DiagnoseClusterOutputLocation`.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.LongRunning.Operation> DiagnoseClusterAsync(global::Google.Cloud.Dataproc.V1.DiagnoseClusterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DiagnoseClusterAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets cluster diagnostic information.
      ///  After the operation completes, the Operation.response field
      ///  contains `DiagnoseClusterOutputLocation`.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.LongRunning.Operation> DiagnoseClusterAsync(global::Google.Cloud.Dataproc.V1.DiagnoseClusterRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DiagnoseCluster, null, options, request);
      }
      protected override ClusterControllerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ClusterControllerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ClusterControllerBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateCluster, serviceImpl.CreateCluster)
          .AddMethod(__Method_UpdateCluster, serviceImpl.UpdateCluster)
          .AddMethod(__Method_DeleteCluster, serviceImpl.DeleteCluster)
          .AddMethod(__Method_GetCluster, serviceImpl.GetCluster)
          .AddMethod(__Method_ListClusters, serviceImpl.ListClusters)
          .AddMethod(__Method_DiagnoseCluster, serviceImpl.DiagnoseCluster).Build();
    }

  }
}
#endregion
